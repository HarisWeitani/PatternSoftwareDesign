<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCake.aspx.cs" Inherits="ProjectBluejackCake_Group4.AddCake" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- ADD CAKE PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa insert new cake.
        - Error message jika validasi salah.
         --%>
    <h3>Add Cake</h3>
    <div>
        Welcome to the Add Cake page.<br />
        You can insert a new cake by filling the form here::<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>Cake Name:</td>
                <td><asp:TextBox ID="txtCakeName" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cake Price:</td>
                <td><asp:TextBox ID="txtCakePrice" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cake Stock:</td>
                <td><asp:TextBox ID="txtCakeStock" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Cake Picture:</td>
                <td><asp:FileUpload ID="uplCakePicture" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnAddCake" runat="server" Text="Add Cake"/></td>
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
