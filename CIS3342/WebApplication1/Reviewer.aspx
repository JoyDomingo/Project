<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reviewer.aspx.cs" Inherits="WebApplication1.Reviewer" %>

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
            <asp:Button ID="btnSignOut" runat="server" Text="Sign-Out" OnClick="Signin_Click" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReservations" runat="server" OnClick="btnReservations_Click" Text="Reservations" />
        </div>

        <br />
        <asp:Button ID="btnview" runat="server" OnClick="btnview_Click" Text="View" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add a Review" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEditReview" runat="server" OnClick="btnEditReview_Click" Text="Edit A Review" />
        <br />

        <br />

        <div class="search">

            <asp:Label ID="lblSearchType" runat="server" Text="Search by Restaurant Type: "></asp:Label>
            &nbsp;&nbsp;<asp:DropDownList ID="ddlRestaurants" runat="server">
            </asp:DropDownList>
                    
        &nbsp;<asp:Button ID="btnSelect" runat="server" OnClick="btnSelect_Click" Text="Select" />
                    
        </div>

        <br />

        <div class ="gvMain" id="ddlCostRating">

            <asp:GridView ID="gvReview" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>

            <br />
            <asp:Label ID="lblAddReview" runat="server" Text="Add Review Here" Visible="False"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtReview" runat="server" Height="55px" Visible="False" Width="239px"></asp:TextBox>
            <br />
            <br />
&nbsp;<asp:Label ID="lblFoodRating" runat="server" Text="Restaurant Food Rating (1 is the lowest, 5 is the best)" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlFoodRating" runat="server" Visible="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblServiceRating" runat="server" Text="Restaurant Service Rating (1 is the lowest, 5 is the best)" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlServices" runat="server" Visible="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblCostRating" runat="server" Text="Restaurant Cost Rating (1 is cheap, 5 is expensive)" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlCostRating" runat="server" Visible="False">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btnAddtoData" runat="server" OnClick="btnAddtoData_Click" Text="Add" Visible="False" />

        </div>
            
    </form>
</body>
</html>