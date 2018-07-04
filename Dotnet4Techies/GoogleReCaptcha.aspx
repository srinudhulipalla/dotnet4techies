<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="GoogleReCaptcha.aspx.cs" Inherits="Dotnet4TechiesASPNET.GoogleReCaptcha" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src='https://www.google.com/recaptcha/api.js'></script>
    <div>
        <h3>Login Now</h3>
    </div>
    <div>
        <table>
            <tr>
                <td>Username:</td>
                <td>
                    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <div class="g-recaptcha" data-sitekey="6LcqFg8UAAAAADUK7coDHgoeTXEdJ9JQICdCyVcP"></div>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
</asp:Content>


