<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Project.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="TermProject.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Welcome! <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label></h1>
    </div>

        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </form>
</body>
</html>
