﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NavBar.ascx.cs" Inherits="COMP2007_Lab3_Raill.NavBar" %>
  <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <!-- Brand and toggle get grouped for better mobile display -->
    <div class="navbar-header">
      <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
        <span class="sr-only">Toggle navigation</span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="Default.aspx"><i class="fa fa-graduation-cap fa-lg"></i> CONTOSO UNIVERSITY</a>
    </div>

    <!-- Collect the nav links, forms, and other content for toggling -->
    <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
      <ul class="nav navbar-nav navbar-right">
        <li id="home" runat="server"><a href="Default.aspx"><i class="fa fa-home fa-lg"></i> Home</a></li>
          <li id="students" runat="server"><a href="Students.aspx"><i class="fa fa-users fa-lg"></i> Students</a></li>
          <li id="courses" runat="server"><a href="Courses.aspx"><i class="fa fa-book fa-lg"></i> Courses</a></li>
          <li id="departments" runat="server"><a href="Departments.aspx"><i class="fa fa-building-o fa-lg"></i> Departments</a></li>
        <li id="contact" runat="server"><a href="Contact.aspx"><i class="fa fa-phone fa-lg"></i> Contact</a></li>

      </ul>
    </div><!-- /.navbar-collapse -->
  </div><!-- /.container-fluid -->
</nav> 