<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogleReCaptcha.aspx.cs" Inherits="Dotnet4TechiesASPNET.GoogleReCaptcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src='https://www.google.com/recaptcha/api.js'></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2><u>Dotnet 4 Techies</u></h2>
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
    </form>
</body>
</html>
