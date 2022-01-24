<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="AddQuestion.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.AddQuestion" %>
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
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Question</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtQuestion" runat="server" TextMode="MultiLine" type="text" class="form-control" placeholder="Enter Question" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ErrorMessage="*" ControlToValidate="txtQuestion" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Answer</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtans" runat="server" class="form-control" aria-label="Date" aria-describedby="basic-addon1" placeholder="Enter Answer"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvans" runat="server" ErrorMessage="*" ControlToValidate="txtans" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </div>
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Distractor1</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtdistractor1" runat="server" class="form-control" aria-label="Date" aria-describedby="basic-addon1" placeholder="Distractor1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvd1" runat="server" ErrorMessage="*" ControlToValidate="txtdistractor1" ForeColor="Red"></asp:RequiredFieldValidator>
                                 </div>
                                 
                            </div>                      
                        </div>
                        
                        <div class="col-lg-6 col-md-6 log-det">
                            <div class="text-box-cont">
                                <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Distractor2</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtdistractor2" runat="server" type="text" class="form-control" placeholder="Distractor2" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvdistractor2" runat="server" ErrorMessage="*" ControlToValidate="txtdistractor2" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                 <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Distractor3</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtdistractor3" runat="server" type="text" class="form-control" placeholder="Distractor3" aria-describedby="basic-addon1"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvdistractor3" runat="server" ErrorMessage="*" ControlToValidate="txtdistractor3" ForeColor="Red" ></asp:RequiredFieldValidator>
                                </div>
                                
                              <div class="input-group mb-3">
                                    <div class="input-group-prepend">
                                        <span class="input-group-text" id="basic-addon1"><asp:Label runat="server" Font-Size="Smaller">Support</asp:Label></span>
                                    </div>
                                    <asp:TextBox ID="txtSupport" runat="server" type="text" class="form-control" TextMode="MultiLine" placeholder="Enter Support" aria-describedby="basic-addon1"></asp:TextBox>
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
                            <asp:Button ID="btnSet" runat="server" class="btn btn-round btn-outline-light box-de" Text="Save" OnClick="btnSet_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
