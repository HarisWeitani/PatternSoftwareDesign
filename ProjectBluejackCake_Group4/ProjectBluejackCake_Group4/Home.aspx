<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectBluejackCake_Group4.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- HOME PAGE NOTE:
        - Accessible by all user
        - General information about Bluejack Cake
        - Newest promotion
         --%>
    <h3>
        Home Page
    </h3>
    <div>
        Welcome to our website! Here you can find all sort of cake that you like and our newest promotion! Have a nice day!<br /><br />
        Our newest promotion:<br />
        <%-- no new promotion yet --%>

        <br /><br />
        You can find all our cake menu in 'Cake' page by clicking the link on the navigation panel.
    </div>
</asp:Content>
