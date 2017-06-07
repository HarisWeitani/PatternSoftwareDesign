<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectBluejackCake_Group4.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h3>Home Page
    </h3>
    <div>
        Welcome to our website! Here you can find all sort of cake that you like and our newest promotion! Have a nice day!<br />
        <br />
        Our newest promotion:<br />

        <br />

        <table>
            <tr>
                <td>Title</td>
                <td>:</td>
                <td>
                    <asp:Label ID="lblTitle" runat="server" Text=""></asp:Label>
                </td>
            </tr>

            <tr>
                <td>Description</td>
                <td>:</td>
                <td>
                    <asp:Label ID="lblDesc" runat="server" Text=""></asp:Label>
                </td>
            </tr>

            <tr>
                <td>Discount</td>
                <td>:</td>
                <td>
                    <asp:Label ID="lblDiscount" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>

        <br />
        <br />
        You can find all our cake menu in 'Cake' page by clicking the link on the navigation panel.
    </div>
</asp:Content>
