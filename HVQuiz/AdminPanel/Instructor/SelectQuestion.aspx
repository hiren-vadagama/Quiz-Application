<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="SelectQuestion.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.SelectQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContain" runat="server">
        <div class="row ">

            <div class="col-sm-12 log-det">
                <div class="text-center">
                                <asp:Label ID="lblErromsg" runat="server" CssClass="h6" ForeColor="#FF3300"></asp:Label>                           
                        </div>
                <div class="row">
                    <div class="col-md-6"></div>
                    <div class="col-md-6">
                        <div style="float:right">
                            <asp:Button ID="selectRandowm" runat="server" class="btn btn-round btn-outline-light box-de" Text="Select Random" OnClick="selectRandowm_Click"/>
                        </div>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-6 col-md-6">
                        <asp:Button ID="btndeselectall" runat="server" class="btn btn-round btn-outline-light box-de" Text="Reset All" OnClick="btnDeselectall_Click"/>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-6 col-md-6 log-det" style="overflow:scroll; height: 550px;">
                        <asp:GridView ID="gvStuList" runat="server" AutoGenerateColumns="False" DataKeyNames="Qid" CssClass="table table-bordered tab-content table-responsive-md table-responsive-lg" OnRowCommand="gvStuList_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="Qid" HeaderText="Qid" ReadOnly="True" SortExpression="Qid" />
                                <asp:BoundField DataField="question" HeaderText="question" ReadOnly="True" SortExpression="question" />
                                <asp:BoundField DataField="correct_answer" HeaderText="correct_answer" SortExpression="correct_answer" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="btnselect" runat="server" class="btn btn-round btn-outline-light box-de" Text="Select" CommandName="selectRow" CommandArgument='<%# Eval("Qid") %>'/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>         
                        </div>
                            <div class="col-lg-6 col-md-6 log-det" style="overflow:scroll; height: 550px;">
                        <asp:GridView ID="gvSelected" runat="server" AutoGenerateColumns="False" DataKeyNames="Qid" CssClass="table table-bordered tab-content table-responsive-md" OnRowCommand="gvStuList_RowCommand">
                            <Columns>
                                <asp:BoundField DataField="Qid" HeaderText="Qid" ReadOnly="True" SortExpression="Qid" />
                                <asp:BoundField DataField="question" HeaderText="question" ReadOnly="True" SortExpression="question" />
                                <asp:BoundField DataField="correct_answer" HeaderText="correct_answer" SortExpression="correct_answer" />
                                    <asp:TemplateField>
                                        <ItemTemplate>
                                            <asp:Button ID="btnselect" runat="server" class="btn btn-round btn-outline-light box-de Remobox-de" Text="Remove" CommandName="deleteRow" CommandArgument='<%# Eval("Qid") %>'/>
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
</asp:Content>
