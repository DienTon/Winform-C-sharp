using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonThatDien_27211234266
{
    class SqlServerConnection
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Administrator\\source\\repos\\TonThatDien_27211234266\\TonThatDien_27211234266\\QLCAFE.mdf;Integrated Security=True";
        private SqlConnection connection;
        public SqlServerConnection()
        {
            connection = new SqlConnection(connectionString);
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
        public int ExecuteNonQuery(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                int result = command.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
        public DataTable ExecuteQuery(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }
        public int ExecuteScalar(string query)
        {
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                object result = command.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
