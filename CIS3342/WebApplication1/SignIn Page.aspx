<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn Page.aspx.cs" Inherits="WebApplication1.SignIn_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="LocalPage.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class ="title">
            <asp:Label ID="lblTitle" runat="server" Text="Joy's Restaurant Review"></asp:Label>
        </div>
    <div id="SignIn">
    
        <asp:Label ID="lblSignIn" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Sign In" style="z-index: 1; left: 465px; top: 133px; position: absolute; bottom: 698px"></asp:Label>
    
    </div>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 443px; top: 207px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblEnterUserName" runat="server" style="z-index: 1; left: 439px; top: 180px; position: absolute" Text="Enter Your UserName"></asp:Label>
        <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" style="z-index: 1; left: 479px; top: 248px; position: absolute" Text="SignIn"/>
        <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" style="z-index: 1; left: 286px; top: 253px; position: absolute" Text="Go back" />
    </form>
</body>
</html>
