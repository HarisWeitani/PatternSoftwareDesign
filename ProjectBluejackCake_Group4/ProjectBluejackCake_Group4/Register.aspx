<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ProjectBluejackCake_Group4.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- REGISTER PAGE NOTE:
        - Accessible by guest only.
        - Register sebagai customer saja.
        - Error Message jika validasi salah.
         --%>
    <h3>
        Login Page
    </h3>
    <div>
        Welcome to the Register Page.<br />
        Please fill your Profile data to login as Bluejack Customer:<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>Name:</td>
                <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Password:</td>
                <td><asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Confirm Password:</td>
                <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Date of Birth:</td>
                <td><asp:TextBox ID="txtDOB" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Phone Number:</td>
                <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Address:</td>
                <td><asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnRegister" runat="server" Text="Register"/></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
