﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Dictionary
{
        public class Dictionary
    {
        SqlConnection conn = new SqlConnection();
        public Dictionary(string connstr) 
        { 
            conn.ConnectionString = connstr;
        }

        public DataTable returnrec(string strsearch)
        {
            string sqltext = "select * from words where englishword like '" + strsearch + "%'";
            DataTable t1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = sqltext;
            c1.Connection = conn;
            da.SelectCommand = c1;
            da.Fill(t1);
            return t1;

        }

        public void editrec(string newversion,string englishword)
        {
            SqlCommand c1 = new SqlCommand();
            c1.CommandText = "update words set farsiword=@p1 where englishword=@p2";
            c1.Parameters.AddWithValue("p1", newversion);
            c1.Parameters.AddWithValue("p2", englishword);
            c1.Connection = conn;
            conn.Open();
            c1.ExecuteNonQuery();
            conn.Close();
        }

    }
}
