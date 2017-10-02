<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="AshShop.user.UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <table>
        <tr>
            <td>Email:
            </td>
            <td>
                <asp:TextBox ID="txtLoginEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:
            </td>
            <td>
                <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>

            <td colspan="2" align="center">
                <asp:Button ID="btnUserLogin" runat="server" Text="Login" OnClick="btnUserLogin_Click" />
            </td>
        </tr>
                <tr>

            <td colspan="2" align="center">
                <asp:Label ID="lblLoginMessage" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
