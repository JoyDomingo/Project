<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddRestaurantPage.aspx.cs" Inherits="WebApplication1.AddRestaurantPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="LocalPage.css"/>
</head>
<body>
    <form id="form2" runat="server">
        <div class ="title">
            <asp:Label ID="lblTitle" runat="server" Text="Joy's Restaurant Review"></asp:Label>
        </div>
        <br />
        <div class="SignIn">
            <asp:Button ID="Button1" runat="server" Text="Back To Main Page" OnClick="btnBackToMain_Click" />    
        </div>
        <br />
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="Enter Restaurant Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddResName" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvResName" runat="server" ControlToValidate ="txtAddResName" ErrorMessage ="Name is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Enter Restaurant Type:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlResType" runat="server">
                <asp:ListItem Value="1">Italian</asp:ListItem>
                <asp:ListItem Value="2">Pizza</asp:ListItem>
                <asp:ListItem Value="3">Seafood</asp:ListItem>
                <asp:ListItem Value="4">Asian</asp:ListItem>
                <asp:ListItem Value="5">Bar</asp:ListItem>
                <asp:ListItem Value="6">Mexican</asp:ListItem>
                <asp:ListItem Value="7">SteakHouse</asp:ListItem>
                <asp:ListItem Value="8">Vegan</asp:ListItem>
                <asp:ListItem Value="9">Korean</asp:ListItem>
                <asp:ListItem Value="10">American</asp:ListItem>
                <asp:ListItem Value="11">Middle Eastern</asp:ListItem>
                <asp:ListItem Value="12">Dessert</asp:ListItem>
            </asp:DropDownList>
&nbsp;<br />
            <asp:Label ID="Label4" runat="server" Text="Restaurant State: "></asp:Label>
            <asp:TextBox ID="txtAddResState" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvState" runat="server" ControlToValidate ="txtAddResState" ErrorMessage ="State is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Restaurant City:"></asp:Label>
&nbsp;<asp:TextBox ID="txtAddCity" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvCity" runat="server" ControlToValidate ="txtAddCity" ErrorMessage ="City is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="btnCreateRes_Click" Text="Add Restaurant" />
            
        </div>

    </form>
</body>
</html>