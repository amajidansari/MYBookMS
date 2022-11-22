<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Seller/Sellermaster.Master" AutoEventWireup="true" CodeBehind="selling.aspx.cs" Inherits="BookMS.Views.Seller.selling" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <script type="text/javascript">


       function printbill() {
           var Pgrid = document.getElementById('<%=Billlist.ClientID%>');
            Pgrid.border = 0;
            var pwin = window.open('', 'PrintGrid', 'left=100,top=100,width=1024,height=768,tollbar=0,scrollbars=1,status=0,resizeable=1');
            pwin.document.write(Pgrid.outerHTML);
            pwin.document.close;
            pwin.focus();
            pwin.print();
            pwin.close();



        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">
    
    <div class="container-fluid">
        <div class="row">

        </div>

         <div class="row">
             <div class ="col-md-5">
                   <h3  class=" text-center" style="color:teal;">Book Details</h3>
                 <div class="row">

                     <div class="col">


                         <div class="mt-3">
                        <label for=" " class="form-label text-success">Book Name</label>

                    <input type="text" placeholder="Book Name" autocomplete="off" runat="server" class="form-control" id="Booknabme" />
                </div>
                     </div>
                     
                     <div class="col">


                         <div class="mt-3">
                        <label for=" " class="form-label text-success">Book  Price</label>

                    <input type="text" placeholder="Price" autocomplete="off" runat="server" class="form-control" id="Bprice" />
                </div>
                     </div>

                      
          
                 </div>


                 
                 <div class="row">

                     <div class=" col-sm-5">


                         <div class="mt-3">
                        <label for=" " class="form-label text-success">Stock</label>

                    <input type="text" placeholder="Stock" autocomplete="off" runat="server" class="form-control" id="Bqtytb" />
                </div>
                     </div>
                     
                     <div class="col sm-3">


                         <div class="mt-3 mw-10">
                        <label for=" " class="form-label text-success">Date</label>

                    <asp:TextBox type="date"   runat="server" class="form-control w-50 input-sm"   id="Datetb"  ></asp:TextBox>
                     </div>
                     <div class="row mt-3 mb-3">
                         <div class="col d-grid">
                             <asp:Button Text="Add to Bill" id="Button1" runat="server" class ="btn-warning btn-block btn" OnClick="Button1_Click"/>
                         </div>
                     </div>


                     <div class="row mt-5">

                 
                    <h4  class=" text-center" style="color:teal;">Book List</h4>
                 <div class="col">
                           <asp:GridView  id="bookgv" runat="server" class= "table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="bookgv_SelectedIndexChanged">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#2461BF" />
                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="SlateBlue" Font-Bold="false" ForeColor="White" />
                     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#EFF3FB" />
                     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#F5F7FB" />
                     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                     <SortedDescendingCellStyle BackColor="#E9EBEF" />
                     <SortedDescendingHeaderStyle BackColor="#4870BE" />
                 </asp:GridView>
                 </div>
                      
          
                 </div>

             </div>


             
                     

             </div>




                 </div>
             <div class ="col-md-7">
                 <h4  class=" text-center" style="color:turquoise;">Client List</h4>
                 <div class="col">
                           <asp:GridView  id="Billlist" runat="server" class= "table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="Billlist_SelectedIndexChanged">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#2461BF" />
                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="teal" Font-Bold="false" ForeColor="White" />
                     <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                     <RowStyle BackColor="#EFF3FB" />
                     <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     <SortedAscendingCellStyle BackColor="#F5F7FB" />
                     <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                     <SortedDescendingCellStyle BackColor="#E9EBEF" />
                     <SortedDescendingHeaderStyle BackColor="#4870BE" />
                 </asp:GridView>

                     <div class=" d-grid">  
                          <asp:Label runat="server" id="Grandtotaltb" class="text-danger"></asp:Label>
                           <asp:Button Text="Print" id="printbtn" runat="server" OnClientClick="printbill()" CssClass  ="btn-warning btn-block btn" OnClick="printbtn_Click"/></div>

             </div>

        </div>


    </div>





       </div>

    
</asp:Content>
