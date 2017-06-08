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
        <asp:GridView ID="viewAllCart" runat="server" AutoGenerateColumns="false" OnRowDeleting="viewAllCart_RowDeleting">
            <Columns>
                <asp:BoundField DataField="cakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="cakePrice" HeaderText="Cake Price" />
                <asp:BoundField DataField="chocPlat" HeaderText="Chocolate Plate Greeting" />
                <asp:BoundField DataField="proTitle" HeaderText="Promotion" />
                <asp:BoundField DataField="proDiscount" HeaderText="Discount" />
                <asp:BoundField DataField="subTotal" HeaderText="Sub Total" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Remove" />
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <div>
        Grand Total: <asp:TextBox ID="txtGrandTotal" runat="server" Text="" ReadOnly="true"></asp:TextBox>
    </div>
    <br /><br />
    <div>
        <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" onclick="btnCheckOut_Click"/>
    </div>
    <div>
        <asp:Label ID="erMessage" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
