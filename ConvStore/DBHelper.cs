using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ConvStore
{
    public class DBHelper : IDisposable
    {
        private readonly SqlConnection connection;
        private bool disposed = false;
        public SqlConnection Connection 
        {
            get { return connection; }
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ConvStoreDB"].ConnectionString;
        }

        public DBHelper()
        {
            connection = new SqlConnection(GetConnectionString());
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void TestConnection()
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                Console.WriteLine("Connected successfully!");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    connection?.Dispose();
                }
                disposed = true;
            }
        }

        ~DBHelper()
        {
            Dispose(false);
        }
    }
}
