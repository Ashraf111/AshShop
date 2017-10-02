<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="ViewCartUI.aspx.cs" Inherits="AshShop.user.ViewCartUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <asp:DataList ID="DataListViewCart" runat="server">
        <HeaderTemplate>
            <table border="1">
                <tr>
                    <th>Product Image</th>
                    <th>Product Name</th>
                    <th>Product Description</th>
                    <th>Product Price</th>
                    <th>Product Quantity</th>
                    <th>Delete Cart</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <img src="<%#Eval("ProductImage") %>" style="width: 100px; height: 100px;" />
            <td><%#Eval("ProductName") %></td>

            <td><%#Eval("ProductDescription") %></td>

            <td><%#Eval("ProductPrice") %></td>

            <td><%#Eval("ProductQuntity") %></td>


            <td><a href="DeleteCart.aspx?id=<%#Eval("CookiesId") %>">Delete</a></td>



        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>

    </asp:DataList>
    <br/>
    <p align="center">
    <asp:Label ID="lblPaymentAmount" runat="server" Text=""></asp:Label>
        <br/>
        <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" OnClick="btnCheckOut_Click" />
        </p>
</asp:Content>
