<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Result.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.Result" %>

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
        <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header">
                            <div class="row">
                                <div class="col-md-1">
                                    <h4>Q:<%#DataBinder.Eval(Container,"DataItem.Qid")%></h4>
                                </div>
                               <div class="col-md-11">
                                   <h5><%#DataBinder.Eval(Container,"DataItem.question")%></h5>
                                </div>
                            </div>
                        </div>
                        <div class="modal-body">
                            <div class="col-xs-3 5"> </div>
                                <div class="quiz" id="quiz" data-toggle="buttons"> 
                                    <div class="funkyradio">
                                        <div class="funkyradio-info">                                 
                                            <asp:RadioButton ID="RadioButton1" Enabled="false" runat="server"  Checked="true" type="radio" value="1" Text='<%#DataBinder.Eval(Container,"DataItem.correct_answer")%>' GroupName='<%#DataBinder.Eval(Container,"DataItem.Qid")%>'/>
                                       <asp:Label runat="server"><%#DataBinder.Eval(Container,"DataItem.support")%></asp:Label>
                                        </div>
                                    </div>
                              </div>
                        </div>
                    </div>        
                </div>
            </ItemTemplate>
            </asp:Repeater>
        
                <div class="modal-dialog" >
                    <div class="text-center">
                        <asp:Button ID="btnSubmit" CssClass="btn btn-info" Font-Size="Large" runat="server" Text="Go To Home" OnClick="btnSubmit_Click"/>
                    </div>
                </div>
    </form>
</body>
</html>
