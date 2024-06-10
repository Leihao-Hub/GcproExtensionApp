using GcproExtensionLibary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
namespace GcproExtensionLibrary
{
    public class OleDb
    {

        private string dataSource;
        private string connectionString;
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
                    // Add parameters to the command if provided
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
        public static List<T> GetColumnData<T>(DataTable dataTable, string columnName)
        {
            var columnData = dataTable.AsEnumerable()
                                      .Select(row => row[columnName] != DBNull.Value ? (T)Convert.ChangeType(row[columnName], typeof(T)) : default(T))
                                      .ToList();
            return columnData;
        }

        public bool InsertRecord(string tableName, List<Gcpro.DbParameter> parameters)
        {
            if (string.IsNullOrWhiteSpace(tableName))
            {
                throw new ArgumentException(LibGlobalSource.EMPTY_TABLENAME_OR_FIELDNAME);
            }
            connectionString = (isNewOLEDBDriver ? LibGlobalSource.OLEDB_PROVIDER_ACCDB : LibGlobalSource.OLEDB_PROVIDER_MDB) +
                              $"Data Source={dataSource}";

            string columnNames = string.Join(", ", parameters.Select(p => p.Name));
            string paramsList = string.Join(", ", parameters.Select(p => "?"));

            string insertQuery = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({paramsList})";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(insertQuery, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Name, param.Value ?? DBNull.Value);
                    }

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    return result > 0;
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
                OleDbTransaction transaction = connection.BeginTransaction();

                foreach (var parameters in parametersList)
                {
                    string columnNames = string.Join(", ", parameters.Select(p => p.Name));
                    string valueParameters = string.Join(", ", parameters.Select(p => "?"));
                    string insertQuery = $"INSERT INTO [{tableName}] ({columnNames}) VALUES ({valueParameters})";

                    using (OleDbCommand command = new OleDbCommand(insertQuery, connection, transaction))
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue("?", param.Value); // Access使用?作为参数占位符
                        }
                        command.ExecuteNonQuery();
                    }
                }

                try
                {
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
                    }

                    return false;
                }
            }
        }
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
                    // Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
