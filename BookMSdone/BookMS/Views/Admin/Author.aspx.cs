using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookMS.Views.Admin
{
    public partial class Author : System.Web.UI.Page

        
    {
        Model.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Model.Functions();
            showauthor();
        }

        private void showauthor() {

            string Query = "select * from AuthorTBL";
            AuthorlistGV.DataSource = Con.GetData(Query);
            AuthorlistGV.DataBind();
                
        }

        protected void savebtn_Click(object sender, EventArgs e)
        
        {
            try
            {
                if (anametb.Value== "" || gendd.SelectedIndex == -1 || countrycb.SelectedIndex == -1)
                {
                    errormsg.Text = "missing details!!!";
                }
                else
	                {       
                            string gender = gendd.SelectedItem.ToString();
                                string country = countrycb.SelectedItem.ToString();
                                string aname = anametb.Value;
                            string Query =  "insert into AuthorTBL values('{0}','{1}','{2}')";
                            Query = string.Format(Query, gender, country, aname);
                            Con.SetData(Query);
                                showauthor();
                                errormsg.Text ="Author Inserted!!!";

                                anametb.Value = "";
                                gendd.SelectedIndex = -1;
                                countrycb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

                 }
        }
        int key = 0;

        protected void AuthorlistGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            anametb.Value = AuthorlistGV.SelectedRow.Cells[4].Text;
            gendd.SelectedItem.Value = AuthorlistGV.SelectedRow.Cells[2].Text;
            //.Value = AuthorlistGV.SelectedRow.Cells[2].ToString();
            countrycb.SelectedItem.Value = AuthorlistGV.SelectedRow.Cells[3].Text;
            if (anametb.Value == "")
            {
                key = 0;
                
            }
            else
            {
                key = Convert.ToInt32(AuthorlistGV.SelectedRow.Cells[1].Text);
            }
        
        }

        protected void edtbtn_Click1(object sender, EventArgs e)
        {
            try
            {
                if (anametb.Value == "" || gendd.SelectedIndex == -1 || countrycb.SelectedIndex == -1)
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string gender = gendd.SelectedItem.ToString();
                    string country = countrycb.SelectedItem.ToString();
                    string aname = anametb.Value;
                    string Query = "update AuthorTBL set AutGender = '{0}',AutCountry = '{1}', AutName = '{2}' where AuthID = {3}";
                    Query = string.Format(Query, gender, country, aname, AuthorlistGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    showauthor();
                    errormsg.Text = "Author Updated!!!";
                    anametb.Value = "";
                    gendd.SelectedIndex = -1;
                    countrycb.SelectedIndex = -1;

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
                if (anametb.Value == "" || gendd.SelectedIndex == -1 || countrycb.SelectedIndex == -1)
                {
                    errormsg.Text = "select author data details!!!";
                }
                else
                {
                    string gender = gendd.SelectedItem.ToString();
                    string country = countrycb.SelectedItem.ToString();
                    string aname = anametb.Value;
                    string Query = "delete from AuthorTBL where AuthID = {0}";
                    Query = string.Format(Query, AuthorlistGV.SelectedRow.Cells[1].Text);
                    Con.SetData(Query);
                    showauthor();
                    errormsg.Text = "Author Deleted!!!";
                    anametb.Value = ""; 
                    gendd.SelectedIndex = -1 ;
                    countrycb.SelectedIndex = -1;

                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }

        
         
        
    }
}