<%@ Page Title="Departments" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Departments.aspx.cs" Inherits="COMP2007_Lab3_Raill.Departments" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Department List</h1>
                <a href="DepartmentDetails.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i> Add Department</a>
                <asp:GridView runat="server"  CssClass="table table-bordered table-striped table-hover"
                     ID="DepartmentsGridView" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" Visible="true" />
                        <asp:BoundField DataField="Name" HeaderText="Department Name" Visible="true" />
                        <asp:BoundField DataField="Budget" HeaderText="Budget" Visible="true" DataFormatString="{0:C}" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
