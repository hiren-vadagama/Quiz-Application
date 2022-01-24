<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="CreateQuiz.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.CreateQuiz_aspx" %>
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
                                    <asp:TextBox ID="txtQuizname" runat="server" type="text" class="form-control" placeholder="Quiz Name" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvQuizname" runat="server" ErrorMessage="*" ControlToValidate="txtQuizname" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Start Date</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtDate" runat="server" TextMode="Date" class="form-control" aria-label="Date" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ErrorMessage="*" ControlToValidate="txtDate" ForeColor="Red"></asp:RequiredFieldValidator>
                                     <asp:CompareValidator ID="cmvDate" runat="server" ErrorMessage="*" Operator="GreaterThanEqual" ControlToValidate="txtDate" Type="Date" ForeColor="Red" ></asp:CompareValidator>
                                 </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">End Date</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtEnddate" runat="server" TextMode="Date" class="form-control" aria-label="Date" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ErrorMessage="*" ControlToValidate="txtEnddate" ForeColor="Red"></asp:RequiredFieldValidator>
                                     <asp:CompareValidator ID="cmpEndDate" runat="server" ErrorMessage="*" Operator="LessThanEqual" ControlToCompare="txtEnddate" ControlToValidate="txtDate" Type="Date" ForeColor="Red" ></asp:CompareValidator>
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Number of Ques.</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtNumberofQues" runat="server" type="text" class="form-control" placeholder="Number of Questions" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNumberofQues" runat="server" ErrorMessage="*" ControlToValidate="txtNumberofQues" ForeColor="Red" ></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="cmvNum" runat="server" ErrorMessage="*" Operator="GreaterThanEqual" ControlToValidate="txtNumberofQues" Type="Integer" ForeColor="Red" ></asp:CompareValidator>   
                                </div>
                            </div>                      
                        </div>
                        
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Time</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtTimeDuration" runat="server" type="text" class="form-control" placeholder="Time Duration(in Minute)" aria-label="Username" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvTimeDuration" runat="server" ErrorMessage="*" ControlToValidate="txtTimeDuration" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                    <asp:CompareValidator ID="cmvTime" runat="server" ErrorMessage="*" Operator="GreaterThanEqual" ControlToValidate="txtTimeDuration" Type="Integer" ForeColor="Red" ></asp:CompareValidator>

                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Start Time(HH)</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtstart" runat="server" type="text" class="form-control" placeholder="HH" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvstart" runat="server" ErrorMessage="*" ControlToValidate="txtstart" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                    <asp:CompareValidator ID="cmvstart" runat="server" ErrorMessage="*" Operator="LessThanEqual" ControlToValidate="txtstart" Type="Integer" ForeColor="Red" ></asp:CompareValidator>
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Min</asp:Label></span>
                                    </div>
                                     <asp:TextBox ID="txtmin" runat="server" type="text" class="form-control" placeholder="MM" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvmin" runat="server" ErrorMessage="*" ControlToValidate="txtmin" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                    <asp:CompareValidator ID="cmvmin" runat="server" ErrorMessage="*" Operator="LessThanEqual" ControlToValidate="txtmin" Type="Integer" ForeColor="Red" ></asp:CompareValidator>

                                 </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">End Time(HH)</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtEndhr" runat="server" type="text" class="form-control" placeholder="HH" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rvEndhr" runat="server" ErrorMessage="*" ControlToValidate="txtEndhr" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                    <asp:CompareValidator ID="cmpEndhr" runat="server" ErrorMessage="*" Operator="LessThanEqual" ControlToValidate="txtEndhr" Type="Integer" ForeColor="Red" ></asp:CompareValidator>
                                     <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Min</asp:Label></span>
                                    </div>
                                     <asp:TextBox ID="txtEndmin" runat="server" type="text" class="form-control" placeholder="MM" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rvEndmin" runat="server" ErrorMessage="*" ControlToValidate="txtEndmin" ForeColor="Red" ></asp:RequiredFieldValidator>                            
                                    <asp:CompareValidator ID="cmpEndmin" runat="server" ErrorMessage="*" Operator="LessThanEqual" ControlToValidate="txtEndmin" Type="Integer" ForeColor="Red" ></asp:CompareValidator>
                                 </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Subject</asp:Label></span>
                                    </div>
                                    <asp:DropDownList ID="ddlSubject" runat="server" class="form-control" aria-describedby="basic-addon1" AutoPostBack="true">
                                     </asp:DropDownList>                   
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
                            <asp:Button ID="btnSet" runat="server" class="btn btn-round btn-outline-light box-de" Text="Create" OnClick="btn_createQuiz"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
