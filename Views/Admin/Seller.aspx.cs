using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookMS.Views.Admin
{
    public partial class Seller : System.Web.UI.Page
    {
        Model.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.Functions();

            showseller();

        }

        private void showseller()
        {

            string Query = "select sellid,sellname,sellemail,sellphone from seller";


            sellergv.DataSource = con.GetData(Query);
            sellergv.DataBind();

        }

        int key = 0;
        protected void sellergv_SelectedIndexChanged(object sender, EventArgs e)
        {
            sellername.Value = sellergv.SelectedRow.Cells[2].Text;
            emailid.Value = sellergv.SelectedRow.Cells[3].Text;
             sellerphone.Value = sellergv.SelectedRow.Cells[4].Text;
           
            

            if (sellername.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(sellergv.SelectedRow.Cells[1].Text);
            }
         
        }

        protected void deletbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellername.Value == "" || emailid.Value == "" || sellerphone.Value == "")
                { 
                    errormsg.Text = "select category data details!!!";
                }
                else
                {
                    string Query = "delete from seller where sellId = {0}";
                    Query = string.Format(Query, sellergv.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showseller();
                    errormsg.Text = "seller Deleted!!!";
                    sellername.Value = "";
                    emailid.Value = "";
                    sellerphone.Value = "";
                    password.Value = "";
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }

        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sellername.Value == "" || emailid.Value == "" || sellerphone.Value == "" || password.Value == "")
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string selname = sellername.Value;
                    string selemail = emailid.Value;
                    string selphone = sellerphone.Value;
                    string password1 = password.Value;

                    string Query = "update seller set sellname = '{0}', sellemail= '{1}', sellphone= '{2}', password= '{3}' where sellid = {4}";
                    Query = string.Format(Query, selname, selemail, selphone, password1, sellergv.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showseller();
                    errormsg.Text = "seller updated Updated!!!";
                    sellername.Value = "";
                    emailid.Value = "";
                    sellerphone.Value = "";
                    password.Value = "";
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
             //   sellername,selleraddress,emailid,sellerphone

                if (sellername.Value == "" || emailid.Value == "" || sellerphone.Value == "" || password.Value == "")
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string selname = sellername.Value;
                    string selemail = emailid.Value;
                    string selphone = sellerphone.Value;
                    string password1 = password.Value;

                    string Query = "insert into seller (sellname,sellemail,sellphone,password) values('{0}','{1}','{2}','{3}')";
                    Query = string.Format(Query, selname, selemail, selphone, password1);
                    con.SetData(Query);
                    showseller();
                    errormsg.Text = "seller Inserted!!!";
                    sellername.Value = "";
                    emailid.Value = "";
                    sellerphone.Value = "";
                    password.Value = "";
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }
    }
}