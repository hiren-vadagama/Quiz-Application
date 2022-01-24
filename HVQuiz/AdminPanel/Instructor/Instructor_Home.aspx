<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Instructor_Home.Master" AutoEventWireup="true" CodeBehind="Instructor_Home.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.Instructor_Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="navbar" runat="server">
        <header id="header">
            <div class="row">
            <div class="container">
              <div id="logo" class="pull-left">
                <h1><a href="#body" class="scrollto">
                <img src="../../assets/images/logo.png" style="width: 45px;height: 45px">Q<span>uiz</span></a></h1>
                <!-- Uncomment below if you prefer to use an image logo -->
                <!-- <a href="#body"><img src="img/logo.png" alt="" title="" /></a>-->
              </div>

              <nav id="nav-menu-container">
                <ul class="nav-menu">
                  <li class="menu-active"><a href="Instructor_Home.aspx">Home</a></li>
                  <li><a href="Instructor_Dashboard.aspx">Dashboard</a></li>
                  <li><a href="CreateQuiz.aspx">Create Quiz</a></li>
                  <li><a href="Instructor_Performance.aspx">Performance</a></li>
                  <li><a href="AddQuestion.aspx">Add Question</a></li>
                  <li class="menu-has-children"><a><i class="fas fa-user"></i> <asp:Label ID="lbluser" runat="server"></asp:Label></a>
                    <ul>
                      <li><a href="EditProfileOfInst.aspx">Edit Profile</a></li>
                      <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogout"><i class="fas fa-user"></i><asp:Label Text=" Log Out" runat="server"></asp:Label></asp:LinkButton></li>
                    </ul>
                  </li>
                                     
                </ul>
              </nav><!-- #nav-menu-container -->
            </div>
                </div>
          </header><!-- #header -->
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cpTime" runat="server">
             
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="services">

             <asp:Literal ID="litScript" runat="server" />
              <div class="container">
                  <asp:Label ID="lblError" runat="server"></asp:Label>
                  <asp:Label ID="lblTime" runat="server"></asp:Label>
                <div class="section-header">
                    <h2>Your Quiz</h2>
                </div>

                <div class="row">
                    <asp:Repeater id="repeat" runat="server">
                     <ItemTemplate>
                        <div class='col-lg-6'>
                                <div class='box wow fadeInLeft'>
                                        <div class='icon' style="float:right;">
                                            <asp:LinkButton ID="btnDeleteQuiz" runat="server" OnCommand="btnDeleteQuiz" CommandName="MyUpdate" CommandArgument='<%# Eval("QuizId") %>'><i class="fas fa-trash-alt" style="font-size:x-large"></i>
                                            </asp:LinkButton>
                                        </div>
                                        <asp:LinkButton runat="server" OnCommand="LinkButton1_Command" CommandName="MyUpdate" CommandArgument='<%# Eval("QuizId") %>'>
                                        <div class='icon'><i class='fas fa-question-circle'></i></div>
                                            <h4><%#Eval("QuizName") %></h4>
                                                <p class='description'>Subject: <%#Eval("SubjectName") %></p>
                                                <p class='description'>Starting Time: <%#Eval("Date") %> | <%#Eval("StartTime") %> </p>
                                                <p class='description'>Ending Time: <%#Eval("EndDate") %> | <%#Eval("EndTime") %></p>
                                                <p class='description'>Time Duration: <%#Eval("TimeDuration") %> Min</p>
                                        
                                        </asp:LinkButton>
                                </div>
                        </div>      
                     </ItemTemplate>
                    </asp:Repeater>                

                </div>
                  </div>
            </section><!-- #services -->
</asp:Content>
