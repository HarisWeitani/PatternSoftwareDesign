<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ProjectBluejackCake_Group4.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- CART PAGE NOTE:
        - Accessible by customer only.
        - Cake Name, Cake Price, Chocolate Plate Greeting, Promotion (obtained from Promotion’s title), Discount, Sub Total (Cake Price – Discount), and Grand Total (sum of all Sub Totals).
        - Bisa remove cake.
        - Check Out Button: cart data masuk database, update cake stock, cart data dihapus.
         --%>
    <h3>
        Cart Page
    </h3>
    <div>
        Welcome to the Cart page.<br />
        Here you can view, remove, and check out all the data in the cart.<br /><br />
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" />
    </div>
</asp:Content>
