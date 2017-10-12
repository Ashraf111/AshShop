<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="AshShop.user.ProductDescription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    <asp:Repeater ID="ProductDescriptionRepeater" runat="server">
        <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="productDescription">
                <div class="imageDescription">
                    <a href="#">

                        <img src="<%#Eval("ProductImage") %>" style="width: 100%; height: 100%;" alt="" />
                    </a>
                </div>
                
                <div class="product-infoDescription">
                      <h3><%#Eval("ProductName") %></h3>
                    <br/> 
                       
                      <h4><%#Eval("ProductDescription") %></h4>
                    <br/>

                    <strong>Price:<%#Eval("ProductPrice") %></strong>
                    <br/>
                    <strong>Quantity:<%#Eval("ProductQuntity") %></strong>
               </div>
                </div>
               
         
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>

    </asp:Repeater>
    <br />
    <br/>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblEnterProductText" runat="server" Text="Enter Product Amount"></asp:Label></td>
             <td>
                 <asp:TextBox ID="txtProductAmount" runat="server"></asp:TextBox></td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtProductAmount" runat="server" ErrorMessage="Number is Required" ControlToValidate="txtProductAmount"></asp:RequiredFieldValidator>
             <td><div class="btnAddToCart">
    <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" OnClick="btnAddToCart_Click" />
    </div></td>

            </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblProductAmount" runat="server" ForeColor="red" Text=""></asp:Label>
                </td>
            </tr>
    </table>
</asp:Content>

