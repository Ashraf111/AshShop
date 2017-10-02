<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="AddCategory.aspx.cs" Inherits="AshShop.admin.AddCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="adminc1" runat="server">
    <table>
        <tr>
            <td>Enter New Category:</td>
             <td>
                 <asp:TextBox ID="txtAddCategory" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
            
             <td colspan="2">
                 <asp:Button ID="btnAddCategory" runat="server" Text="Add Category" OnClick="btnAddCategory_Click" />
               </td>
        </tr>
                        <tr>
            
             <td colspan="2">
                 <asp:Label ID="lblCategoryAddMessage" runat="server" Text=""></asp:Label>
               </td>
        </tr>
    </table>
    <asp:DataList ID="DataListDeleteProductCategory" runat="server">
        <HeaderTemplate>
            <table>
        </HeaderTemplate>
        
        <ItemTemplate>
            <td><%#Eval("ProductCategoryName") %></td>
             <td><a href="DeleteCategory.aspx?category=<%#Eval("ProductCategoryName") %>">Delete</a></td>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:DataList>

</asp:Content>
