using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Web.SessionState;


namespace BookMS.Views.Admin
{
  

    public partial class Login : System.Web.UI.Page
    {      
              Model.Functions con;
           //Session ["UserName"]= Login.User
      // string sName = Login.UName; 
        
        
 

             
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.Functions();


         
     

        }


//public static string UName = "";

//public static int user;
        
        protected void loginbtn_Click(object sender, EventArgs e)
        {

         

            if (Userid.Value =="" ||  password.Value =="")
            {
                errormsg.Text = "Missing data";
            }
            else if (Userid.Value == "Admin@gmail.com" && password.Value == "password")
            {
                Response.Redirect("Books.aspx");

            }

            else
            {
                string Query = "Select * from seller where sellemail   = '{0}' and password = '{1}'";
                Query = string.Format(Query, Userid.Value, password.Value);
                DataTable dt = con.GetData(Query);
                if (dt.Rows.Count==0)
                {
                    Response.Redirect("Books.aspx");   
                }
                else
                {
                  Session  ["UName"] = Userid.Value;
                    Session ["user"] = Convert.ToInt32(dt.Rows[0][0].ToString());

                    Response.Redirect("Seller/selling.aspx");
                }
            
            }

        }
    }
}