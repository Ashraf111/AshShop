<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UserAccount.aspx.cs" Inherits="AshShop.user.UserAccount" %>
<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
        <table>
        <tr>
            <td>First Name</td>
            <td>
                
            <asp:Label ID="txtFirstName" runat="server" Text=""></asp:Label>
        </tr>
        <tr>
            <td>Last Name</td>
            <td>
               
            <asp:Label ID="txtLastName" runat="server" Text=""></asp:Label>
        </tr>
        <tr>
            <td>Address</td>
            <td>
               
            <asp:Label ID="txtAddress" runat="server" Text=""></asp:Label>
        </tr>
        <tr>
            <td>City</td>
            <td>
               
            <asp:Label ID="txtCity" runat="server" Text=""></asp:Label>
        </tr>
        <tr>
            <td>Mobile Number</td>
            <td>
               
            <asp:Label ID="txtMobileNumber" runat="server" Text=""></asp:Label>
        </tr>


    </table>
</asp:Content>
