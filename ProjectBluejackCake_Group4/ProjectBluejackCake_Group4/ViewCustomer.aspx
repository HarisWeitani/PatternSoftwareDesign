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
    <h3>
        View Customer Page
    </h3>
    <div>
        Welcome to the View Customer page.<br />
        Here you can view and delete CUSTOMER data (Admin data not included).<br /><br />
    </div>
    <div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
    </div>
</asp:Content>
