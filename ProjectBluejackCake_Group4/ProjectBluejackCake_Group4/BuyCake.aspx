<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="BuyCake.aspx.cs" Inherits="ProjectBluejackCake_Group4.BuyCake" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3>Buy Cake</h3>
    <div>
        Welcome to the Buy Cake page.<br />
        Please fill the data below so your cake can be added to cart:<br /><br />
    </div>
    <div>
        <table>
            <tr>
                <td>Cake Name:</td>
                <td>
                    <asp:Label ID="lblCakeName" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Cake Price:</td>
                <td>
                    <asp:Label ID="lblCakePrice" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Chocolate Plate Greeting:</td>
                <td>
                    <asp:TextBox ID="txtChocPlat" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Promotion Title:</td>
                <td>
                    <asp:DropDownList ID="ddlPromotion" runat="server" OnSelectedIndexChanged="ddlPromotion_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Promotion Discount:</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <asp:Label ID="lblDiscount" runat="server" Text=""></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>Subtotal:</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:Label ID="lblSubtotal" runat="server" Text=""></asp:Label>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click"/>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="erMessage" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnBack" runat="server" Text="Back to Cake Page" OnClick="btnBack_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
