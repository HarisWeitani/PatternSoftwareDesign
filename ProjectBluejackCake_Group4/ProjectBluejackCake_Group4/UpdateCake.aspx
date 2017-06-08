<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateCake.aspx.cs" Inherits="ProjectBluejackCake_Group4.UpdateCake" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%-- UPDATE CAKE PAGE NOTE:
        - Accessible by admin only.
        - Admin bisa update cake.
        - Error message jika validasi salah.
        - benerin supaya gk perlu upload2 picture terus (optional).
    --%>
    <h3>Update Cake</h3>
    <div>
        Welcome to the Update Cake page.<br />
        You can update the old cake by filling the form here:<br />
        NOTE: YOU NEED TO UPLOAD CAKE PICTURE AGAIN<br />
        <br />
    </div>
    <div>
        <asp:GridView ID="viewUpdateCake" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="CakeName" HeaderText="Cake Name" />
                <asp:BoundField DataField="Price" HeaderText="Cake Price" />
                <asp:BoundField DataField="Stock" HeaderText="Cake Stock" />
                <asp:ImageField DataImageUrlField="Picture" HeaderText="Pic" ControlStyle-Width="100" ControlStyle-Height="100"></asp:ImageField>
            </Columns>
        </asp:GridView>

        <br />
        <br />

        <table>

            <tr>
                <td>Old Cake Name:</td>
                <td>
                    <asp:TextBox ID="txtCakeNameOld" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkCakeNameOld" runat="server" ControlToValidate="txtCakeNameOld" ErrorMessage="Cake name must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>New Cake Name:</td>
                <td>
                    <asp:TextBox ID="txtCakeName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkCakeName" runat="server" ControlToValidate="txtCakeName" ErrorMessage="Cake name must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>New Cake Price:</td>
                <td>
                    <asp:TextBox ID="txtCakePrice" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkCakePrice" runat="server" ControlToValidate="txtCakePrice" ErrorMessage="Cake price must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>New Cake Stock:</td>
                <td>
                    <asp:TextBox ID="txtCakeStock" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="chkCakeStock" runat="server" ControlToValidate="txtCakeStock" ErrorMessage="Cake stock must be filled!" ForeColor="Red" Font-Italic="true"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator Display="Dynamic" ID="chkCakeStock2" runat="server" ControlToValidate="txtCakeStock" ValidationExpression="^[1-9][0-9]*$" ErrorMessage="Value must be greater than 0!" ForeColor="Red" Font-Italic="true"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>New Cake Picture:</td>
                <td>
                    <asp:FileUpload ID="uplCakePicture" runat="server" />
                </td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Label ID="erMessage" runat="server" Text="" ForeColor="Red" Font-Bold="true" Font-Italic="true"></asp:Label></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnUpdateCake" runat="server" Text="Update Cake" OnClick="btnUpdateCake_Click" /></td>
            </tr>

            <tr>
                <td colspan="2">
                    <asp:Button ID="btnBack" runat="server" Text="Back to Cake page" OnClick="btnBack_Click" CausesValidation="false" /></td>
            </tr>
        </table>
    </div>
</asp:Content>
