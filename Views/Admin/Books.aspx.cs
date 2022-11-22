using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookMS.Views.Admin
{
    public partial class Books : System.Web.UI.Page
    {


        Model.Functions con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new Model.Functions();
            if (!IsPostBack)
            {
                showbook();

                GetAuthor();
                getcategories();
    
            }
            
        }

        private void showbook()
        {

            string Query = "select * from BookTB";

            bookgv.DataSource = con.GetData(Query);
            bookgv.DataBind();

        }

        private void getcategories()
        {

            string Query = "select * from Category";

            ddboocat.DataTextField = con.GetData(Query).Columns["catname"].ToString();

            ddboocat.DataValueField = con.GetData(Query).Columns["catid"].ToString();

            ddboocat.DataSource = con.GetData(Query);

            ddboocat.DataBind();

        }
        private void GetAuthor()
        {

            string Query = "select * from AuthorTBL";


            DDBOOKAUthor.DataTextField = con.GetData(Query).Columns["AutName"].ToString();

            DDBOOKAUthor.DataValueField = con.GetData(Query).Columns["AuthID"].ToString();

            DDBOOKAUthor.DataSource = con.GetData(Query);

            DDBOOKAUthor.DataBind();

        }




        protected void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Booktitle.Value == "" || DDBOOKAUthor.SelectedIndex == -1 || ddboocat.SelectedIndex == -1 || price.Value == "" || qunatity.Value == ""  )
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string booktit = Booktitle.Value;
                    string ddbookauthor = DDBOOKAUthor.SelectedValue.ToString();
                    string ddbookcat = ddboocat.SelectedValue.ToString();

                    int pricee = Convert.ToInt32(price.Value);
                    int quantityt = Convert.ToInt32(qunatity.Value);


                    string Query = "insert into BookTB values('{0}','{1}','{2}','{3}','{4}')";
                    Query = string.Format(Query, booktit, ddbookauthor, ddbookcat, quantityt, pricee);
                    con.SetData(Query);
                    showbook();
                    errormsg.Text = "Book Inserted!!!";

                    Booktitle.Value = "";
                    DDBOOKAUthor.SelectedIndex = -1;
                    ddboocat.SelectedIndex = -1;
                    price.Value = "";
                    qunatity.Value = "";   
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }
        int key = 0;
        protected void bookgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Booktitle.Value = bookgv.SelectedRow.Cells[2].Text;
            DDBOOKAUthor.SelectedItem.Value = bookgv.SelectedRow.Cells[3].Text;
             ddboocat.SelectedItem.Value = bookgv.SelectedRow.Cells[4].Text;
             price.Value = bookgv.SelectedRow.Cells[5].Text;

             qunatity.Value = bookgv.SelectedRow.Cells[6].Text;


             if (Booktitle.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(bookgv.SelectedRow.Cells[1].Text);
            }
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Booktitle.Value == "" || DDBOOKAUthor.SelectedIndex == -1 || ddboocat.SelectedIndex == -1 || price.Value == "" || qunatity.Value == "")
                {
                    errormsg.Text = "missing details!!!";
                }
                else
                {
                    string booktit = Booktitle.Value;
                    string ddbookauthor = DDBOOKAUthor.SelectedValue.ToString();
                    string ddbookcat = ddboocat.SelectedValue.ToString();

                    int pricee = Convert.ToInt32(price.Value);
                    int quantityt = Convert.ToInt32(qunatity.Value);

                    string Query = "update BookTB set BName = '{0}',BAuthor = '{1}', BCategory = '{2}', BQty = '{3}', BPrice = '{4}' where BId = {5}";
                    Query = string.Format(Query, booktit, ddbookauthor, ddbookcat, quantityt, pricee ,bookgv.SelectedRow.Cells[1].Text);
                    con.SetData(Query); 
                    showbook();  
                    errormsg.Text = "Book Updated!!!";

                    Booktitle.Value = "";
                    DDBOOKAUthor.SelectedIndex = -1;
                    ddboocat.SelectedIndex = -1;
                    price.Value = "";
                    qunatity.Value = ""; 
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
                if (Booktitle.Value == "" || DDBOOKAUthor.SelectedIndex == -1 || ddboocat.SelectedIndex == -1 || price.Value == "" || qunatity.Value == "")
                {
                    errormsg.Text = "select author data details!!!";
                }
                else
                {
                    string booktit = Booktitle.Value;
                    string ddbookauthor = DDBOOKAUthor.SelectedValue.ToString();
                    string ddbookcat = ddboocat.SelectedValue.ToString();

                    int pricee = Convert.ToInt32(price.Value);
                    int quantityt = Convert.ToInt32(qunatity.Value);
                    string Query = "delete from BookTB where BId = {0}";
                    Query = string.Format(Query, bookgv.SelectedRow.Cells[1].Text);
                    con.SetData(Query);
                    showbook();
                    errormsg.Text = "Book Deleted!!!";

                    Booktitle.Value = "";
                    DDBOOKAUthor.SelectedIndex = -1;
                    ddboocat.SelectedIndex = -1;
                    price.Value = "";
                    qunatity.Value = ""; 
                
                }
            }
            catch (Exception Ex)
            {
                errormsg.Text = Ex.Message;

            }
        }

    }
}