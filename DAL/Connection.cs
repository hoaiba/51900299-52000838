using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Connection
    {
        private static SqlConnection conn;
        public static void connect()
        {
            string s = "Initial Catalog = QuanLyBaoVangBuGV_TDTU_IT; Data Source = MSI\\QUANGHUY; integrated Security = true";
            conn = new SqlConnection(s);
            conn.Open();
        }

        public static void actionQuery(string sql)
        {
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public static DataTable selectQuery(string sql)
        {
            connect();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            return dt;
        }

        // Lấy dữ liệu cột 
        public static string selectData(string sql, string col)
        {
            string data = "";
            connect();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    data = dr[col].ToString();
                }
            }
            return data;
        }
    }
}
