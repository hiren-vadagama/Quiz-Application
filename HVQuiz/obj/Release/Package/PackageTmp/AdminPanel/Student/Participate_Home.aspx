<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Participate_Home.Master" AutoEventWireup="true" CodeBehind="Participate_Home.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.Participate_Home" %>
<asp:Content ID="Content3" ContentPlaceHolderID="cpTime" runat="server">
             
</asp:Content>

<asp:Content ID="ConNav" ContentPlaceHolderID="ContentPlaceHolderNavbar" runat="server">
    <nav id="nav-menu-container">
                <ul class="nav-menu">
                  <li class="menu-active"><a href="#body">Home</a></li>
                  <li><a href="Participate_Dashboard.aspx">Dashboard</a></li>
                  <li><a href="Participate_Performance.aspx">Performance</a></li>
                    
                  <li class="menu-has-children"><a><i class="fas fa-user"></i> <asp:Label ID="lbluser" runat="server"></asp:Label></a>
                    <ul>
                      <li><a href="../../AdminPanel/Student/EditProfile.aspx">Edit Profile</a></li>
                      <li><asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogout"><i class="fas fa-user"></i><asp:Label Text=" Log Out" runat="server"></asp:Label></asp:LinkButton></li>
                    </ul>
                  </li>
                </ul>
              </nav><!-- #nav-menu-container -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="services">
    <asp:Literal ID="litScript" runat="server" />
        <h6><asp:Label ID="lblmsg" runat="server"></asp:Label></h6>
              <div class="container">
                <div class="section-header">
                    <h2>Your Quiz</h2>
                </div>
                  <asp:Label ID="eee" runat="server"></asp:Label>
                <div class="row">
                    <asp:Repeater id="repeat" runat="server">
                     <ItemTemplate>
                        <div class='col-lg-6'>
                            <asp:LinkButton runat="server" OnCommand="LinkButton1_Command" CommandName="MyUpdate" CommandArgument='<%# Eval("QuizId") %>'>
                                <div class='box wow fadeInLeft'>
                                    <div class='icon'><i class='fas fa-question-circle'></i></div>
                                        <h4><%#Eval("QuizName") %></h4>
                                        <p class='description'>Subject: <%#Eval("SubjectName") %></p>
                                        <p class='description'>Starting Time: <%#Eval("Date") %> | <%#Eval("StartTime") %> </p>
                                        <p class='description'>Ending Time: <%#Eval("EndDate") %> | <%#Eval("EndTime") %></p>
                                        <p class='description'>Time Duration: <%#Eval("TimeDuration") %> Min</p>
                                    </div>
                            </asp:LinkButton>
                        </div>      
                     </ItemTemplate>
                    </asp:Repeater>             
                </div>
            </div>
            </section><!-- #services -->

    <section id="services">
    <asp:Literal ID="LitForSubQuiz" runat="server" />
              <div class="container">
                <div class="section-header">
                  <h2>Your Skills</h2>
                </div>
                <div class="row">
                    <asp:Repeater id="repeatForSubQuiz" runat="server">
                     <ItemTemplate>
                        <div class='col-lg-6'>
                            <asp:LinkButton runat="server" OnCommand="OnCommandForSubQuiz" CommandName="MyUpdateForSubQuiz" CommandArgument='<%# Eval("SubjectId") %>'>
                                <div class='box wow fadeInLeft'>
                                        <div class="icon"><asp:Label ID="lblSublogo" runat="server" style="font-size: 74px" ForeColor="#50d8af"></asp:Label>
                                    <br>
                                    <br>
                                        <div class="icon"><asp:Label ID="str1" runat="server" class="far fa-star" style="font-size: 12px" ForeColor="#50d8af"></asp:Label></div>
                                        <div class="icon"><asp:Label ID="str2" runat="server" class="far fa-star" style="font-size: 12px" ForeColor="#50d8af"></asp:Label></div>
                                        <div class="icon"><asp:Label ID="str3" runat="server" class="far fa-star" style="font-size: 12px" ForeColor="#50d8af"></asp:Label></div>
                                        <div class="icon"><asp:Label ID="str4" runat="server" class="far fa-star" style="font-size: 12px" ForeColor="#50d8af"></asp:Label></div>
                                        <div class="icon"><asp:Label ID="str5" runat="server" class="far fa-star" style="font-size: 12px" ForeColor="#50d8af"></asp:Label></div>
                                    </div>                                        
                                    <h4><%#Eval("SubjectName") %></h4>
                                        <asp:Label runat="server" Visible="false"><p class='description'>Rank: <asp:Label runat="server" ID="LevelId" Text=' <%#Eval("LevelId") %>'></asp:Label> </p></asp:Label>
                                        <asp:Label runat="server" Visible="false"><p class='description'>Subject: <asp:Label runat="server" ID="lblSubId" Text=' <%#Eval("SubjectId") %>'></asp:Label> </p></asp:Label>
                                        <asp:Label runat="server"><p class='description'>Level: <asp:Label runat="server" ID="Label1" Text=' <%#Eval("LevelName") %>'></asp:Label> </p></asp:Label>
                                        <asp:Label runat="server"><p class='description'>Score: <asp:Label runat="server" ID="Label2" Text=' <%#Eval("Score") %>'></asp:Label> </p></asp:Label>
                                        <p class="description"><%#Eval("SubDisc") %></p>
                                    </div>
                            </asp:LinkButton>
                        </div>      
                     </ItemTemplate>
                    </asp:Repeater>             
                </div>
            </div>
            </section><!-- #services -->

    <!-- #Skills Available For Practice -->
    <section id="services">
    <asp:Literal ID="LitForSubQuizNonSelected" runat="server" />
              <div class="container">
                <div class="section-header">
                  <h2>Skills Available For Practice</h2>
                </div>
                <div class="row">
                    <asp:Repeater id="repeatForSubQuizNonSelected" runat="server">
                     <ItemTemplate>
                        <div class='col-lg-6'>
                            <asp:LinkButton runat="server" OnCommand="OnCommandForSubQuizNonSelected" CommandName="MyUpdateForSubQuizNonSelected" CommandArgument='<%# Eval("SubjectId") %>'>
                                <div class='box wow fadeInLeft'>
                                        <div class="icon"><asp:Label ID="lblSublogoForNon" runat="server" style="font-size: 74px" ForeColor="#50d8af"></asp:Label>
                                    <br>
                                    <br>
                                        
                                    </div>                                        
                                    <h4><%#Eval("SubjectName") %></h4>
                                        <p class='description'>Subject: <asp:Label runat="server" ID="lbNonlSubId" Text=' <%#Eval("SubjectId") %>'></asp:Label> </p>
                                        <p class="description"><%#Eval("SubDisc") %></p>
                                    </div>
                            </asp:LinkButton>
                        </div>      
                     </ItemTemplate>
                    </asp:Repeater>             
                </div>
            </div>
            </section><!-- #services -->


</asp:Content>