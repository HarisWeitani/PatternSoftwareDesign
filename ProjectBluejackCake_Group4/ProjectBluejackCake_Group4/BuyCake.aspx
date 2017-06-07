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
                    <asp:TextBox ID="txtCakeName" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Cake Price:</td>
                <td>
                    <asp:TextBox ID="txtCakePrice" runat="server" ReadOnly="true"></asp:TextBox>
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
                    <asp:DropDownList ID="ddlPromotion" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Promotion Discount:</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtDiscount" runat="server" ReadOnly="true"></asp:TextBox>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                <td>Subtotal:</td>
                <td>
                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                        <ContentTemplate>
                            <asp:TextBox ID="txtSubtotal" runat="server" ReadOnly="true"></asp:TextBox>
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
                    <asp:Button ID="btnBack" runat="server" Text="Cancel Add To Cart, back to Cake Page" OnClick="btnBack_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
