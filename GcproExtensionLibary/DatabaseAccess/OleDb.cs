using GcproExtensionLibary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Runtime.CompilerServices;
using static GcproExtensionLibrary.Gcpro.GcproTable;
namespace GcproExtensionLibrary
{
    public class OleDb
    {
        private string connectionString;
        private string dataSource;
        private bool isNewOLEDBDriver;

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
        public DataTable QueryDataTable(string tableName, string whereClause, IDictionary<string, object> parameters, string sortBy, params string[] fields)
        {              
            if (string.IsNullOrWhiteSpace(tableName) || fields.Length == 0)
            {
                throw new ArgumentException(LibGlobalSource.EMPTY_TABLENAME_OR_FIELDNAME);
            }
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                              $"Data Source={dataSource}";

            string fieldList = string.Join(", ", fields);
            string query = $"SELECT {fieldList}  " +
                           $"FROM [{tableName}]  " +
                           $"{(string.IsNullOrWhiteSpace(whereClause) ? string.Empty : $"WHERE {whereClause}")} " +
                           $"{(string.IsNullOrWhiteSpace(sortBy) ? string.Empty : $"ORDER BY {sortBy}")}; ";

            DataTable results = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
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
                whereClause= $"{whereClause} ({subQuery})";
            }
        
            string fieldList = string.Join(", ", fields);
            string query = $"SELECT {fieldList} " +
                           $"FROM {tableName} " +
                           $"{(string.IsNullOrWhiteSpace(whereClause) ? string.Empty : $"WHERE {whereClause}")} " +
                           $"{(string.IsNullOrWhiteSpace(sortBy) ? string.Empty : $"ORDER BY {sortBy}")};";

            DataTable results = new DataTable();

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
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
        public static List<T> GetColumnData<T>(DataTable dataTable, string columnName)
        {
            var columnData = dataTable.AsEnumerable()
                                      .Select(row => row[columnName] != DBNull.Value ? (T)Convert.ChangeType(row[columnName], typeof(T)) : default(T))
                                      .ToList();
            return columnData;
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

            string insertQuery = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({valueParameters})";

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
                    catch (Exception ex)
                    {
                        try
                        {
                            transaction.Rollback(); // 如有错误则回滚事务
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
        public bool InsertMultipleRecords(string tableName, List<List<Gcpro.DbParameter>> parametersList)
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
                            string insertQuery = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({valueParameters})";

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
            public bool UpdateRecord(string tableName, List<Gcpro.DbParameter> parameters, string whereClause)
        {
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                        $"Data Source={dataSource}";
            var setClauseParts = new List<string>();
            foreach (var param in parameters)
            {
                setClauseParts.Add($"[{param.Name}] = ?");  
            }
            var setClause = string.Join(", ", setClauseParts);
            string updateQuery = $"UPDATE [{tableName}] SET {setClause} WHERE {whereClause}";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(updateQuery, connection);
                    foreach (Gcpro.DbParameter param in parameters)
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

                            string updateQuery = $"UPDATE [{tableName}] SET {setClause} WHERE {whereClause}";

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
