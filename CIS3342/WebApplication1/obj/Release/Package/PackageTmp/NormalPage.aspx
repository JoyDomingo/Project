<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NormalPage.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="LocalPage.css"/>
</head>
<body style="height: 819px">
    <form id="form1" runat="server">    
        <div class ="title">
            <asp:Label ID="lblTitle" runat="server" Text="Joy's Restaurant Review"></asp:Label>
        </div>
        <div class="SignIn">
            <asp:Button ID="btnSignin" runat="server" Text="Sign-In" OnClick="Signin_Click" />
            <asp:Button ID="btnNewUser" runat="server" Text="New User" OnClick="btnNewUser_Click" />
        </div>

        <br />

        <div class="search">

            <asp:Label ID="lblSearchType" runat="server" Text="Search by Restaurant Type: "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearchType" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvType1" runat="server" ControlToValidate ="txtSearchType" ErrorMessage ="Type is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearchType" runat="server" Text="Search" OnClick="btnSearchType_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="lblViewAllRes" runat="server" Text="Click To View All Restaurants"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;
            
            <br />
            <br />
            <asp:Label ID="lblSearchName" runat="server" Text="Search By Restaurant Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvSearchName" runat="server" ControlToValidate ="txtSearchName" ErrorMessage ="Name is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearchName" runat="server" Text="Search" OnClick="btnSearchName_Click" />
        
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <asp:Button ID="btnAllRestaurant" runat="server" Text="Restaurants" OnClick="btnAllRestaurant_Click" />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    
        </div>

        <br />

        <div class ="gvMain">

            <asp:GridView ID="gvMainPage" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="height: 294px; width: 475px">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>

        </div>
            
    </form>
</body>
</html>
