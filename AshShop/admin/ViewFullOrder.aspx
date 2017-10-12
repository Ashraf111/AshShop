<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="ViewFullOrder.aspx.cs" Inherits="AshShop.admin.ViewFullOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminc1" runat="server">
    
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
                
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>

    <asp:Repeater ID="repeaterOrderDetails" runat="server">
        <HeaderTemplate>
            <table border="1.0">
                <tr>
                    <th>Product Image</th>
                    <th>Order Id</th>
                    <th>Product Name</th>
                    <th>Product Price</th>
                    <th>Product Quantity</th>
                    
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                 <td><img src="<%#Eval("ProductImage") %>" height="100px" width="100px"/> </td>
                <td><%#Eval("OrderId") %></td>
                <td><%#Eval("ProductName") %></td>
                <td><%#Eval("ProductPrice") %></td>
                <td><%#Eval("ProductQuantity") %></td>
               
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    <p>
    <asp:Label ID="lblTotalAmount" runat="server" Text=""></asp:Label>
        </p>
</asp:Content>
