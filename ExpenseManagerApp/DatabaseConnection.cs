using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
    
namespace ExpenseManagerApp
{
    /// <summary>
    /// Handles all SQL Server connections and query executions.
    /// </summary>
    public class DatabaseConnection
    {
        // Connection string pointing to Server: NGUYENDUCJUY as requested
        private readonly string connectionString = @"Server=NGUYENDUCJUY;Database=ExpenseManagerDB;Trusted_Connection=True;";

        /// <summary>
        /// Gets an open SQL connection.
        /// </summary>
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /// <summary>
        /// Executes an INSERT, UPDATE, or DELETE query and returns rows affected.
        /// </summary>
        public int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null) return 0;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error executing query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        /// <summary>
        /// Executes a SELECT query and returns a DataTable for DataGridViews.
        /// </summary>
        public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    if (conn == null) return dataTable;

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
