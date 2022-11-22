<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Seller.aspx.cs" Inherits="BookMS.Views.Admin.Seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">
    
      <div class="container-fluid">
        <div class="row">

    
 <div class="col"   ><h3 class="text-center">Manage Seller </h3></div>

        </div>



        <div class="row">
             <div class="col-md-4">
                 <div class="mb-3">                   <label for=" " class="form-label text-success">Seller Name</label>

                            <input type="text" placeholder="Seller Name" autocomplete="off" class="form-control" runat="server" id="sellername" />
                      </div>       

                     <div class="mb-3">                   <label for=" " class="form-label text-success">Seller Email</label>

                            <input type="text" placeholder="Email" autocomplete="off" class="form-control" runat="server" id="emailid" />
                      </div>     
              

                   <div class="mb-3">                   <label for=" " class="form-label text-success">Seller Phone</label>

                            <input type="text" placeholder="Sellerphone" autocomplete="off" class="form-control" runat="server" id="sellerphone" />
                      </div>     


                   <div class="mb-3">                   <label for=" " class="form-label text-success">Password</label>

                            <input type="password" placeholder="Password" autocomplete="off" class="form-control" runat="server" id="password" />
                      </div>     


                 

 <div class="row">
     
     <asp:Label runat="server" id="errormsg" class="text-danger"></asp:Label>
                     <div class="col d-grid">   <asp:Button Text="Update" runat="server" ID="updatebtn" class ="btn-warning btn-block btn" OnClick="updatebtn_Click"/></div>

                     <div class="col d-grid">   <asp:Button Text="Save" runat="server" ID="savebtn" class ="btn-success btn-block btn" OnClick="savebtn_Click"/></div>

                     <div class="col d-grid">   <asp:Button Text="Delete" runat="server" ID="deletbtn" class ="btn-danger btn-block btn" OnClick="deletbtn_Click"/></div>


                 </div>


                </div>




             <div class="col-md-8">

                     <asp:GridView  id="sellergv" runat="server" class= "table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="sellergv_SelectedIndexChanged">
                     <AlternatingRowStyle BackColor="White" />
                     <EditRowStyle BackColor="#2461BF" />
                     <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                     <HeaderStyle BackColor="teal" Font-Bold="True" ForeColor="White" />
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
</asp:Content>
