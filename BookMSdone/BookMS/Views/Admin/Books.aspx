<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="BookMS.Views.Admin.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">
    <div class="container-fluid">
        <div class="row">

    
 <div class="col"   ><h3 class="text-center">Manage Books </h3></div>

        </div>



        <div class="row">
             <div class="col-md-4">
                 <div class="mb-3">                   <label for=" " class="form-label text-success">Book Title</label>

                            <input type="text" placeholder="Title" autocomplete="off" class="form-control"  runat="server" id="Booktitle" />
                      </div>       

                    <div class="mb-3">                   <label for=" " class="form-label text-success">Book Author</label>

                    <asp:DropDownList ID="DDBOOKAUthor" runat="server" class="form-control"></asp:DropDownList>
                            </div>  

                    <div class="mb-3">                   <label for=" " class="form-label text-success">Categories</label>

                        <asp:DropDownList ID="ddboocat" runat="server" class="form-control"></asp:DropDownList>
                            
                      </div>  

                 
                    <div class="mb-3">                   <label for=" " class="form-label text-success">Quantity</label>

                            <input type="text" id="qunatity" runat="server" placeholder ="Quantity" autocomplete="off" class="form-control" />
                      </div>  


                    <div class="mb-3">                   <label for=" " class="form-label text-success">Price</label>

                            <input type="text" id="price" runat="server" placeholder="Price" autocomplete="off" class="form-control" />
                      </div>  


                 <div class="row">
                     
     <asp:Label runat="server" id="errormsg" class="text-danger"></asp:Label>
                     <div class="col d-grid">   <asp:Button Text="Update" id="updatebtn" runat="server" class ="btn-warning btn-block btn" OnClick="updatebtn_Click"/></div>

                     <div class="col d-grid">   <asp:Button Text="Save" id="savebtn" runat="server" class ="btn-success btn-block btn" OnClick="savebtn_Click"/></div>
                     <div class="col d-grid">   <asp:Button Text="Delete" id="deletebtn" runat="server" class ="btn-danger btn-block btn" OnClick="deletebtn_Click"/></div>


                 </div>


                </div>
             <div class="col-md-8"> 

                 <asp:GridView  id="bookgv" runat="server" class= "table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="bookgv_SelectedIndexChanged">
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
                </div>



        </div>


    </div>


</asp:Content>
