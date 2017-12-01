<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarBuilder.aspx.cs" Inherits="Project_2.Test_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 1389px;
            width: 1002px;
        }
    </style>
</head>
<body style ="background-color: #F5F5F5">
    <form id="form1" runat="server">
    <div>    
        This is Project 2<br />
        <br />
        <a href = "http://cis-iis2.temple.edu/Fall2017/CIS3342_tuf34427">Home</a><br />
        <br />
    </div>
        <div style="height: 726px;">

            <asp:Label ID="lblOrder1" runat="server" style="z-index: 1; left: 448px; top: 202px; position: absolute; height: 28px; width: 60px;" Text="Label" Visible="False"></asp:Label>
            <br />
            
            <asp:Label ID="lblOrder" runat="server" Text="Label" style="top: 159px; left: 454px; position: absolute; height: 22px; width: 318px; bottom: 330px; z-index: 1;" Visible="False"></asp:Label >
            
            <br />
            <asp:Label ID="lblName" runat="server" Text="Enter Name:"></asp:Label>
&nbsp;<asp:TextBox ID="tbxName" runat="server" Width="390px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblNumber" runat="server" Text="Enter Number: "></asp:Label>
            <asp:TextBox ID="tbxNumber" runat="server" Width="352px"></asp:TextBox>
            
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Enter Address: "></asp:Label>
            <asp:TextBox ID="tbxAddress" runat="server" Width="354px"></asp:TextBox>
            
            <br />
            <br />
            <asp:Label ID="lblDealership" runat="server" Text="Should the dealership contact you?"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlDealership" runat="server">
                <asp:ListItem>Yes</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblBuyRent" runat="server" Text="Would You Like To Buy or Rent?"></asp:Label>
            <asp:RadioButtonList ID="RbtnBuyRent" runat="server">
                <asp:ListItem>Rent</asp:ListItem>
                <asp:ListItem>Buy</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Label ID="lblCarMake" runat="server" Text="Pick a Car Make"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlMaker" runat="server" AutoPostBack = "true" OnSelectedIndexChanged="ddlMaker_SelectedIndexChanged">
                
            </asp:DropDownList>
            <asp:GridView ID="gvManagement" runat="server" style="z-index: 1; left: 297px; top: 229px; position: absolute; height: 133px; width: 187px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
            <asp:GridView ID="gvOutput" runat="server" style="z-index: 1; left: 276px; top: 358px; position: absolute; height: 294px; width: 475px; margin-top: 0px;" Visible="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" ShowFooter="True">
                
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
            <br />
            <asp:Label ID="lblCarModel" runat="server" Text="Pick a Car Model"></asp:Label>
            <asp:Button ID="btnManagement" runat="server" Enabled="False" style="z-index: 1; left: 79px; top: 334px; position: absolute" Text="Management Report" Visible="False" OnClick="btnManagement_Click" />
            <br />
            <asp:DropDownList ID="ddlModel" runat="server" OnSelectedIndexChanged="ddlModel_SelectedIndexChanged" AutoPostBack="True" >
            
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblColor" runat="server" Text="Pick a Color"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlColor" runat="server">
                <asp:ListItem>Red</asp:ListItem>
                <asp:ListItem>Black</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Blue</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="gvCar" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="418px">
                <Columns>
                    <asp:TemplateField HeaderText="Select Package">
                    <ItemTemplate>
                        <asp:CheckBox ID="chkPackages" runat="server" />
                    </ItemTemplate>
                    <ItemStyle width="10"/>
                </asp:TemplateField>
                </Columns>
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

            <br />
            &nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuildCar" runat="server" OnClick="btnBuildCar_Click" Text="Build Car" />
        </div>
    </form>
</body>
</html>
