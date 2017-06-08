<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="ProjectBluejackCake_Group4.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- TRANSACTION PAGE NOTE:
        - Accessible by customer & admin only.
        - Transaction Date, Customer Name, Cake Name, Cake Price, Chocolate Plate Greeting, Promotion (obtained from Promotion’s title), Discount, and Subtotal (Cake Price - Discount).
        - Untuk admin: display data transaction semua customer.
        - Untuk customer: display data transaction dia doang.
        - For administrator and member, provide a Generate Transaction Report button. (member apaan?)
        - Generate Transaction Report Button: redirect ke Transaction Report page.
    --%>
    <h3>Transaction Page
    </h3>
    <div>
        Welcome to the Transaction page.<br />
        <%-- labelnya isinya "you" (untuk customer) atau "all the customer" (untuk admin) --%>
        Here you can view all the transaction that
        <asp:Label ID="lblTransaction" runat="server" Text=""></asp:Label>
        have made.<br />
        <br />
    </div>
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField HeaderText="Transaction Date" DataField="TransactionDate" DataFormatString="{0:MM/dd/yyyy}"></asp:BoundField>
                <asp:BoundField HeaderText="Customer Name" DataField="CustomerName"></asp:BoundField>
                <asp:BoundField HeaderText="Cake Name" DataField="CakeName"></asp:BoundField>
                <asp:BoundField HeaderText="Cake Price" DataField="CakePrice"></asp:BoundField>
                <asp:BoundField HeaderText="Chocolate Plate Greeting" DataField="ChocolatePlateGreeting"></asp:BoundField>
                <asp:BoundField HeaderText="Promotion" DataField="PromotionTitle"></asp:BoundField>
                <asp:BoundField HeaderText="Discount" DataField="PromotionDiscount"></asp:BoundField>
                <asp:BoundField HeaderText="Subtotal" DataField="SubTotal"></asp:BoundField>
            </Columns>
        </asp:GridView>
    </div>
    <div>
        <asp:Button ID="btnGenerateTransactionReport" runat="server" Text="Generate Transaction Report" OnClick="btnGenerateTransactionReport_Click"/>
    </div>
</asp:Content>
