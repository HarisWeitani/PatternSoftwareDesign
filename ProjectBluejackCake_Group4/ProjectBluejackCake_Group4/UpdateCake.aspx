<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateCake.aspx.cs" Inherits="ProjectBluejackCake_Group4.UpdateCake" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- UPDATE CAKE PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa update cake.
        - Error message jika validasi salah.
        - benerin supaya gk perlu upload2 picture terus (optional).
         --%>
    <h3>Update Cake</h3>
    <div>
        Welcome to the Update Cake page.<br />
        You can update the old cake by filling the form here:<br />
        NOTE: YOU NEED TO UPLOAD CAKE PICTURE AGAIN<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>New Cake Name:</td>
                <td><asp:TextBox ID="txtCakeName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>New Cake Price:</td>
                <td><asp:TextBox ID="txtCakePrice" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>New Cake Stock:</td>
                <td><asp:TextBox ID="txtCakeStock" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>New Cake Picture:</td>
                <td><asp:FileUpload ID="uplCakePicture" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnUpdateCake" runat="server" Text="Update Cake"/></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="erMessage" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnBack" runat="server" Text="Back to Cake page"/></td>
            </tr>
        </table>
    </div>
</asp:Content>
