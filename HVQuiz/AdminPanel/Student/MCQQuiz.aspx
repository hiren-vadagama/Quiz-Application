<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MCQQuiz.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.MCQQuiz" %>

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
        <div class="container-fluid">

                <div class="">
                    <div class="modal-content" style="position: fixed; top: 0px; z-index: 50;">
                        <div class="modal-header text-center">
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <asp:Label runat="server" Text="Time"></asp:Label>
                                <h4><asp:Label ID="lblmin" runat="server"></asp:Label>
                                <asp:Label runat="server" Text=" : "></asp:Label>
                                <asp:Label ID="lblsec" runat="server" Text="00"></asp:Label></h4>
                                <asp:Timer ID="Timer1" runat="server" Interval="1000" 
                                    ontick="Timer1_Tick">
                                </asp:Timer>
                            </ContentTemplate>
                            </asp:UpdatePanel> 
                        </div>
                        <div class="modal-header">
                            <asp:Label runat="server">Quiz  Name: </asp:Label>
                            <asp:Label ID="txtqname" runat="server"></asp:Label>
                            <br />
                            <asp:Label runat="server">Total Questions : </asp:Label>
                            <asp:Label ID="txtNumOfQue" runat="server"></asp:Label>
                            <br />
                            <asp:Label runat="server">Total Marks : </asp:Label>
                            <asp:Label ID="txttotal" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>

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
                                <div class="quiz" id="quiz"> 
                                    <div class="funkyradio">
                                       <div class="funkyradio-info">                                 
                                            <asp:RadioButton ID="RadioButton1" runat="server" type="radio" value="1" Text='<%#DataBinder.Eval(Container,"DataItem.distractor1")%>' GroupName='<%#DataBinder.Eval(Container,"DataItem.Qid")%>' />
                                            <asp:RadioButton ID="RadioButton2" runat="server" type="radio" value="2" Text='<%#DataBinder.Eval(Container,"DataItem.distractor2")%>' GroupName='<%#DataBinder.Eval(Container,"DataItem.Qid")%>'/>
                                            <asp:RadioButton ID="RadioButton3" runat="server" type="radio" value="3" Text='<%#DataBinder.Eval(Container,"DataItem.distractor3")%>' GroupName='<%#DataBinder.Eval(Container,"DataItem.Qid")%>'/>
                                            <asp:RadioButton ID="RadioButton4" runat="server" type="radio" value="4" Text='<%#DataBinder.Eval(Container,"DataItem.distractor4")%>' GroupName='<%#DataBinder.Eval(Container,"DataItem.Qid")%>'/>
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
                        <asp:Button ID="btnSubmit" CssClass="btn btn-success" Font-Size="Large" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                    </div>
                </div>
        </div>
    </form>
</body>
</html>
