using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
namespace GcproExtensionLibrary.FileHandle
{
    public class ExcelFileHandle: BaseFileHandle
    {

        public static string FileFilter = @"Excel File   (*.xlsx)|*.xlsx|Excel File   (*.xls)|CSV File   (*.CSV)|*.CSV|*.xls|All Files (*.*)|*.*";
        private readonly static string fileType = "Excel 文件";
        private string filePath = string.Empty;
        private string workSheet = string.Empty;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        public string WorkSheet
        {
            get { return workSheet; }
            set { workSheet = value; }
        }
        public ExcelFileHandle()
        {

        }
        public ExcelFileHandle(string filePath) : this()
        {
            this.filePath = filePath;
        }
        public static string BrowseFile()
        {
            return Browse(FileFilter, 1, false, true, "请选择一个" + fileType);
        }

        public List<string> GetWorkSheets(string filePath = null)
        {
            string _filePath = (string.IsNullOrEmpty(filePath)) ? this.filePath : filePath;
            FileInfo fileInfo = new FileInfo(_filePath);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                // ExcelPackage.Workbook.Worksheets worksheets = package.Workbook.Worksheets;
                ExcelWorksheets worksheets = package.Workbook.Worksheets;
                List<string> listWorkSheetNames = new List<string>();
                foreach (var worksheet in worksheets)
                {

                    listWorkSheetNames.Add(worksheet.Name);
                }
                return listWorkSheetNames;
            }
        }

        public List<Dictionary<string, object>> ReadAsList(int startRow, string[] columnsToRead, string filter, string filterColumn, string filePath = null, string workSheetName = null)
        {
            try
            {
                string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
                string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;

                FileInfo fileInfo = new FileInfo(effectiveFilePath);
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null)
                    {
                        throw new ArgumentException("Worksheet not found: " + effectiveWorksheetName, nameof(workSheetName));
                    }

                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int filterColumnIndex = ConvertColumnNameToNumber(filterColumn);

                    // 遍历所有数据行，筛选符合条件的行
                    for (int row = startRow; row <= rowCount; row++)
                    {
                        object filterCell = worksheet.Cells[row, filterColumnIndex].Value;
                        if (filterCell == null || filterCell.ToString() != filter)
                        {
                            continue;
                        }

                        // 将符合条件的行数据填充到Dictionary并添加到List
                        Dictionary<string, object> rowData = new Dictionary<string, object>();
                        for (int i = 0; i < columnsToRead.Length; i++)
                        {
                            int colIndex = ConvertColumnNameToNumber(columnsToRead[i]);
                            rowData[$"Column {i + 1}"] = worksheet.Cells[row, colIndex].Value;
                        }
                        result.Add(rowData);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error reading file: " + ex.Message);
            }
        }
        public List<Dictionary<string, object>> ReadAsList(int startRow, string[] columnsToRead, string[] filter, string[] filterColumn, string filePath = null, string workSheetName = null)
        {
            try
            {
                string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
                string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;

                FileInfo fileInfo = new FileInfo(effectiveFilePath);
                List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null) throw new ArgumentException("Worksheet not found: " + effectiveWorksheetName, nameof(workSheetName));
           
                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int[] filterColumnIndexes = filterColumn.Select(ConvertColumnNameToNumber).ToArray();

                    // 用 LINQ 筛选符合条件的行
                    var filteredRows = Enumerable.Range(startRow, rowCount - startRow + 1)
                        .Select(row => new { RowIndex = row, FilterCells = filterColumnIndexes.Select(idx => worksheet.Cells[row, idx].Value).ToArray() })
                        .Where(x => FilterExpressions(x.FilterCells, filter));

                    // 遍历筛选后的行并填充结果
                    foreach (var row in filteredRows)
                    {
                        Dictionary<string, object> rowData = new Dictionary<string, object>();
                        for (int i = 0; i < columnsToRead.Length; i++)
                        {
                            int colIndex = ConvertColumnNameToNumber(columnsToRead[i]);
                            rowData[$"Column {i + 1}"] = worksheet.Cells[row.RowIndex, colIndex].Value;
                        }
                        result.Add(rowData);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error reading file: " + ex.Message);
            }
        }
        public DataTable ReadAsDataTable(int startRow, string[] columnsToRead, string filter, string filterColumn, string sortColumn = null, bool ascending = true, string filePath = null, string workSheetName = null)
        {
            try
            {
                string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
                string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;

                FileInfo fileInfo = new FileInfo(effectiveFilePath);
                DataTable dataTable = new DataTable();

                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null)
                    {
                        throw new ArgumentException(LibGlobalSource.EX_FILE_NOT_FOUND + $"'{effectiveWorksheetName}'", nameof(workSheetName));
                    }
                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int filterColumnIndex = ConvertColumnNameToNumber(filterColumn);

                    // 设置DataTable的列
                    for (int i = 0; i < columnsToRead.Length; i++)
                    {
                        dataTable.Columns.Add($"Column {i + 1}");
                    }

                    for (int row = startRow; row <= rowCount; row++)
                    {
                        object filterCell = worksheet.Cells[row, filterColumnIndex].Value;
                        if (filterCell == null || filterCell.ToString() != filter)
                        {
                            continue;
                        }

                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < columnsToRead.Length; i++)
                        {
                            int colIndex = ConvertColumnNameToNumber(columnsToRead[i]);
                            dataRow[$"Column {i + 1}"] = worksheet.Cells[row, colIndex].Value;
                        }
                        dataTable.Rows.Add(dataRow);

                        if (!string.IsNullOrEmpty(sortColumn))
                        {
                            int sortIndex = Array.IndexOf(columnsToRead, sortColumn);
                            if (sortIndex != -1)
                            {
                                DataView dataView = dataTable.DefaultView;
                                dataView.Sort = $"Column {sortIndex + 1} {(ascending ? "ASC" : "DESC")}";
                                dataTable = dataView.ToTable();
                            }
                        }

                    }
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(LibGlobalSource.EX_READING_FILE + $"： {ex.Message}");
            }

        }
        public DataTable ReadAsDataTable(int startRow, string[] columnsToRead, string[] filter, string[] filterColumn, string sortColumn = null, bool ascending = true, string filePath = null, string workSheetName = null)
        {
            try
            {
                string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
                string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;
                FileInfo fileInfo = new FileInfo(effectiveFilePath);
                DataTable dataTable = new DataTable();

                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null)
                    {
                        throw new ArgumentException("Worksheet not found: " + effectiveWorksheetName, nameof(workSheetName));
                    }

                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int[] filterColumnIndexes = filterColumn.Select(ConvertColumnNameToNumber).ToArray();

                    for (int i = 0; i < columnsToRead.Length; i++)
                    {
                        dataTable.Columns.Add($"Column {i + 1}");
                    }

                    var filteredRows = Enumerable.Range(startRow, rowCount - startRow + 1)
                        .Select(row =>
                        new
                        {
                            RowIndex = row,
                            FilterCells = filterColumnIndexes.Select(idx => worksheet.Cells[row, idx].Value).ToArray()
                        }
                        )
                        .Where(filters => FilterExpressions(filters.FilterCells, filter));


                    foreach (var row in filteredRows)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < columnsToRead.Length; i++)
                        {
                            int colIndex = ConvertColumnNameToNumber(columnsToRead[i]);
                            dataRow[$"Column {i + 1}"] = worksheet.Cells[row.RowIndex, colIndex].Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }

                    if (!string.IsNullOrEmpty(sortColumn))
                    {
                        int sortIndex = Array.IndexOf(columnsToRead, sortColumn);
                        if (sortIndex != -1)
                        {
                            DataView dataView = dataTable.DefaultView;
                            dataView.Sort = $"Column {sortIndex + 1} {(ascending ? "ASC" : "DESC")}";
                            dataTable = dataView.ToTable();
                        }
                    }

                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error reading file: " + ex.Message);
            }
        }

        #region SubFunctions for ReadAsDataTable

        private bool FilterExpressions(object[] cellValues, string[] filters)
        {
            for (int i = 0; i < filters.Length; i++)
            {
                string cellText = cellValues[i]?.ToString() ?? string.Empty;
                if (!Evaluate(FilterExpressionToTokens(filters[i]), cellText))
                {
                    return false;
                }
            }
            return true;
        }

        // 将逻辑表达式拆分为标记（token）
        private List<string> FilterExpressionToTokens(string filter)
        {
            var tokens = new List<string>();
            var tokenPattern = @"(\()|(\))|(\|\|)|(&&)|(!=)|(==)|(LIKE)|(NOT LIKE)|(<)|(<=)|(>)|(>=)|(\w+)|(""[^""]*"")";
            MatchCollection matches = Regex.Matches(filter, tokenPattern);
            foreach (Match match in matches)
            {
                tokens.Add(match.Value);
            }
            return tokens;
        }


        // 递归地评估表达式
        private bool Evaluate(List<string> tokens, string cellValue)
        {
            int index = 0;
            return ParseExpression(tokens, ref index, cellValue);
        }


        // 解析表达式
        private bool ParseExpression(List<string> tokens, ref int index, string cellValue)
        {
            bool value = ParseTerm(tokens, ref index, cellValue);
            while (index < tokens.Count)
            {
                string token = tokens[index];
                if (token == "||")
                {
                    index++;
                    value = value || ParseTerm(tokens, ref index, cellValue);
                }
                else
                {
                    break;
                }
            }
            return value;
        }


        // 解析术语
        private bool ParseTerm(List<string> tokens, ref int index, string cellValue)
        {
            bool value = ParseFactor(tokens, ref index, cellValue);
            while (index < tokens.Count)
            {
                string token = tokens[index];
                if (token == "&&")
                {
                    index++;
                    value = value && ParseFactor(tokens, ref index, cellValue);
                }
                else
                {
                    break;
                }
            }
            return value;
        }


        // 解析因子
        private bool ParseFactor(List<string> tokens, ref int index, string cellValue)
        {
            string token = tokens[index];
            if (token == "(")
            {
                index++;
                bool value = ParseExpression(tokens, ref index, cellValue);
                if (tokens[index] != ")")
                {
                    throw new ArgumentException("Mismatched parentheses in filter expression");
                }
                index++;
                return value;
            }
            else
            {
                return EvaluateCondition(tokens, ref index, cellValue);
            }
        }

        // 评估条件
        private bool EvaluateCondition(List<string> tokens, ref int index, string cellValue)
        {
            string left = tokens[index];
            index++;
            string op = tokens[index];
            index++;
            string right = tokens[index].Trim('"');
            index++;

            switch (op)
            {
                case "==":
                    return cellValue == right;
                case "!=":
                    return cellValue != right;
                case "<":
                    return string.Compare(cellValue, right) < 0;
                case "<=":
                    return string.Compare(cellValue, right) <= 0;
                case ">":
                    return string.Compare(cellValue, right) > 0;
                case ">=":
                    return string.Compare(cellValue, right) >= 0;
                case "LIKE":
                    return Like(cellValue, right);
                case "NOT LIKE":
                    return !Like(cellValue, right);
                default:
                    throw new ArgumentException("Unsupported operator in filter expression: " + op);
            }
        }
        private bool Like(string input, string pattern)
        {
            // 转换LIKE模式为正则表达式模式
            string regexPattern = "^" + Regex.Escape(pattern)
                                         .Replace("%", ".*")
                                         .Replace("_", ".") + "$";
            return Regex.IsMatch(input, regexPattern, RegexOptions.IgnoreCase);
        }

        internal static int ConvertColumnNameToNumber(string columnName)
        {
            int columnNumber = 0;
            int multiple = 1;

            for (int i = columnName.Length - 1; i >= 0; i--)
            {
                char letter = columnName[i];
                columnNumber += (letter - 'A' + 1) * multiple;
                multiple *= 26;
            }

            return columnNumber;
        }

        #endregion

        public DataTable LoadDataIntoDataGridView(DataTable dataTable, string[] columnsToCombined)
        {
            DataTable combinedDataTable = new DataTable();
            string combinedColums = string.Empty;
            for (int i = 0; i < columnsToCombined.Length; i++)
            { combinedColums += columnsToCombined[i].ToString() + "-"; }

            combinedDataTable.Columns.Add(combinedColums);
            for (int i = 2; i < dataTable.Columns.Count; i++)
            {
                combinedDataTable.Columns.Add(dataTable.Columns[i].ColumnName);
            }

            foreach (DataRow row in dataTable.Rows)
            {
                DataRow newRow = combinedDataTable.NewRow();
                newRow["Combined Column 1 and 2"] = $"{row[0]?.ToString() ?? string.Empty} {row[1]?.ToString() ?? string.Empty}";
                for (int i = 2; i < dataTable.Columns.Count; i++)
                {
                    newRow[i] = row[i];
                }
                combinedDataTable.Rows.Add(newRow);
            }
            return combinedDataTable;
        }
        public bool SaveFileAs()
        {
            return SaveFileAs(filePath, FileFilter, 1, LibGlobalSource.FILE_SAVE_AS);
        }

    }
}



