using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DbContext
    {
        public static SqlConnection connection { get; set; } = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True");
        public static DataTable Select(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
        public static int ExecuteNonQuery(string command)
        {
            SqlCommand cmd = new SqlCommand(command, connection);
            connection.Open();
            int result = cmd.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
