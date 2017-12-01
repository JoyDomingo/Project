<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="Project_1.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 171px; width: 1378px; background-color: #D8C9BE">
    <p>
        <br />
    </p>
    <form id="form1" runat="server">
        <div>    
        This is Project 1<br />
        <br /> Return to home page: 
        <a href = "http://cis-iis2.temple.edu/Fall2017/CIS3342_tuf34427">Home</a></div>
        <br /> <br />
         <asp:Label ID="lblReceipt" runat="server" Text="Receipt"></asp:Label>
        <br />
        <asp:Label ID="lblTip" runat="server" Text="Tip"></asp:Label>
        
        <br />        
        <asp:Label ID="lblTotal" runat="server" Text="Total"></asp:Label>
        
        <br />
        <asp:Label ID="lblTax" runat="server" Text="Tax"></asp:Label>
        <br />
        <asp:Label ID="lblGrandTotal" runat="server" Text="GrandTotal"></asp:Label>
        
        <p>
            &nbsp;</p>
        
    </form>
</body>
</html>