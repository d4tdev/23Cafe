
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } private set { DataProvider.instance = value; } }


        private Variable var;
        private String connectionStr;
        private DataProvider() {
            var = new Variable();
            connectionStr = var.ConnectionString;
        }

        // Return ResultSet
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        // Return integer value
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = null;
            using (SqlConnection conn = new SqlConnection(connectionStr))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                conn.Close();
            }
            return data;
        }
    }
}
