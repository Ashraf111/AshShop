<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="Add_ProductUI.aspx.cs" Inherits="AshShop.admin.Add_ProductUI" %>

<asp:Content ID="Content1" ContentPlaceHolderID="adminc1" runat="server">
    <h3>Add Product</h3>
    <table>
        <tr>
            <td>Product Name
            </td>
            <td>
                <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Product Description
            </td>
            <td>
                <asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Product Price
            </td>
            <td>
                <asp:TextBox ID="txtProdutPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Product Quntity
            </td>
            <td>
                <asp:TextBox ID="txtProductQuntity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Product Images
            </td>
            <td>
                <asp:FileUpload ID="fileUploadProduct" runat="server" />
            </td>
        </tr>
                <tr>
            <td>Product Category
            </td>
            <td>
                <asp:DropDownList ID="DropDownListProductCategory" runat="server">
                    
                </asp:DropDownList>
            </td>
        </tr>
        <tr>

            <td>
                <asp:Button ID="btnAddProduct" runat="server" Text="Add Product" OnClick="btnAddProduct_Click" />
            </td>
            <td>
                <asp:Label ID="lblInsertProduct" runat="server" Text=""></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
