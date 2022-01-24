<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp2.aspx.cs" Inherits="HVQuiz.SignUp2" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title> VS Quiz </title>
     <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
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
                    <div class="row log-det">
                             <div class="small-logo">
                                    <img src="assets/images/logo.png" style="height: 60px; width: 60px;"/><h5>Vadagama <br/> softwares</h5>
                             </div>
                    </div>
                     <div class="row">
                        <div class="col-md-4"></div>
                        <div class="col-md-8">                                                                  
                            <h6><asp:Label ID="lblmsg" runat="server"></asp:Label></h6>
                        </div>
                    </div>
                    <div class="row log-det">
                        <div class="col-md-4"></div>
                        <div class="col-md-4">                                                                  
                            <h4>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; More Details</h4>
                        </div>
                        <div class="col-md-4"></div>
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                        <i class="fas fa-graduation-cap"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtCourse" runat="server" class="form-control" placeholder="Course" aria-label="Course" aria-describedby="basic-addon1"></asp:TextBox>
                                 </div>
                               
                                 <div class="input-group mb-3">
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><i class="fas fa-university"></i></span>
                                    </div>
                                    <asp:TextBox ID="txtCollege" runat="server" type="text" class="form-control" placeholder="College" aria-label="College" aria-describedby="basic-addon1"></asp:TextBox>
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                           <asp:Label ID="lblbdlogo" runat="server"><i class="fas fa-birthday-cake"></i></asp:Label><asp:Label ID="lbldate" runat="server"></asp:Label>
                                        </span>
                                    </div>
                                    <asp:TextBox ID="txtBirthDate" runat="server" TextMode="Date" class="form-control" aria-label="BirthDate" aria-describedby="basic-addon1"></asp:TextBox>
                                 </div>
                            </div>       
                        </div>
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                 <div class="input-group mb-3">
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                            <i class="fas fa-map-marked-alt"></i>
                                        </span>
                                    </div>
                                     <asp:DropDownList ID="ddlState" runat="server" class="form-control" aria-label="State" aria-describedby="basic-addon1" AutoPostBack="true" OnSelectedIndexChanged="changeValueOfddl">
                                     </asp:DropDownList>
                                 </div>  
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                           <i class="fas fa-city"></i>
                                        </span>
                                    </div>
                                    <asp:DropDownList ID="ddlCity" runat="server" class="form-control" aria-label="City" aria-describedby="basic-addon1">
                                         <asp:ListItem Value="0">Select City</asp:ListItem>
                                     </asp:DropDownList>     
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1">
                                           <asp:Label runat="server">Gender</asp:Label>
                                        </span>
                                    </div>
                                     <div  class="form-control input-group-prepend">
                                         <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                                             <asp:ListItem Text="Male"></asp:ListItem>
                                             <asp:ListItem Text="Female"></asp:ListItem>
                                             <asp:ListItem Text="Other"></asp:ListItem>
                                         </asp:RadioButtonList>
                                     </div>
                                 </div>
                            </div>    
                         </div>
                        </div>
                     <div class="row">
                        <div class="col-md-5 col-sm-4"></div>
                        <div class="col-md-4 col-sm-4 input-group-prepend">                                                                  
                            <div class="input-group center sup mb-3 ">
                                <asp:Button ID="btnSkip" runat="server" Text="Skip" class="btn btn-round btn-outline-light box-de" OnClick="btnSkip_Click"/>&nbsp;
                                <asp:Button ID="btnContinue" runat="server" Text="Continue" class="btn btn-round btn-outline-light box-de" OnClick="btnContinue_Click"/>
                            </div>  
                        </div>
                        <div class="col-md-3 col-sm-4"></div>
                    </div>           
                </div>
            </div>
        </div>
    </div>

    </form>
</body>
</html>
