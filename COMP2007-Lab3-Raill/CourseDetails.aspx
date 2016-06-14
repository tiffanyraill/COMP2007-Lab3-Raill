<%@ Page Title="CourseDetails" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CourseDetails.aspx.cs" Inherits="COMP2007_Lab3_Raill.CourseDetails" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
     <div class="container">
        <div class="row">
            <div class="col-md-offset-3 col-md-6">
                <h1>Course Details</h1>
                <h5>All Fields Are Required</h5>
                <br /> 
                <div class="form-group">
                    <label class="control-label" for="TitleTextBox">Course Name</label>
                    <asp:TextBox runat="server" CssClass="form-control" ID="TitleTextBox" placeholder="Course Name" required="true"></asp:TextBox>
                </div>  
                 
                <div class="text-right">
                    <asp:Button Text="Cancel" ID="CancelButton" CssClass="btn btn-warning btn-lg" runat="server"
                         UseSubmitBehavior="false" CausesValidation="false" OnClick="CancelButton_Click" />
                    <asp:Button Text="Save" ID="Savebutton" CssClass="btn btn-primary btn-lg" runat="server" OnClick="Savebutton_Click" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
