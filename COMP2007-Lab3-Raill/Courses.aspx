<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="COMP2007_Lab3_Raill.Courses" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-offset-2 col-md-8">
                <h1>Course List</h1>
                <asp:GridView runat="server" CssClass="table table-bordered table-striped table-hover"
                     ID="CoursesGridView" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField DataField="CourseID" HeaderText="Course ID" Visible="true" />
                        <asp:BoundField DataField="Title" HeaderText="Course Name" Visible="true" />
                        <asp:BoundField DataField="Credits" HeaderText="Credits" Visible="true" />
                        <asp:BoundField DataField="DepartmentID" HeaderText="Department ID" Visible="true" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>

</asp:Content>
