<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookMS.Views.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../../Asset/Libs/css/bootstrap.min.css" />
          <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
 
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <div  class="container-fluid">
           
        <div class="row mt-5 mb-5">

        </div>
        <div class="row">
            <div class="col-md-4">

            </div>
            <div class="col-md-4">

                <form id="form1" runat="server">
                    <div class="row">
                            <div class="col-md-3">

                            </div>

                            <div class="col-md-5">
                             <img src="../../Asset/Images/shopping.png" class="align-content-center"/>

                            </div>
                        <div class="col-md-4">

                            </div>
                    </div>
             
                    <div class="mt-3">
                        <label for=" " class="form-label">Email</label>

                    <input type="text" placeholder="Your Email ID" autocomplete="off" runat="server" class="form-control" id="Userid" />
                </div>
                    <div class="mt-3">
                        <label for="" class="form-label">Password</label>

                    <input type="password" placeholder="Password" autocomplete="off" class="form-control" runat="server" id="password" />
                </div>
                    <div class="mt-3 d-grid">
                        <asp:Button Text="Login" runat="server" class ="btn-success btn" ID="loginbtn" OnClick="loginbtn_Click"/>

                    </div>

                    <asp:Label runat="server" id="errormsg" class="text-danger"></asp:Label>
            </form>
            </div>
                <div class="col-md-4">

            </div>
        </div>

         
              
    </div>

    
</body>
</html>
