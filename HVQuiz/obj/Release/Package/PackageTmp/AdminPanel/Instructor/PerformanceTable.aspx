<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Form.Master" AutoEventWireup="true" CodeBehind="PerformanceTable.aspx.cs" Inherits="HVQuiz.AdminPanel.Instructor.PerformanceTable" %>
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
                            <asp:Button ID="btnselectall" runat="server" class="btn btn-round btn-outline-light box-de" Text="Back" OnClick="btnBack_Click"/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-lg-12 col-md-12 log-det">
                            <asp:GridView ID="gvStuList" runat="server" AutoGenerateColumns="False" DataKeyNames="ParticipateId" CssClass="table table-bordered table-hover tab-content table-responsive-md">
                                <Columns>
                                    <asp:BoundField DataField="Rank" HeaderText="Rank" SortExpression="Rank" />
                                    <asp:BoundField DataField="participateName" HeaderText="participateName" ReadOnly="True" SortExpression="participateName" />
                                    <asp:BoundField DataField="Percentage" HeaderText="Percentage" ReadOnly="True" SortExpression="Percentage" />
                                    <asp:BoundField DataField="CollegeName" HeaderText="CollegeName" SortExpression="CollegeName" />
                                </Columns>
                            </asp:GridView>         
                            </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
