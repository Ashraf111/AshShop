<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="DisplayProduct.aspx.cs" Inherits="AshShop.user.DisplayProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <asp:Repeater ID="ProductRepeater" runat="server">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <ItemTemplate>
            <li class="product"><a href="ProductDescription.aspx?id=<%#Eval("id") %>">
                <img src="<%#Eval("ProductImage") %>" style="width: 100%; height: 100%;" alt="" /></a>
                <div class="product-info">
                    <h3><%#Eval("ProductName") %></h3>
                    <div class="product-desc">
                        <h4><%#Eval("ProductDescription") %></h4>

                        <strong class="price">Price:<%#Eval("ProductPrice") %></strong>
                        <strong class="price">Quantity:<%#Eval("ProductQuntity") %></strong>
                    </div>
                </div>
            </li>
        </ItemTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>

    </asp:Repeater>



</asp:Content>
