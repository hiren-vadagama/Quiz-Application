<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="HVQuiz.SignUp" %>

<!DOCTYPE html>

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
                       <div class="col-lg-4 col-md-5 box-de">
                          
                            <div class="ditk-inf sup-oi">
                                <h2 class="w-100">Already Have an Account </h2>
                                <p>Simply login to your acbuttoncount by clicking the login Button</p>
                                <a href="Default.aspx">
                                    <button type="button" class="btn btn-outline-light">SIGN IN</button>
                                </a>
                            </div>
                        </div>
                        <div class="col-lg-8 col-md-7 log-det">
                             <div class="small-logo">
                                    <img src="assets/images/logo.png" style="height: 60px; width: 60px;"/><h5>Vadagama <br/> softwares</h5>
                                </div>
                            <h2>Create Account</h2>
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
                            <div class="row">
                                <p class="small-info"><asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label></p>        
                            </div>


                            <div class="text-box-cont">
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                        <i class="far fa-user"></i></span>
                                    </div>
                                     <asp:RadioButton ID="rbStu" Checked="true" Text="Student" runat="server" GroupName="rbgtype" class="form-control"/>
                                     <asp:RadioButton ID="rbIns" Text="Instructor" runat="server" GroupName="rbgtype" class="form-control"/>
                                 </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                        <i class="far fa-user"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtUsername" runat="server" type="text" class="form-control" placeholder="Name" aria-label="Username" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtUsername"></asp:RequiredFieldValidator>
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                            <i class="far fa-envelope"></i>
                                        </span>
                                    </div>
                                    <asp:TextBox ID="txtEmail" runat="server" type="text" class="form-control" placeholder="Email" aria-label="Email" aria-describedby="basic-addon1"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="*" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>           
                                   </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                        <i class="fas fa-mobile-alt"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtMobile" runat="server" type="text" class="form-control" placeholder="Mobile no." aria-label="Mobile" aria-describedby="basic-addon1"></asp:TextBox>
                                     <asp:RequiredFieldValidator ID="rfvMobile" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtMobile"></asp:RequiredFieldValidator>
                                     <asp:RegularExpressionValidator ID="revMobileRang" runat="server" ControlToValidate="txtMobile" ErrorMessage="*" ForeColor="Red" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                                 </div>
                                 <div class="input-group mb-3">
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><i class="fas fa-lock"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" type="text" class="form-control" placeholder="Password" aria-label="Password" aria-describedby="basic-addon1"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                                 </div>
                                <div class="input-group mb-3">
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><i class="fas fa-lock"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtRePassword" runat="server" type="text" class="form-control" placeholder="Retype Password" aria-label="Password" aria-describedby="basic-addon1"></asp:TextBox>
                                      <asp:RequiredFieldValidator ID="rfvRepass" runat="server" ErrorMessage="*" ForeColor="Red" ControlToValidate="txtRePassword"></asp:RequiredFieldValidator>                                    
                                    <asp:CompareValidator ID="cmpRepassword" runat="server" ErrorMessage="*" ForeColor="Red" ControlToCompare="txtPassword" ControlToValidate="txtRePassword"></asp:CompareValidator>
                                </div>
                               
                                <div class="input-group center sup mb-3">
                                    <asp:Button ID="btnsignup" runat="server" Text="SIGN UP" class="btn btn-round btn-outline-light box-de" OnClick="signUpUser"/>
                                </div>    
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