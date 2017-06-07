<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Cake_Page.aspx.cs" Inherits="ProjectBluejackCake_Group4.Cake_Page" %>
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
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" Visible="true">
            <ContentTemplate>
                <asp:GridView ID="ViewAllCake" runat="server" AutoGenerateColumns="false" OnRowDeleting="ViewAllCake_RowDeleting">
                    <Columns>
                        <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                        <asp:BoundField DataField="Picture" HeaderText="Cake Picture" />
                        <asp:BoundField DataField="Stock" HeaderText="Cake Stock" />
                        <asp:BoundField DataField="Price" HeaderText="Cake Price" />
                        <asp:ButtonField ButtonType="Button" Text="Add To Cart" CommandName="Select"/>
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" /> 
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button CommandArgument='<%# Eval("CakeName")%>' UseSubmitBehavior="false" 
                                    ID="btnAddToCart" runat="server" Text="Add To Cart" OnCommand="btnAddToCart_Command"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    </div>
    <asp:Button ID="btnViewCart" runat="server" Text="View Cart" onclick="btnViewCart_Click"/>
    <div>
        <%-- Validasi supaya keliatan oleh admin doang --%>  
        <asp:Button ID="btnAddCake" runat="server" Text="Add Cake" Onclick="btnAddCake_Click" CausesValidation="false"/>
        <asp:Button ID="btnUpdateCake" runat="server" Text="Update Cake"  onclick="btnUpdateCake_Click" CausesValidation="false"/>
    </div>
    

    <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
</asp:Content>

