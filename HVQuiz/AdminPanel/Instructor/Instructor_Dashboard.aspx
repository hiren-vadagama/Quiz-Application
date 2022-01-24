<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Instructor_Home.Master" AutoEventWireup="true" CodeBehind="Instructor_Dashboard.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.Instructor_Dashboard" %>

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
                <li><a href="Instructor_Home.aspx">Home</a></li>
                  <li class="menu-active"><a href="Instructor_Dashboard.aspx">Dashboard</a></li>
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

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section id="services">

             <asp:Literal ID="litScript" runat="server" />
              <div class="container">
                  <asp:Label ID="lblError" runat="server"></asp:Label>
                  <asp:Label ID="lblTime" runat="server"></asp:Label>
                <div class="section-header">
                    <h2>Your Details</h2>
                </div>

                <div class="row">
                <asp:Repeater id="repeat" runat="server">
                     <ItemTemplate>
                        <div class='col-md-12'>
                            <div class='box wow fadeInLeft'>
                                <div class='icon' style="float:right;">
                                    <asp:LinkButton ID="btnEdit" runat="server" OnClick="EditDetails_Click"><i class="fas fa-edit" style="font-size:x-large"></i>
                                    </asp:LinkButton>
                                    </div>
                                    <div class="row">
                                        <div class="col-md-2">
                                            <br /><br /><br />
                                           <div class='icon text-center'><i class="fas fa-user" style="font-size:100px;"></i></div>
                                        </div>
                                        <div class="col-md-10">
                                                <h4><%#Eval("InstructorName") %></h4>
                                                <p class='description'>College Name: <%#Eval("College") %></p>
                                                <p class='description'>Email: <%#Eval("Email") %> </p>
                                                <p class='description'>Gender: <%#Eval("Gender") %></p>
                                                <p class='description'>MobileNo: <%#Eval("MobileNo") %></p>
                                                <p class='description'>State Name: <%#Eval("StateName") %></p>
                                                <p class='description'>City Name: <%#Eval("City_name") %></p>
                                                <p class='description'>Joining Date: <%#Eval("JoiningDate") %></p>
                                                <p class='description'>Experince: <%#Eval("Experince") %></p>
                                        </div>
                                    </div>
                                </div>
                            </div>      
                         </ItemTemplate>
                        </asp:Repeater>                       

                </div>
                  </div>
            </section><!-- #services -->
</asp:Content>

