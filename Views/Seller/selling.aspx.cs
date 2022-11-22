using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
 





namespace BookMS.Views.Seller 
{
    
    public partial class selling : System.Web.UI.Page
    {


        Model.Functions con;
        
         

             
        protected void Page_Load(object sender, EventArgs e)
        {

            //string seller = Session["user"].ToString();

        // string User = Session["UName"].ToString();


            con = new Model.Functions();
            if (!IsPostBack)
            {
                showbookseller();

                DataTable dt = new DataTable();
                    dt.Columns.AddRange(new DataColumn[5]
                        {

                            new DataColumn("ID"),
                            
                            new DataColumn("Book"),
                            
                            new DataColumn("Price"),
                            
                            new DataColumn("Quantity"),
                            
                            new DataColumn("Total")                      
                        
                        }
                                               
                        );

                    ViewState["Bill"] = dt;
                    this.BindGrid();
            }

        }




        protected void BindGrid() {


            Billlist.DataSource = ViewState["Bill"];
            Billlist.DataBind();
        
        
        }


        private void showbookseller() {


            string Query = "select BId as Code,BName as Name,BQty as Stock,BPrice as Price from BookTB";


            bookgv.DataSource = con.GetData(Query);
            bookgv.DataBind();
        
       
        
        }
        int key = 0;
        int stock = 0;

        protected void bookgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            Booknabme.Value = bookgv.SelectedRow.Cells[2].Text;
            stock = Convert.ToInt32(bookgv.SelectedRow.Cells[3].Text);
           Bprice.Value= bookgv.SelectedRow.Cells[4].Text;



           if (Booknabme.Value == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(bookgv.SelectedRow.Cells[1].Text);
            }
        }

        protected void Billlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void updatestock()
        
        {
            



        int newqty;
            newqty=Convert.ToInt32(bookgv.SelectedRow.Cells[3].Text) - Convert.ToInt32(Bqtytb.Value);
          
                    string Query = "update BookTB set  BQty = '{0}' where BId = {1}";
                    Query = string.Format(Query, newqty ,bookgv.SelectedRow.Cells[1].Text);
                    con.SetData(Query); 
                    showbookseller();
        
        }
        private void insertbill() {



            string Query = "insert into billtbl (Bdate,Amount) values('{0}','{1}')";
              Query = string.Format(Query,Datetb.Text.ToString(),Convert.ToInt32(Grandtotaltb.Text.Substring(2)));
                con.SetData(Query);
        
        }




        int grandtotal = 0;
        int amount;
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Bqtytb.Value =="" || Bprice.Value==""|| Booknabme.Value=="")
            {
                
            }
            else
	            {
                int total = Convert.ToInt32(Bqtytb.Value) * Convert.ToInt32(Bprice.Value);
            DataTable dt = (DataTable)ViewState["Bill"];
            dt.Rows.Add(Billlist.Rows.Count + 1,
            Booknabme.Value.Trim(),
            Bprice.Value.Trim(),
            Bqtytb.Value.Trim(),
            total);

            ViewState["Bill"] = dt;
            this.BindGrid();
            updatestock();


         

            for (int i = 0; i < Billlist.Rows.Count-1; i++)
            {
                grandtotal = grandtotal + Convert.ToInt32(Billlist.Rows[i].Cells[5].Text);
                
            }
            amount = grandtotal;
            Grandtotaltb.Text = "Rs" + grandtotal;
                 Booknabme.Value="";
            Bprice.Value="";
            Bqtytb.Value = "";
                }
        }

        protected void printbtn_Click(object sender, EventArgs e)
        {
            insertbill();




        }
         
            
    
    
    }
}