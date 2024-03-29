﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cake_Page.aspx.cs" Inherits="ProjectBluejackCake_Group4.Cake_Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Cake Page
    </h3>
    <div>
        Welcome to the Cake Page.<br />
        Here you can see all the cake in Bluejack Cake Shop.<br />
        Only registered customer can buy cake.<br />
        <br />
    </div>
    <%-- for admin --%>
    <div>
        <asp:GridView ID="ViewAllCakeAdmin" runat="server" AutoGenerateColumns="false" OnRowDeleting="ViewAllCake_RowDeleting" OnRowUpdating="ViewAllCakeAdmin_RowUpdating">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Price" HeaderText="Cake Price" />
                <asp:BoundField DataField="Stock" HeaderText="Cake Stock" />
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100"></asp:ImageField>
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <%-- for Strangers --%>
    <div>
        <asp:GridView ID="ViewAllCakeStrangers" runat="server" AutoGenerateColumns="false" OnRowDeleting="ViewAllCake_RowDeleting">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Price" HeaderText="Cake Price" />
                <asp:BoundField DataField="Stock" HeaderText="Cake Stock" />
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100"></asp:ImageField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <%-- for Customer --%>
    <div>
        <asp:GridView ID="ViewAllCakeCustomer" runat="server" AutoGenerateColumns="false" OnRowDeleting="ViewAllCake_RowDeleting">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Price" HeaderText="Cake Price" />
                <asp:BoundField DataField="Stock" HeaderText="Cake Stock" />
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100"></asp:ImageField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button CommandArgument='<%# Eval("CakeName")%>' UseSubmitBehavior="false"
                            ID="btnAddToCart" runat="server" Text="Add To Cart" OnCommand="btnAddToCart_Command" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />
    </div>
    <br />
    <br />
    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
    <br />
    <br />
    <asp:Button ID="btnViewCart" runat="server" Text="View Cart" OnClick="btnViewCart_Click" CausesValidation="false" />
    <br />
    <br />

    <%-- Validasi supaya keliatan oleh admin doang --%>
    <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" OnClick="btnAddCake_Click" CausesValidation="false" Visible="false" />
    &nbsp;&nbsp;
    <asp:Button ID="btnUpdateCake" runat="server" Text="Update Cake" OnClick="btnUpdateCake_Click" CausesValidation="false" Visible="false" />


</asp:Content>

