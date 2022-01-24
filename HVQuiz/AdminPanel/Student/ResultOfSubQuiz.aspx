<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultOfSubQuiz.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.ResultOfSubQuiz" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
  <link rel="stylesheet" type="text/css" href="../../assets/MCQProperty/css/bootstrap.min.css"/>
  <link rel="stylesheet" type="text/css" href="../../assets/MCQProperty/css/all.css"/>
  <script type="text/javascript" src="../../assets/MCQProperty/js/bootstrap.min.js"></script>
  <script type="text/javascript" src="../../assets/MCQProperty/js/jquery.min.js"></script>
  <script type="text/javascript" src="../../assets/MCQProperty/js/all.js"></script>
    <link rel="stylesheet" type="text/css" href="../../assets/MCQProperty/fontawesome/css/all.css"/>
</head>
<body>
    <form id="form1" runat="server">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <asp:Label ID="msgL" runat="server"></asp:Label>
                    </div>
                </div>
            </div>
        
        
                <div class="modal-dialog" >
                    <div class="text-center">
                        <asp:Button ID="btnSubmit" CssClass="btn btn-info" Font-Size="Large" runat="server" Text="Go To Home" OnClick="btnSubmit_Click"/>
                    </div>
                </div>
    </form>
</body>
</html>
