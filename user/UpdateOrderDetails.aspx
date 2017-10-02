<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UpdateOrderDetails.aspx.cs" Inherits="AshShop.user.UpdateOrderDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <table>
        <tr>
            <td>First Name</td>
            <td>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>City</td>
            <td>
                <asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Mobile Number</td>
            <td>
                <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnUpdateOrder" runat="server" Text="Update Order And Continue" OnClick="btnUpdateOrder_Click" /></td>
      
        </tr>
                <tr>
            <td colspan="2">
                <asp:Label ID="lblUpdateOrderMessage" runat="server" Text=""></asp:Label></td>
      
        </tr>
    </table>
</asp:Content>
