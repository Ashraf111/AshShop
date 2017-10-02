<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="DisplayUserOrder.aspx.cs" Inherits="AshShop.user.DisplayUserOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
     <asp:Repeater ID="repeaterDisplayOrder" runat="server">
        <HeaderTemplate>
            <table border="1.0">
                <tr>
                    <th>Id</th>
                    <th>First Name</th>
                    <th>Last Name</th>
                    <th>Email</th>
                    <th>Address</th>
                    <th>City</th>
                    <th>Mobile Number</th>
                    <th>View Full Order</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("id") %></td>
                <td><%#Eval("FirstName") %></td>
                <td><%#Eval("LastName") %></td>
                <td><%#Eval("Email") %></td>
                <td><%#Eval("Address") %></td>
                <td><%#Eval("City") %></td>
                <td><%#Eval("MobileNumber") %></td>
                <td><a href="DisplayFullUserOrder.aspx?id=<%#Eval("id") %>">View Full Order</td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
</asp:Content>
