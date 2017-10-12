<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="UserRegistrationUI.aspx.cs" Inherits="AshShop.user.UserRegistrationUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="userc1" runat="server">
    
    <table align="center" style="width: 92%; border-color: #339933; height: 588px;">
        <tr>
            <td style="width: 301px">First Name</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtFirstName" runat="server" Width="513px" Height="36px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtFirstName" runat="server" ErrorMessage="First Name Is Required"  ForeColor="red" ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Last Name</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtLastName" runat="server" Width="514px" Height="36px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtLastName" runat="server" ErrorMessage="Last Name Is Required"  ForeColor="red" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Email</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtEmail" runat="server" Width="513px" Height="39px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtEmail" runat="server" Display="Dynamic" ErrorMessage="Email Is Required" ForeColor="red" ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
               <%-- <asp:RegularExpressionValidator ID="RequiredFieldValidatortxtEmailFormed" runat="server" Display="Dynamic" ErrorMessage="The email is not well formed"  ForeColor="red" ControlToValidate="txtEmail" ValidationExpresion="^[\w-\.]{1,}\@([\da-zA-Z-]{1,}\.){1,}[\da-zA-Z-]{2,6}$"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Adress</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Width="518px" Height="95px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtAddress" runat="server" ErrorMessage="Address Is Required"  ForeColor="red" ControlToValidate="txtAddress"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">City</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtCity" runat="server" Width="516px" Height="34px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtCity" runat="server" ErrorMessage="city Is Required"  ForeColor="red" ControlToValidate="txtCity"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Mobile Number</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtMobileNumber" runat="server" Width="516px" Height="35px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtMobileNumber" runat="server" ErrorMessage="Mobile number Is Required"  ForeColor="red" ControlToValidate="txtMobileNumber"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px">Password</td>
            <td style="width: 423px">
                <asp:TextBox ID="txtPassword" runat="server" Width="517px" Height="30px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtPassword" runat="server" ErrorMessage="Password Is Required"  ForeColor="red" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 301px; height: 54px;">Confirm Password</td>
            <td style="width: 423px; height: 54px;">
                <asp:TextBox ID="txtConfirmPassword" runat="server" Width="517px" Height="32px" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxtConfirmPassword" runat="server" ErrorMessage="Confirm password Is Required"  ForeColor="red" ControlToValidate="txtConfirmPassword"></asp:RequiredFieldValidator>
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
