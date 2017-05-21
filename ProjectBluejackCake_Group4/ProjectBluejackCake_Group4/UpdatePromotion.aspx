<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdatePromotion.aspx.cs" Inherits="ProjectBluejackCake_Group4.UpdatePromotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- UPDATE PROMOTION PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa update promotion.
        - Error message jika validasi salah.
         --%>
    <h3>
        Update Promotion Page
    </h3>
    <div>
        Welcome to the Update Promotion Page.<br />
        You can update the old promotion by filling the form here:<br /><br />
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
                <td colspan="2"><asp:Button ID="btnUpdatePromotion" runat="server" Text="Update Promotion"/></td>
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
