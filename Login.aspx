<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 221px;
            text-align: right;
        }
        .auto-style3 {
            width: 232px;
            text-align: center;
        }
        .auto-style4 {
            width: 221px;
            text-align: right;
            height: 26px;
        }
        .auto-style5 {
            width: 232px;
            text-align: center;
            height: 26px;
        }
        .auto-style6 {
            height: 26px;
            text-align: left;
        }
        .auto-style7 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700">
    
        <h1 style="text-align: center">&nbsp;</h1>
        <h1 style="text-align: center">Login Page</h1>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style4">Username:</td>
                <td class="auto-style5">
                    <asp:TextBox ID="TextBoxUsernameLogin" runat="server" style="text-align: center" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUsernameLogin" ErrorMessage="Username is required" ForeColor="Red" style="text-align: left"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Password:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxPasswordLogin" runat="server" style="text-align: center" TextMode="Password" Width="180px"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPasswordLogin" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="Log in" Width="107px" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <p style="text-align: center">
            &nbsp;</p>
        <p style="text-align: center">
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
