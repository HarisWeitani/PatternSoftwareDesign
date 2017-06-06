<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ViewCustomer.aspx.cs" Inherits="ProjectBluejackCake_Group4.ViewCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- VIEW CUSTOMER PAGE NOTE:
        - Accessible by admin only.
        - Name, Email, DOB, Phone, Address.
        - Delete selected customer.
        -
        - PENTING: gw gk tau admin data tampilin juga atau kgk, ini cuma ngide doang.
        -
    --%>
    <h3>View Customer Page
    </h3>
    <div>
        Welcome to the View Customer page.<br />
        Here you can view and delete CUSTOMER data (Admin data not included).<br />
        <br />
    </div>
    <div>
        <asp:GridView ID="viewCustomerGrid" runat="server" AutoGenerateColumns="false" OnRowDeleting="viewCustomer_RowDeleting">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Customer Name" />
                <asp:BoundField DataField="Email" HeaderText="Customer Email" />
                <asp:BoundField DataField="DOB" HeaderText="Customer Date of Birth" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Customer Phone" />
                <asp:BoundField DataField="Address" HeaderText="Customer Address" />
                <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
            </Columns>
        </asp:GridView>

        <br />
        <br />

        <asp:Label ID="lblErr" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
    </div>
</asp:Content>
