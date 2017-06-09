<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="ProjectBluejackCake_Group4.ForgotPassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Forgot Password Page
    </h3>
    <div>
        Welcome to the Forgot Password Page.<br />
        If you forgot your password, please fill your email below to receive new password:<br />
        <br />
    </div>
    <div>
        <table>
            <tr>
                <td>Email:</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
