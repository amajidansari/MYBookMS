<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Author.aspx.cs" Inherits="BookMS.Views.Admin.Author" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mycontent" runat="server">

      <div class="container-fluid">
        <div class="row">

    
 <div class="col"   ><h3 class="text-center">Manage Author </h3></div>

        </div>



        <div class="row">
             <div class="col-md-4">
                 <div class="mb-3">                   <label for=" " class="form-label text-success">Author Name</label>

                            <input type="text" placeholder="Title" autocomplete="off" class="form-control" runat="server" id="anametb" />
                      </div>       

                    <div class="mb-3">                   <label for=" " class="form-label text-success">Author Geder</label>

                    <asp:DropDownList id="gendd" runat="server" class="form-control">
                        
                            <asp:ListItem>Male</asp:ListItem>
                        
                            <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                            </div>  

                    <div class="mb-3">                   <label for=" " class="form-label text-success">Country</label>

                        <asp:DropDownList ID="countrycb" runat="server" class="form-control">

                            <asp:ListItem>USA</asp:ListItem>
                            
                            <asp:ListItem>UK</asp:ListItem>
                            
                            <asp:ListItem>SaudiArabia</asp:ListItem>
                            
                            <asp:ListItem>India</asp:ListItem>
                            
                            <asp:ListItem>Pakistan</asp:ListItem>
                            
                            <asp:ListItem>China</asp:ListItem>
                        
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:DropDownList>
                            
                      </div>  


 <div class="row">
     <asp:Label runat="server" id="errormsg" class="text-danger"></asp:Label>
                     <div class="col d-grid">   <asp:Button Text="Update" id="edtbtn" runat="server" class ="btn-warning btn-block btn" OnClick="edtbtn_Click1"/></div>

                     <div class="col d-grid">   <asp:Button Text="Save" id="savebtn" runat="server" class ="btn-success btn-block btn" OnClick="savebtn_Click"/></div>
                     <div class="col d-grid">   <asp:Button Text="Delete" id="deletebtn" runat="server" class ="btn-danger btn-block btn" OnClick="deletebtn_Click"/></div>


                 </div>


                </div>
             <div class="col-md-8">
                 <asp:GridView  id="AuthorlistGV" runat="server" class= "table" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateSelectButton="True" OnSelectedIndexChanged="AuthorlistGV_SelectedIndexChanged">
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
