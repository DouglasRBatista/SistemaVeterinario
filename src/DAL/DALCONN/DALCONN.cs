using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DALCONN
{
    public class DALCONN
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public DALCONN() 
        {
            
        }

        //public DatabaseConnection(string server, string database, string username, string password)
        //{
        //    connectionString = GetConnectionString(server, database, username, password);
        //    connection = new SqlConnection(connectionString);
        //}

        private string GetConnectionString(string server, string database, string username, string password)
        {
            return $"Server={server};Database={database};User Id={username};Password={password};";
        }

        public void OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
            }
        }

        public DataTable ExecuteQuery(string query)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable resultTable = new DataTable();
                        adapter.Fill(resultTable);
                        return resultTable;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public int ExecuteNonQuery(string query)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    if (transaction != null)
                    {
                        command.Transaction = transaction;
                    }
                    return command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public void BeginTransaction()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    transaction = connection.BeginTransaction();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error starting transaction: " + ex.Message);
            }
        }

        public void CommitTransaction()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Commit();
                    transaction = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void RollbackTransaction()
        {
            try
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                    Console.WriteLine("Transaction rolled back successfully.");
                    transaction = null;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
