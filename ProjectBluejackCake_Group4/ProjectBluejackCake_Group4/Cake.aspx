<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cake.aspx.cs" Inherits="ProjectBluejackCake_Group4.Cake" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- CAKE PAGE NOTE:
        - Accessible by all users.
        - Cake Name, Cake Picture, Stock, Price.
        - User bisa buy cake (input chocolate plate greeting, promotion, sama add to cart button).
        - Error Message jika user gk input chocolate plate greeting atau lebih dari 10 char, gk input promotion.
        - Kalo klik Add to Cart maka data masuk ke Cart.
        - Admin bisa Add Cake, Update Cake, Delete Cake.
         --%>
    <h3>
        Cake Page
    </h3>
    <div>
        Welcome to the Cake Page.<br />
        Here you can see all the cake in Bluejack Cake Shop.<br />
        Only registered customer can buy cake.<br /><br />
    </div>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="false">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    </div>
    <div>
        <%-- Validasi supaya keliatan oleh admin doang --%>
        <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" />
    </div>
</asp:Content>
