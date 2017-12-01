<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="WebApplication1.AddUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="LocalPage.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server" Text="Joy's Restaurant Review"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="lblnewUser" runat="server" Text="Create a New Log In"></asp:Label>
        </div>
        <br />
        <br />
        <div>
            <asp:Label ID="lblFirstName" runat="server" Text="Enter Your First Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Enter Your Last Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblMessage" runat="server" Font-Size="X-Large" ForeColor="Red" style="z-index: 1; left: 498px; top: 217px; position: absolute" Text="Label" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="lblUserName" runat="server" Text="Create a UserName"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddUserName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblUserType" runat="server" Text="Are You a User, Reviewer, or a Representative?"></asp:Label>
            &nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlUserType" runat="server">
                <asp:ListItem Value="1">User</asp:ListItem>
                <asp:ListItem Value="2">Reviewer</asp:ListItem>
                <asp:ListItem Value="3">Representative</asp:ListItem>
            </asp:DropDownList>
            <br /><br />
            <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" />
        </div>
    </form>
</body>
</html>
