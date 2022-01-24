<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HVQuiz.Login" %>

<!DOCTYPE h
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <title> VS Quiz </title>
    <link href="assets/images/logo.png" rel="icon"/>
    <link rel="shortcut icon" href="assets/images/fav.jpg"/>
    <link rel="stylesheet" href="assets/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="assets/css/fontawsom-all.min.css"/>
    <link rel="stylesheet" type="text/css" href="assets/css/style.css" />
    

</head>
<body>
    <form id="form1" runat="server">
<div class="container-fluid ">
        <div class="container ">
            <div class="row ">
                <div class="col-sm-10 login-box">
                    <div class="row">
                        <div class="col-lg-8 col-md-7 log-det">
                            <div class="small-logo">
                                    <img src="assets/images/logo.png" style="height: 60px; width: 60px;"/><h5>Vadagama <br/> softwares</h5>
                                </div>
                            <div class="text-center">
                                 <asp:Label ID="lblErromsg" runat="server" CssClass="h6" ForeColor="#FF3300"></asp:Label>                           
                            </div>
                            <div class="text-center">
                                 <asp:Label ID="lblHead" runat="server" CssClass="h4" Text="Login as "></asp:Label>                           
                            </div>
                           
                            <div class="row">
                                <ul>
                                    <li><i class="fab fa-facebook-f btn-outline-light box-de"></i></li>
                                    <li><i class="fab fa-twitter btn-outline-light box-de"></i></li>
                                    <li><i class="fab fa-linkedin-in btn-outline-light box-de"></i></li>
                                </ul>
                            </div>
                            <div class="row">
                                <p class="small-info">or use your email account</p>
                            </div>
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><i class="fas fa-user"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtUsername" runat="server" type="text" class="form-control" placeholder="Username" aria-label="Username" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvUsernama" runat="server" ErrorMessage="*" ControlToValidate="txtUsername" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><i class="fas fa-lock"></i></span>
                                    </div>
                                     <asp:TextBox ID="txtPassword" TextMode="Password" runat="server" type="text" class="form-control" placeholder="Password" aria-label="Password" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                                <div class="row">
                                    <p class="forget-p">Forget Password ?</p>
                                </div>
                                <div class="input-group center mb-3">
                                    <asp:Button ID="btnlogin" runat="server" class="btn btn-round btn-outline-light box-de" Text="SIGN IN" OnClick="loginAs"/>
                                </div>    
                            </div>
                            


                        </div>
                        <div class="col-lg-4 col-md-5 box-de">
                            <div class="ditk-inf">
                                <h2 class="w-100">Din't Have an Account </h2>
                                <p>Simply Create your account by clicking the Signup Button</p>
                                <a href="SignUp.aspx">
                                <button type="button" class="btn btn-outline-light">SIGN UP</button>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </form>
</body>
    <script src="assets/js/jquery-3.2.1.min.js"></script>
<script src="assets/js/popper.min.js"></script>
<script src="assets/js/bootstrap.min.js"></script>
<script src="assets/js/script.js"></script>
</html>
