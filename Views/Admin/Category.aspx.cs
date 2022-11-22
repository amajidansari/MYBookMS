using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookMS.Views.Admin
{
    public partial class Category : System.Web.UI.Page
    {
        Model.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.Functions();

            showcategories();
        }


        private void showcategories()
        {

            string Query = "select * from Category";
            
            catlistgv.DataSource = con.GetData(Query);
            catlistgv.DataBind();

        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (catnametb.Value == "" || catdesctb.Value == "")
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string catname = catnametb.Value;
                    string catdesc = catdesctb.Value;

                    string Query = "insert into Category values('{0}','{1}')";
                    Query = string.Format(Query,catdesc, catname);
                    con.SetData(Query);
                    showcategories();
                    errormsg.Text = "Categories Inserted!!!";
                    showcategories();
                    catnametb.Value = "";
                    catdesctb.Value = "";
                    
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }

        int key = 0;
        protected void catlistgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            catnametb.Value = catlistgv.SelectedRow.Cells[2].Text;
            catdesctb.Value = catlistgv.SelectedRow.Cells[1].Text;


            if (catnametb.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(catlistgv.SelectedRow.Cells[1].Text);
            }
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catnametb.Value == "" || catdesctb.Value == "")
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string catname = catnametb.Value;
                    string desc = catdesctb.Value;

                    string Query = "update Category set catdescription = '{0}',catname= '{1}' where catId = {2}";
                    Query = string.Format(Query, desc, catname, catlistgv.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showcategories();
                    errormsg.Text = "Category Updated!!!";
                    catnametb.Value = "";
                    catdesctb.Value = "";
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }

        protected void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (catnametb.Value == "" || catdesctb.Value == "")
                {
                    errormsg.Text = "select category data details!!!";
                }
                else
                {
                    string catname = catnametb.Value;
                    string desc = catdesctb.Value;
                    string Query = "delete from Category where catId = {0}";
                    Query = string.Format(Query, catlistgv.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showcategories();
                    errormsg.Text = "category Deleted!!!";
                    catnametb.Value = "";
                    catdesctb.Value = "";
 
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }
    }
}