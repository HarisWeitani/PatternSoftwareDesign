<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="ProjectBluejackCake_Group4.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- PROMOTION PAGE NOTE:
        - Accessible by customer & admin only.
        - Email, Name, DOB, Phone, Address
         --%>
    <h3>
        Profile Page
    </h3>
    <div>
        Welcome to the Promotion Page.<br />
        Here you can see your profile based on what you filled in the Registration form.<br /><br />
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
