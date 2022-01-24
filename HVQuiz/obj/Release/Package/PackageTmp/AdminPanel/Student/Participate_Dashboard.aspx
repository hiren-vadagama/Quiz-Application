<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Participate_Home.Master" AutoEventWireup="true" CodeBehind="Participate_Dashboard.aspx.cs" Inherits="HVQuiz.AdminPanel.Student.Participate_Dashboard" %>

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

<asp:Content ID="ConNav" ContentPlaceHolderID="ContentPlaceHolderNavbar" runat="server">
    <nav id="nav-menu-container">
                <ul class="nav-menu">
                  <li><a href="Participate_Home.aspx">Home</a></li>
                  <li class="menu-active"><a>Dashboard</a></li>
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

         <div>
                    <h6><asp:Label ID="lblmsg" runat="server"></asp:Label></h6>
                </div>
              <div class="container">
                <div class="section-header">
                    <h2>Your Details</h2>
                </div>
                  <asp:Label ID="eee" runat="server"></asp:Label>
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
                                                <h4><%#Eval("participateName") %></h4>
                                                <p class='description'>Course Name: <%#Eval("CourseName") %></p>
                                                <p class='description'>College Name: <%#Eval("CollegeName") %></p>
                                                <p class='description'>Email: <%#Eval("Email") %> </p>
                                                <p class='description'>Gender: <%#Eval("Gender") %></p>
                                                <p class='description'>MobileNo: <%#Eval("MobileNo") %></p>
                                                <p class='description'>State Name: <%#Eval("StateName") %></p>
                                                <p class='description'>City Name: <%#Eval("City_name") %></p>
                                                <p class='description'>Birthdate: <%#Eval("Birthdate") %></p>
                                                <p class='description'>Age: <%#Eval("Age") %></p>
                                        </div>
                                    </div>
                                </div>
                            </div>      
                         </ItemTemplate>
                        </asp:Repeater>             
                    </div>

            </section><!-- #services -->


</asp:Content>