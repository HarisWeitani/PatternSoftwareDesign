<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="PromotionPage.aspx.cs" Inherits="ProjectBluejackCake_Group4.PromotionPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3>Promotion Page
    </h3>
    <div>
        Welcome to the Promotion Page.<br />
        Here you can see all the promotion available in Bluejack Cake Shop.<br />
        <br />
    </div>
    <div>
        <asp:GridView ID="viewPromotion" runat="server" AutoGenerateColumns="false" OnRowDeleting="viewPromotion_RowDeleting" OnRowUpdating="viewPromotion_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Description" HeaderText="Promotion Description" />
                <asp:BoundField DataField="Discount" HeaderText="Discount" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
                <asp:ButtonField ButtonType="Button" CommandName="Update" Text="Update" />
            </Columns>
        </asp:GridView>
    </div>

    <br />

    <div>
        <%-- Validasi supaya keliatan oleh admin doang --%>
        <asp:Label ID="lblErrProm" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAddPromotion" runat="server" Text="Add Promotion" OnClick="btnAddPromotion_Click" CausesValidation="false" />
    </div>
</asp:Content>
