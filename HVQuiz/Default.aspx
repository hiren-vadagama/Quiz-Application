<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HVQuiz.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title> VS Quiz </title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="assets/images/logo.png" rel="icon"/>
    <link rel="stylesheet" type="text/css" href="fontawesome/css/all.css"/>
    <link rel="shortcut icon" href="assets/images/fav.jpg"/>
    <link rel="stylesheet" href="assets/css/fontawsom-all.min.css"/>
        <link rel="stylesheet" href="assets/css/bootstrap.min.css"/>
        <link rel="stylesheet" type="text/css" href="assets/css/style.css" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid">
            <div class="container">
                <div class="row">
                    <div class="col-sm-10 login-box">
                        <div class="row">
                            <div class="col-lg-8 col-md-7 mid-det">
                                <div class="small-logo">
                                    <img src="assets/images/logo.png" style="height: 60px; width: 60px;"/><h5>Vadagama <br/> softwares</h5>
                                </div>
                                <h2>Sign in as</h2>
                                <br/>
                                <div class="row">
                                    <ul>
                                        <li><asp:HyperLink runat="server" CssClass="k fas fa-user-graduate box-de btn-outline-light" NavigateUrl="Login.aspx?As=0"></asp:HyperLink></li>
                                        <li><asp:HyperLink runat="server" CssClass="k fas fa-user-tie box-de btn-outline-light" NavigateUrl="Login.aspx?As=1"></asp:HyperLink></li>
                                        <h4 style="padding: 20px;">Student&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Instructor</h4>
                                    </ul>
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
