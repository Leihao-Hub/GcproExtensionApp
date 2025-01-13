using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
namespace GcproExtensionLibrary
{
    public class OleDb
    {
        private string connectionString;
        private string dataSource;
        private bool isNewOLEDBDriver;
        public static string ParPlaceholder { get; } = "?";
        public string DataSource
        {
            get
            {
                return dataSource;
            }
            set
            {
                dataSource = value;
            }
        }
        public bool IsNewOLEDBDriver
        {
            get
            {
                return isNewOLEDBDriver;
            }
            set
            {
                isNewOLEDBDriver = value;
            }
        }
        public OleDb()
        {
            this.dataSource = string.Empty;
            this.isNewOLEDBDriver = false;
        }
        public OleDb(string dataSource, bool newOledbDriver = false)
        {
            this.dataSource = dataSource;
            this.isNewOLEDBDriver = newOledbDriver;
        }
        #region Query method
        /// <summary>
        /// 多字段读取
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="whereClause"></param>
        /// <param name="parameters"></param>
        /// <param name="sortBy"></param>
        /// <param name="fields"></param>
        /// <returns>DataTable</returns>
        /// <exception cref="ArgumentException"></exception>
        public DataTable QueryDataTable(string tableName, string whereClause, IDictionary<string, object> parameters, string sortBy, params string[] fields)
        {
            if (string.IsNullOrWhiteSpace(tableName) || fields.Length == 0)
            {
                throw new ArgumentException(LibGlobalSource.EMPTY_TABLENAME_OR_FIELDNAME);
            }
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                              $"Data Source={dataSource}";

            string fieldList = string.Join(", ", fields);
            string query = string.Format(
                "SELECT {0} FROM [{1}] {2} {3};",
                fieldList,
                tableName,
                string.IsNullOrWhiteSpace(whereClause) ? string.Empty : string.Format("WHERE {0}", whereClause),
                string.IsNullOrWhiteSpace(sortBy) ? string.Empty : string.Format("ORDER BY {0}", sortBy)
                );

            DataTable results = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters.Values)
                        {
                            command.Parameters.AddWithValue("?", param ?? DBNull.Value);
                        }
                    }
                    try
                    {
                        connection.Open();
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(results);
                        }
                    }
                    catch (Exception ex)
                    {                      
                        throw new ArgumentException(ex.Message);               
                    }
                }
            }
            return results;
        }
        /// <summary>
        /// 多字段读取,嵌套查询
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="whereClause"></param>
        /// <param name="parameters"></param>
        /// <param name="sortBy"></param>
        /// <param name="subQuery"></param>
        /// <param name="fields"></param>
        /// <returns>DataTable</returns>
        /// <exception cref="ArgumentException"></exception>
        public DataTable NestQueryDataTable(string tableName, string whereClause, IDictionary<string, object> parameters, string sortBy, string subQuery = null, params string[] fields)
        {
            if (string.IsNullOrWhiteSpace(tableName) || fields.Length == 0)
            {
                throw new ArgumentException(LibGlobalSource.EMPTY_TABLENAME_OR_FIELDNAME);
            }

            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                         $"Data Source={dataSource}";

            if (!string.IsNullOrWhiteSpace(subQuery))
            {
                whereClause = $"{whereClause} ({subQuery})";
            }

            string fieldList = string.Join(", ", fields);
            //string query = $"SELECT {fieldList} " +
            //               $"FROM {tableName} " +
            //               $"{(string.IsNullOrWhiteSpace(whereClause) ? string.Empty : $"WHERE {whereClause}")} " +
            //               $"{(string.IsNullOrWhiteSpace(sortBy) ? string.Empty : $"ORDER BY {sortBy}")};";
            string query = string.Format(
                "SELECT {0} FROM [{1}] {2} {3};",
                fieldList,
                tableName,
                string.IsNullOrWhiteSpace(whereClause) ? string.Empty : string.Format("WHERE {0}", whereClause),
                string.IsNullOrWhiteSpace(sortBy) ? string.Empty : string.Format("ORDER BY {0}", sortBy)
            );
            DataTable results = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters.Values)
                        {
                            command.Parameters.AddWithValue("?", param ?? DBNull.Value);
                        }
                    }

                    try
                    {
                        connection.Open();

                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                        {
                            adapter.Fill(results);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new ArgumentException("Error executing query: " + ex.Message);
                    }
                }
            }

            return results;
        }
        /// <summary>
        /// 获取DATA TABLE中某一列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static List<T> GetColumnData<T>(DataTable dataTable, string columnName)
        {
            var columnData = dataTable.AsEnumerable()
                                      .Select(row => row[columnName] != DBNull.Value ? (T)Convert.ChangeType(row[columnName], typeof(T)) : default(T))
                                      .ToList();
            return columnData;
        }
        /// <summary>
        /// 获取DATA TABLE中多列的数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <param name="columnNames"></param>
        /// <returns></returns>
        public static List<Dictionary<string, T>> GetColumnsData<T>(DataTable dataTable, params string[] columnNames)
        {
            var columnsData = dataTable.AsEnumerable()
                                       .Select(row => columnNames.ToDictionary(
                                           columnName => columnName,
                                           columnName => row[columnName] != DBNull.Value ? (T)Convert.ChangeType(row[columnName], typeof(T)) : default(T)))
                                       .ToList();

            return columnsData;
        }
        /// <summary>
        ///在集合中根据筛选出的数据,根据[comparedColumn]列中类容是否以[startsWith]开头
        ///满足调节，则返回[expectedcolumn]的值。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">数据库筛选出的存于该集合中的数据</param>
        /// <param name="comparedColumn">用与筛选比较的列名称</param>
        /// <param name="expectedcolumn">满足筛选列的集合中期望列名称</param>
        /// <param name="startsWith">筛选列的开头部分</param>
        /// <returns></returns>
        public static string GetValueBaseOtherColumn<T>(List<Dictionary<string, T>> data, string comparedColumn, string expectedcolumn, string startsWith)
        {
            var result = string.Empty;

            foreach (var row in data)
            {
                if (row.ContainsKey(comparedColumn) && row[comparedColumn] != null &&
                    row[comparedColumn].ToString().StartsWith(startsWith))
                {
                    if (row.ContainsKey(expectedcolumn) && row[expectedcolumn] != null)
                    {
                        result = row[expectedcolumn].ToString();
                    }
                }
            }

            return result;
        }
        /// <summary>
        ///在数据表中根据筛选出的数据,根据[comparedColumn]列中类容是否以[startsWith]开头
        ///满足调节，则返回[expectedcolumn]的值。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">数据库筛选出的存于该集合中的数据</param>
        /// <param name="comparedColumn">用与筛选比较的列名称</param>
        /// <param name="expectedcolumn">满足筛选列的集合中期望列名称</param>
        /// <param name="startsWith">筛选列的开头部分</param>
        /// <returns></returns>
        public static string GetValueBaseOtherColumn(DataTable dataTable, string comparedColumn, string expectedColumn, string startsWith)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if (row[comparedColumn] != DBNull.Value && row[comparedColumn].ToString().StartsWith(startsWith))
                {
                    if (row[expectedColumn] != DBNull.Value)
                    {
                        return row[expectedColumn].ToString();
                    }
                }
            }

            return string.Empty;
        }
        #endregion
        #region Insert method
        public bool InsertRecord(string tableName, List<Gcpro.DbParameter> parameters)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentException(LibGlobalSource.EMPTY_TABLENAME_OR_FIELDNAME);
            }
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                              $"Data Source={dataSource}";

            string columnNames = string.Join(", ", parameters.Select(p => $"[{p.Name}]"));
            string valueParameters = string.Join(", ", parameters.Select(p => "?"));

            //string insertQuery = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({ valueParameters})";

            string insertQuery = string.Format("INSERT INTO[{0}] ({1}) VALUES ({2})", tableName, columnNames, valueParameters);


            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (OleDbCommand command = new OleDbCommand(insertQuery, connection, transaction))
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                            }
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch
                        {
                            throw;
                        }
                        return false;
                    }
                }
            }
        }
        public bool InsertRecords(string tableName, List<List<Gcpro.DbParameter>> parametersList)
        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                           $"Data Source={dataSource}";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var parameters in parametersList)
                        {
                            string columnNames = string.Join(", ", parameters.Select(p => $"[{p.Name}]"));
                            string valueParameters = string.Join(", ", parameters.Select(p => "?"));
                            string insertQuery = string.Format("INSERT INTO[{0}] ({1}) VALUES ({2})", tableName, columnNames, valueParameters);
                            using (OleDbCommand command = new OleDbCommand(insertQuery, connection, transaction))
                            {
                                foreach (var param in parameters)
                                {
                                    command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                                }
                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            Console.WriteLine(ex.Message);
                            transaction.Rollback();
                        }
                        catch
                        {
                            throw;
                        }

                        return false;
                    }
                }
            }
        }
        #endregion
        #region Delete method
        public bool DeleteRecord(string tableName, string whereClause, List<Gcpro.DbParameter> whereParameters)
        {
            string deleteQuery = $"DELETE FROM {tableName} WHERE {whereClause}";
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                           $"Data Source={dataSource}";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    using (OleDbCommand command = new OleDbCommand(deleteQuery, connection))
                    {
                        if (whereParameters != null)
                        {
                            foreach (var param in whereParameters)
                            {
                                command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                            }
                        }
                        connection.Open();
                        int result = command.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        public bool DeleteRecords(string tableName, List<string> whereClauses)
        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                    $"Data Source={dataSource}";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbTransaction transaction = connection.BeginTransaction())
                {
                    OleDbCommand command = connection.CreateCommand();
                    command.Transaction = transaction;

                    try
                    {
                        foreach (string whereClause in whereClauses)
                        {
                            string deleteQuery = $"DELETE FROM [{tableName}] WHERE {whereClause}";
                            command.CommandText = deleteQuery;
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception rollbackEx)
                        {
                            Console.WriteLine(rollbackEx.Message);
                        }
                        return false;
                    }
                }
            }
        }
        #endregion
        #region Update method
        /// <summary>
        /// 根据条件执行一次性执行一次更新满足条件的多个字段值
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parameters"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public bool UpdateRecord(string tableName, List<Gcpro.DbParameter> setList, string whereClause)

        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                        $"Data Source={dataSource}";
            var setClauseParts = new List<string>();
            foreach (var param in setList)
            {
                setClauseParts.Add($"[{param.Name}] = ?");
            }
            var setClause = string.Join(", ", setClauseParts);
            //string updateQuery =
            //    $"UPDATE [{tableName}] " +
            //    $"SET {setClause} " +
            //    $"WHERE {whereClause}";
            string updateQuery = string.Format("UPDATE [{0}] SET {1} WHERE {2}",
                tableName,
                setClause,
                whereClause
                );
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(updateQuery, connection);
                    foreach (Gcpro.DbParameter param in setList)
                    {
                        command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                    }
                    int affectedRows = command.ExecuteNonQuery();
                    return affectedRows > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
        /// <summary>
        /// 带嵌套查询的更新字段
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="parameters"></param>
        /// <param name="whereClause"></param>
        /// <param name="subTableName"></param>
        /// <param name="subTableCondition"></param>
        /// <returns></returns>
        public bool UpdateRecordWithSubQuery(string tableName, List<Gcpro.DbParameter> setList, string whereClause, IDictionary<string, object> parameters ,string subQuery = null)
        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) + $"Data Source={dataSource}";

            var setClauseParts = new List<string>();
            foreach (var setClause in setList)
            {
                setClauseParts.Add($"[{setClause.Name}] = ?");
            }
            string setClauses = string.Join(", ", setClauseParts);
            //string updateQuery = $@"UPDATE [{tableName}] AS MainTable SET {setClause} WHERE {whereClause} " +
            //                     $"{(string.IsNullOrWhiteSpace(subQuery) ? "" : $"AND EXISTS ({subQuery})")}";     
            string updateQuery = string.Format(
                  "UPDATE [{0}] AS MainTable SET {1} WHERE {2} {3}",
                  tableName,
                  setClauses,
                  whereClause,
                  string.IsNullOrWhiteSpace(subQuery) ? "" : $"AND EXISTS ({subQuery})"
              );
            Console.WriteLine("Executing SQL: " + updateQuery);
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(updateQuery, connection)) 
                    {
                        foreach (Gcpro.DbParameter param in setList)
                        {
                            command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                        }

                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                            }
                        }
                        foreach (OleDbParameter parameter in command.Parameters)
                        {
                            Console.WriteLine($"Parameter: {parameter.Value}");
                        }
                        int affectedRows = command.ExecuteNonQuery();
                        return affectedRows > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }
        /// <summary>
        /// 根据条件执行,一次性执行多个更新满足条件的多个字段值
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="listOfParameterList"></param>
        /// <param name="whereClause"></param>
        /// <returns></returns>
        public bool UpdateMultipleRecords(string tableName, List<List<Gcpro.DbParameter>> listOfParameterList, string whereClause)
        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                      $"Data Source={dataSource}";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        foreach (var parameters in listOfParameterList)
                        {
                            var setClauseParts = new List<string>();
                            foreach (var param in parameters)
                            {
                                setClauseParts.Add($"[{param.Name}] = ?");
                            }
                            var setClause = string.Join(", ", setClauseParts);

                            //string updateQuery = $"UPDATE [{tableName}] " +
                            //    $"SET {setClause}" +
                            //    $" WHERE {whereClause}";
                            string updateQuery = string.Format(
                                "UPDATE [{0}] SET {1} WHERE {2}",
                                tableName,
                                setClause,
                                whereClause
                            );

                            using (OleDbCommand command = new OleDbCommand(updateQuery, connection, transaction))
                            {
                                foreach (var param in parameters)
                                {
                                    command.Parameters.AddWithValue("?", param.Value ?? DBNull.Value);
                                }

                                command.ExecuteNonQuery();
                            }
                        }
                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
        }
        #endregion
    }
}
