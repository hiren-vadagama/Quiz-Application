<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Participate_Home.Master" AutoEventWireup="true" CodeBehind="Participate_Performance.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.Participate_Performance" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpTime" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label runat="server">Date: </asp:Label>
                <span style="padding-right:50px"><asp:Label ID="lblDate" runat="server"></asp:Label></span>
                <asp:Label runat="server">Time: </asp:Label>
                <asp:Label ID="lblhr" runat="server"></asp:Label>
                <asp:Label runat="server" Text=" : "></asp:Label>
                <asp:Label ID="lblmin" runat="server"></asp:Label>
                <asp:Label runat="server" Text=" : "></asp:Label>
                <asp:Label ID="lblsec" runat="server">00</asp:Label>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" 
                    ontick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
            </asp:UpdatePanel>           
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderNavbar" runat="server">
        <nav id="nav-menu-container">
                <ul class="nav-menu">
                  <li><a href="Participate_Home.aspx">Home</a></li>
                  <li><a href="Participate_Dashboard.aspx">Dashboard</a></li>
                  <li  class="menu-active"><a>Performance</a></li>
                    
                  <li class="menu-has-children"><a><i class="fas fa-user"></i> <asp:Label ID="lbluser" runat="server"></asp:Label></a>
                    <ul>
                      <li><a href="../../AdminPanel/Student/EditProfile.aspx">Edit Profile</a></li>
                      <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogout"><i class="fas fa-user"></i><asp:Label Text=" Log Out" runat="server"></asp:Label></asp:LinkButton></li>
                    </ul>
                  </li>
                </ul>
              </nav><!-- #nav-menu-container -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="services">
    <asp:Literal ID="litScript" runat="server" />

         <div>
                    <h6><asp:Label ID="lblmsg" runat="server"></asp:Label></h6>
                </div>
              <div class="container">
                <div class="section-header">
                    <h2>Your Performance</h2>
                </div>
                  <asp:Label ID="eee" runat="server"></asp:Label>
                <div class="row">
                    <asp:Repeater id="repeat" runat="server">
                     <ItemTemplate>
                        <div class='col-lg-6'>
                            <asp:LinkButton runat="server" OnCommand="LinkButton1_Command" CommandName="MyUpdate" CommandArgument='<%# Eval("QuizId") %>' Enabled="false">
                                <div class='box wow fadeInLeft'>
                                    <div class='icon'><i class='fas fa-question-circle'></i></div>
                                        <h4><%#Eval("QuizName") %></h4>
                                        <p class='description'>Rank: <asp:Label runat="server" ID="lblrank" Text=' <%#Eval("Rank") %>'></asp:Label> </p>
                                        <p class='description'>Percentage: <asp:Label runat="server" ID="per" Text='<%#Eval("Percentage") %>'></asp:Label> <asp:Label runat="server" ID="simbol" Text="%"></asp:Label></p>
                                        <p class='description'>Subject: <%#Eval("SubjectName") %></p>
                                        <p class='description'>Instructor Name: <%#Eval("InstructorName") %></p>
                                        <p class='description'>Date: <%#Eval("Date") %></p>
                                    </div>
                            </asp:LinkButton>
                        </div>      
                     </ItemTemplate>
                    </asp:Repeater>             
                </div>

            </section><!-- #services -->
</asp:Content>
