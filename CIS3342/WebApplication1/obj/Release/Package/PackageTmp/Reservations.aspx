<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="WebApplication1.Reservations" %>

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

    <div>
    
        <asp:Button ID="btnSignOut" runat="server" Text="SignOut" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReservations" runat="server" OnClick="btnReservations_Click" Text="Reservations" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnMain" runat="server" OnClick="btnMain_Click" Text="Main" />
        <br />
        <br />
    
        <asp:Label ID="lblReservations" runat="server" Font-Size="Large" Text="Manage Your Reservations Here"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Add" runat="server" OnClick="Add_Click" Text="Add" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblRestaurantName" runat="server" Text="Restaurant Name" Visible="False"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlRestaurantName" runat="server" Visible="False">
        </asp:DropDownList>
&nbsp;<asp:Button ID="btnSelect" runat="server" Text="Select" Visible="False" />
        <br />
        <asp:Calendar ID="clrReservations" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Visible="False" Width="350px">
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
            <TodayDayStyle BackColor="#CCCCCC" />
        </asp:Calendar>
        <br />
        <asp:DropDownList ID="ddlTime" runat="server" Visible="False">
            <asp:ListItem>8:00</asp:ListItem>
            <asp:ListItem>9:00</asp:ListItem>
            <asp:ListItem>10:00</asp:ListItem>
            <asp:ListItem>11:00</asp:ListItem>
            <asp:ListItem>12:00</asp:ListItem>
            <asp:ListItem>13:00</asp:ListItem>
            <asp:ListItem>14:00</asp:ListItem>
            <asp:ListItem>15:00</asp:ListItem>
            <asp:ListItem>16:00</asp:ListItem>
            <asp:ListItem>17:00</asp:ListItem>
            <asp:ListItem>18:00</asp:ListItem>
            <asp:ListItem>19:00</asp:ListItem>
            <asp:ListItem>20:00</asp:ListItem>
            <asp:ListItem>21:00</asp:ListItem>
            <asp:ListItem>22:00</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAddDone" runat="server" OnClick="btnAddDone_Click" Text="Done" Visible="False" />
    
    </div>
    </form>
</body>
</html>
