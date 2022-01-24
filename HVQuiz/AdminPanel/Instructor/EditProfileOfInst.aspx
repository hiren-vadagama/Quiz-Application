<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="EditProfileOfInst.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.EditProfileOfInst" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContain" runat="server">
    <div class="container-fluid ">
        <div class="container ">
            <div class="row ">

                <div class="col-sm-10 login-box">
                    <div class="row">
                            <div class="text-center">
                                 <asp:Label ID="lblErromsg" runat="server" CssClass="h6" ForeColor="#FF3300"></asp:Label>                           
                            </div>
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Name</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtInstructorName" runat="server" type="text" class="form-control" placeholder="Instructor Name" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvInstructorName" runat="server" ErrorMessage="*" ControlToValidate="txtInstructorName" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Joining Date</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtDate" runat="server" TextMode="Date" class="form-control" aria-label="Date" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ErrorMessage="*" ControlToValidate="txtDate" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Email</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" class="form-control" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ErrorMessage="*" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">MobileNo.</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtMobileNo" runat="server" type="text" class="form-control" placeholder="Number of Questions" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNumberofQues" runat="server" ErrorMessage="*" ControlToValidate="txtMobileNo" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Password</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtPassword" runat="server" type="text" class="form-control" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="*" ControlToValidate="txtPassword" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                            </div>                      
                        </div>
                        
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">College</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtCollege" runat="server" type="text" class="form-control" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvCollegeDuration" runat="server" ErrorMessage="*" ControlToValidate="txtCollege" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                 </div>
                                
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">State</asp:Label></span>
                                    </div>
                                    <asp:DropDownList ID="ddlState" runat="server" class="form-control" aria-describedby="basic-addon1" AutoPostBack="true" OnSelectedIndexChanged="changeValueOfddl">
                                        <asp:ListItem Value="0">Select State</asp:ListItem> 
                                    </asp:DropDownList>                   
                                    <asp:RequiredFieldValidator ID="rfvState" runat="server" ErrorMessage="*" ControlToValidate="ddlState" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                     </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">City</asp:Label></span>
                                    </div>
                                    <asp:DropDownList ID="ddlCity" runat="server" class="form-control" aria-describedby="basic-addon1">
                                        <asp:ListItem Value="0">Select City</asp:ListItem> 
                                    </asp:DropDownList> 
                                    <asp:RequiredFieldValidator ID="rfvCity" runat="server" ErrorMessage="*" ControlToValidate="ddlCity" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Gender</asp:Label></span>
                                    </div>
                                      <div  class="form-control input-group-prepend">
                                         <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                                             <asp:ListItem Text="Male" Value="1"></asp:ListItem>
                                             <asp:ListItem Text="Female" Value="2"></asp:ListItem>
                                             <asp:ListItem Text="Other" Value="3"></asp:ListItem>
                                         </asp:RadioButtonList>
                                     </div>  
                                <asp:RequiredFieldValidator ID="rfvGender" runat="server" ErrorMessage="*" ControlToValidate="rblGender" ForeColor="Red"></asp:RequiredFieldValidator>
                                </div>
                                <div class="row">
                                </div>
                            </div>                     
                        </div>                        
                    </div>
                    <div class="row log-det">
                        <div class="col-md-6">
                            <asp:HyperLink ID="btnCancel" runat="server" class="btn btn-round btn-outline-light box-de" Text="Cancel"  style="float:right" NavigateUrl="~/AdminPanel/Instructor/Instructor_Home.aspx"></asp:HyperLink>
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="btnSet" runat="server" class="btn btn-round btn-outline-light box-de" OnClick="btnEdit" Text="Edit"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
