<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddPromotion.aspx.cs" Inherits="ProjectBluejackCake_Group4.AddPromotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- ADD PROMOTION PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa insert new promotion.
        - Error message jika validasi salah.
         --%>
    <h3>
        Add Promotion Page
    </h3>
    <div>
        Welcome to the Add Promotion Page.<br />
        You can insert a new promotion by filling the form here:<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>Title:</td>
                <td><asp:TextBox ID="txtTitle" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Description:</td>
                <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Discount:</td>
                <td><asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnAddPromotion" runat="server" Text="Add Promotion"/></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Label ID="erMessage" runat="server" Text=""></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2"><asp:Button ID="btnBack" runat="server" Text="Back to Promotion page"/></td>
            </tr>
        </table>
    </div>
</asp:Content>
