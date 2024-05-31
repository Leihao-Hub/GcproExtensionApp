using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GcproExtensionLibrary;
using GcproExtensionLibrary.FileHandle;
using OfficeOpenXml;
namespace GcproExtensionLibary.FileHandle
{
    public class ExcelFileHandle
    {
        public static string FileFilter = @"Excel File   (*.xlsx)|*.xlsx|Excel File   (*.xls)|CSV File   (*.CSV)|*.CSV|*.xls|All Files (*.*)|*.*";
        private static string fileType = "Excel 文件";
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
        public ExcelFileHandle(string filePath)
        {
            this.filePath = filePath;
        }
        public static string BrowseFile()
        {
            return BaseFileHandle.Browse(FileFilter, 1, false, true, "请选择一个" + fileType);
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

        public List<string> GetWorkSheets(string filePath = null)
        {
            string _filePath = (string.IsNullOrEmpty(filePath)) ? this.filePath : filePath;
            FileInfo fileInfo = new FileInfo(_filePath);
            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                var worksheets = package.Workbook.Worksheets;
                List<string> listWorkSheetNames = new List<string>();
                foreach (var worksheet in worksheets)
                {

                    listWorkSheetNames.Add(worksheet.Name);
                }
                return listWorkSheetNames;
            }
        }
        public List<List<object>> ReadFileAsList(int startRow, string[] columnsToRead,string filterTypeValue, string filterTypeColumnLetter, string filePath = null, string workSheetName = null)
        {
            string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
            string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;

            FileInfo fileInfo = new FileInfo(effectiveFilePath);
            List<List<object>> allData = new List<List<object>>();
            if (columnsToRead == null || columnsToRead.Length == 0)
                { throw new ArgumentException(LibGlobalSource.EX_SPECIFIED_COLUMN, nameof(columnsToRead)); }           
            try
            {
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null)
                    { throw new ArgumentException(LibGlobalSource.EX_FILE_NOT_FOUND + $"'{effectiveWorksheetName}'", nameof(workSheetName)); }
                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int filterColumnIndex = ConvertColumnNameToNumber(filterTypeColumnLetter);

                    for (int row = startRow; row <= rowCount; row++)
                    {
                        object filterCell = worksheet.Cells[row, filterColumnIndex].Value;
                        if (filterCell == null || filterCell.ToString() != filterTypeValue)
                        {
                            continue; 
                        }
                        List<object> rowData = new List<object>(columnsToRead.Length);
                        foreach (string columnLetter in columnsToRead)
                        {
                            int colIndex = ConvertColumnNameToNumber(columnLetter);
                            rowData.Add(worksheet.Cells[row, colIndex].Value);
                        }
                        allData.Add(rowData);                  
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(LibGlobalSource.EX_READING_FILE+ $"： {ex.Message}");
            }
            return allData;          
        }
        public DataTable ReadFileAsDataTable(int startRow, string[] columnsToRead, string filterTypeValue, string filterTypeColumnLetter, string filePath = null, string workSheetName = null)
        {
            string effectiveWorksheetName = string.IsNullOrEmpty(workSheetName) ? this.workSheet : workSheetName;
            string effectiveFilePath = string.IsNullOrEmpty(filePath) ? this.filePath : filePath;

            FileInfo fileInfo = new FileInfo(effectiveFilePath);
            DataTable dataTable = new DataTable();
            try
            {
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[effectiveWorksheetName];
                    if (worksheet == null)
                    {
                        throw new ArgumentException(LibGlobalSource.EX_FILE_NOT_FOUND + $"'{effectiveWorksheetName}'", nameof(workSheetName));
                    }
                    int rowCount = worksheet.Dimension?.Rows ?? 0;
                    int filterColumnIndex = ConvertColumnNameToNumber(filterTypeColumnLetter);

                    // 设置DataTable的列
                    for (int i = 0; i < columnsToRead.Length; i++)
                    {
                        dataTable.Columns.Add($"Column {i + 1}");
                    }

                    for (int row = startRow; row <= rowCount; row++)
                    {
                        object filterCell = worksheet.Cells[row, filterColumnIndex].Value;
                        if (filterCell == null || filterCell.ToString() != filterTypeValue)
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
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException(LibGlobalSource.EX_READING_FILE + $"： {ex.Message}");
            }
            return dataTable;
        }
        public DataTable LoadDataIntoDataGridView(DataTable dataTable, string[] columnsToCombined)
        {               
            DataTable combinedDataTable = new DataTable();
            string combinedColums=string.Empty;
            for (int i = 0; i < columnsToCombined.Length; i++)
            { combinedColums += columnsToCombined[i].ToString()+"-"; }  
    
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
            return BaseFileHandle.SaveFileAs(filePath, FileFilter, 1, LibGlobalSource.FILE_SAVE_AS);
        }

    }
}



