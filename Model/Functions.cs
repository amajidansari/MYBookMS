using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace BookMS.Model
{
    public class Functions
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
       
        private SqlDataAdapter sda;
        private string Constr;

        public Functions()

        {
            Constr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\DELL\Documents\BookShopDB.mdf;Integrated Security=True;Connect Timeout=30";

            con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
                  
        }
        public DataTable GetData(string Query)
        {

            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            
            return dt;
                  
        }

        public int SetData(string Query) {
                
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                
            }

            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }

    }
}