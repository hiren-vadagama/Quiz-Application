<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="SetParticipate.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.SetParticipate" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContain" runat="server">
    <div class="container-fluid ">
        <div class="container ">
            <div class="row ">

                <div class="col-sm-12 log-det">
                    <div class="text-center">
                                 <asp:Label ID="lblErromsg" runat="server" CssClass="h6" ForeColor="#FF3300"></asp:Label>                           
                            </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6">
                            <asp:Button ID="btnselectall" runat="server" class="btn btn-round btn-outline-light box-de" Text="Select All" OnClick="btnselectall_Click"/>
                        </div>
                       <span style="float:right"><asp:Button ID="btndeselectall" runat="server" class="btn btn-round btn-outline-light box-de" Text="UnSelect All" OnClick="btnDeselectall_Click"/></span>
                    </div>
                    <div class="row">
                        <div class="col-lg-6 col-md-6 log-det">
                            <asp:GridView ID="gvStuList" runat="server" AutoGenerateColumns="False" DataKeyNames="ParticipateId" CssClass="table table-bordered tab-content table-responsive-md" OnRowCommand="gvStuList_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="ParticipateId" HeaderText="ParticipateId" ReadOnly="True" SortExpression="ParticipateId" />
                                    <asp:BoundField DataField="participateName" HeaderText="participateName" ReadOnly="True" SortExpression="participateName" />
                                    <asp:BoundField DataField="CollegeName" HeaderText="CollegeName" SortExpression="CollegeName" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Button ID="btnselect" runat="server" class="btn btn-round btn-outline-light box-de" Text="Select" CommandName="selectRow" CommandArgument='<%# Eval("ParticipateId") %>'/>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>         
                            </div>
                             <div class="col-lg-6 col-md-6 log-det">
                            <asp:GridView ID="gvSelected" runat="server" AutoGenerateColumns="False" DataKeyNames="ParticipateId" CssClass="table table-bordered tab-content table-responsive-md" OnRowCommand="gvStuList_RowCommand">
                                <Columns>
                                    <asp:BoundField DataField="ParticipateId" HeaderText="ParticipateId" ReadOnly="True" SortExpression="ParticipateId" />
                                    <asp:BoundField DataField="participateName" HeaderText="participateName" ReadOnly="True" SortExpression="participateName" />
                                    <asp:BoundField DataField="CollegeName" HeaderText="CollegeName" SortExpression="CollegeName" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Button ID="btnselect" runat="server" class="btn btn-round btn-outline-light box-de Remobox-de" Text="Remove" CommandName="deleteRow" CommandArgument='<%# Eval("ParticipateId") %>'/>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>         
                            </div>
                    </div>
                    <div class="row log-det">
                        <div class="col-md-6">
                            <asp:HyperLink ID="btncacel" runat="server" class="btn btn-round btn-outline-light box-de" Text="Cancel" NavigateUrl="~/AdminPanel/Instructor/InstructorHome.aspx" style="float:right"></asp:HyperLink>
                        </div>
                        <div class="col-md-6">
                            <asp:Button ID="btnsave" runat="server" class="btn btn-round btn-outline-light box-de" Text="Save" OnClick="btnsave_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
