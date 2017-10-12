<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLoginUI.aspx.cs" Inherits="AshShop.admin.AdminLoginUI" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Admin Login</title>




    <link rel="stylesheet" href="logincss/style.css">
</head>

<body>
    <form id="adminLoginf1" runat="server">


        <header>Login</header>
        <label>Username <span>*</span></label>
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br/>
        <label>Password <span>*</span></label>
        <asp:TextBox ID="txtUserPassword" runat="server"></asp:TextBox>
        <br/>
        <asp:Button ID="btnAdminLogin" runat="server" Text="Login" OnClick="btnAdminLogin_Click" />
        <br/>
        <asp:Label ID="lblAdminLoginMessage" runat="server" Text=""></asp:Label>
        <br/>
    </form>

</body>
</html>
