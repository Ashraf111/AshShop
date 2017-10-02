<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UserRegistrationUI.aspx.cs" Inherits="AshShop.user.UserRegistrationUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    
    <table align="center" style="width: 92%; border-color: #339933; height: 588px;">
        <tr>
            <td style="width: 301px">First Name</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtFirstName" runat="server" Width="513px" Height="36px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Last Name</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtLastName" runat="server" Width="514px" Height="36px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Email</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtEmail" runat="server" Width="513px" Height="39px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Adress</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="518px" Height="95px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">City</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtCity" runat="server" Width="516px" Height="34px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Mobile Number</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtMobileNumber" runat="server" Width="516px" Height="35px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Password</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtPassword" runat="server" Width="517px" Height="30px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 301px; height: 54px;">Confirm Password</td>
            <td style="width: 423px; height: 54px;">
                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="517px" Height="32px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Button ID="btnRegister" runat="server" Text="Register" Height="38px" OnClick="btnRegister_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2" style="text-align: center;">
                <asp:Label ID="lblRegistration" runat="server"></asp:Label>
            </td>
        </tr>


    </table>
    
</asp:Content>
