<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CakePage.aspx.cs" Inherits="ProjectBluejackCake_Group4.Cake" %>
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
                <asp:GridView ID="ViewAllCake" runat="server" AutoGenerateColumns="false" OnRowDeleting="ViewAllCake_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                        <asp:BoundField DataField="CakePicture" HeaderText="Cake Picture" />
                        <asp:BoundField DataField="CakeStock" HeaderText="Cake Stock" />
                        <asp:BoundField DataField="CakePrice" HeaderText="Cake Price" />
                        <asp:ButtonField ButtonType="Button" CommandName="AddToCart" Text="Add To Cart"/>
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" /> 
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    </div>
    <asp:Button ID="btnViewCart" runat="server" Text="View Cart" onclick="btnViewCart_Click"/>
    <div>
        <%-- Validasi supaya keliatan oleh admin doang --%>
        <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" Onclick="btnAddCake_Click"/>
        <asp:Button ID="btnUpdateCake" runat="server" Text="Update Cake"  onclick="btnUpdateCake_Click"/>
    </div>
    

    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
</asp:Content>
