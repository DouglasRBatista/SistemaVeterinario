using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.DALCONN
{
    public class DALCONN : IDisposable
    {
        private string connectionString;
        private SqlConnection connection;
        private SqlTransaction transaction;
        private bool disposed = false;

        public DALCONN(string conn) 
        {
            NewConnection(conn);
            OpenConnection();
        }

        private void NewConnection(string conn)
        {
            connection = new SqlConnection(conn);
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

        public SqlDataReader ExecuteReader(string query)
        {
            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    return reader;
                }
            }
            catch (Exception ex)
            {
                return null;
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
                    transaction = null;
                }
            }
            catch (Exception ex)
            {

            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (connection != null)
                    {
                        connection.Dispose();
                    }
                }
                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DALCONN()
        {
            Dispose(false);
        }
    }
}
