<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login Page.aspx.cs" Inherits="Project.Login_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link rel="stylesheet" type="text/css" href="TermProject.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>BlackBoard</h1>
    </div>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        <div id="main">
            <div id="userName">
                <asp:Label ID="lblUserName" runat="server" Text="User Name:"></asp:Label>
          &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="valUserName" runat="server" ValidationGroup ="group1"
            ControlToValidate="txtUserName" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            </div>            
            <br />
            <div id="password">
                <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
          &nbsp;<asp:TextBox ID="txtPassword" TextMode ="Password" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="valPassword" runat="server" ValidationGroup ="group1"
            ControlToValidate="txtPassword" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000"></asp:RequiredFieldValidator>

            </div>           

            <br />

            <div id="session">
            <asp:CheckBox ID="chkRememberMe" runat="server" Text="Remember Me" />
            <br />
            </div>
                 <asp:Button ValidationGroup ="group1" ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
        </div>
        <br />
        <br />
        <div id="register">
            <div id="regsec">
            <asp:Label ID="lblRegister" runat="server" Text="Don't have an account? Register Below"></asp:Label>
            <br />
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>
