using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace QLDaoTao
{
    static class DB
    {
        private static String dataSource = "QuanLyDaoTao.mdb";
        private static OleDbConnection conn = null;

        public static void Connect()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataSource + "";
        }

        public static void ExecuteNonQuery(String sql) 
        {
            if (conn == null) 
            {
                Connect();
            }
            conn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable ExecuteQuery(String sql)
        {
            DataTable data = new DataTable();

            if (conn == null)
            {
                Connect();
            }
            conn.Open();
            OleDbDataAdapter dapt = new OleDbDataAdapter(sql, conn);
            dapt.Fill(data);
            conn.Close();

            return data;
        }
    }
}
