<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddPromotion.aspx.cs" Inherits="ProjectBluejackCake_Group4.AddPromotion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- ADD PROMOTION PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa insert new promotion.
        - Error message jika validasi salah.
    --%>
    <h3>Add Promotion Page
    </h3>
    <div>
        Welcome to the Add Promotion Page.<br />
        You can insert a new promotion by filling the form here:<br />
        <br />
    </div>
    <div>
        <table>
            <tr>
                <td>Title:</td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" placeholder="Promotion Title"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkPromoTitle" runat="server" ControlToValidate="txtTitle" ErrorMessage="Promotion Title must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>Description:</td>
                <td>
                    <asp:TextBox ID="txtDescription" runat="server" placeholder="Promotion Description"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkDescPromo" runat="server" ControlToValidate="txtDescription" ErrorMessage="Promotion Description must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display = "Dynamic" ControlToValidate = "txtDescription" ID="chkDescPromo3" ValidationExpression = "^[\s\S]{1,20}$" runat="server" ErrorMessage="Maximum 20 characters allowed!" ForeColor="Red" Font-Italic="true"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>Discount:</td>
                <td>
                    <asp:TextBox ID="txtDiscount" runat="server" placeholder="Discount"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkDiscProm" runat="server" ControlToValidate="txtDiscount" ErrorMessage="Discount must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="chkDiscProm2" runat="server" ControlToValidate="txtDiscount" Operator="DataTypeCheck" Type="Integer"  ErrorMessage="Discount must be a number!" ForeColor="Red" Font-Italic="true"></asp:CompareValidator>
                </td>
            </tr>
        </table>

        <br />
        <br />
        <asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnAddPromotion" runat="server" Text="Add Promotion" OnClick="btnAddPromotion_Click" />
        &nbsp;&nbsp;
        <asp:Button ID="btnBack" runat="server" Text="Back to Promotion page" OnClick="btnBack_Click" />


    </div>
</asp:Content>
