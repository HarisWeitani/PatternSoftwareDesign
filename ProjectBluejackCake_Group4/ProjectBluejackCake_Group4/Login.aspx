<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectBluejackCake_Group4.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Login Page
    </h3>
    <div>
        Welcome to the Login Page.<br />
        Please fill your Email and Password to login:<br />
        <br />
    </div>
    <div>
        <table>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="ckRemember" runat="server" />
                    Remember Me</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
