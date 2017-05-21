<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ProjectBluejackCake_Group4.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- CHANGE PASSWORD PAGE NOTE:
        - Accessible by customer & admin only.
        - Error Message jika validasi salah.
        - New Password: 2 random number + 2 random alphabet + 2 char dari nama customer.
        - Replace password di database
         --%>
    <h3>
        Change Password Page
    </h3>
    <div>
        Welcome to the Change Password Page.<br />
        If you don't like your current password, you can change it here:<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>Old Password:</td>
                <td><asp:TextBox ID="txtOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>New Password:</td>
                <td><asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Confirm Password:</td>
                <td><asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnSubmit" runat="server" Text="Submit"/></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red"></asp:Label></td>
            </tr>
        </table>
    </div>
</asp:Content>
