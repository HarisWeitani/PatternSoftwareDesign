<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Promotion.aspx.cs" Inherits="ProjectBluejackCake_Group4.Promotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- PROMOTION PAGE NOTE:
        - Accessible by admin only.
        - Show all promotion created by admin.
        - Promotion Title, Description, Discount.
        - Button Add Promotion, Update Promotion, Delete Promotion.
         --%>
    <h3>
        Promotion Page
    </h3>
    <div>
        Welcome to the Promotion Page.<br />
        Here you can see all the promotion available in Bluejack Cake Shop.<br /><br />
    </div>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    <div>
        <%-- Validasi supaya keliatan oleh admin doang --%>
        <asp:Button ID="btnAddPromotion" runat="server" Text="Add Promotion" />
    </div>
</asp:Content>
