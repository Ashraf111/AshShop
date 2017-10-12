<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="AshShop.user.UserLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <table>
        <tr>
            <td>Email:
            </td>
            <td>
                <asp:TextBox ID="txtLoginEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtLoginEmail" runat="server" Display="Dynamic"  ErrorMessage="Email Is Required"  ForeColor="red" ControlToValidate="txtLoginEmail"></asp:RequiredFieldValidator>
                 <%--<asp:RegularExpressionValidator ID="RequiredFieldValidatortxtEmailLoginFormed"  runat="server" Display="Dynamic" ErrorMessage="The email is not well formed"  ForeColor="red" ControlToValidate="txtLoginEmail" ValidationExpresion="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,6}$"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Password:
            </td>
            <td>
                <asp:TextBox ID="txtLoginPassword" runat="server" TextMode="Password"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtLoginPassword" runat="server" ErrorMessage="Password Is Required"  ForeColor="red" ControlToValidate="txtLoginPassword"></asp:RequiredFieldValidator>
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
