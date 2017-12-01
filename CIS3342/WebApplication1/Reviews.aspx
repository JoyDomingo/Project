<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reviews.aspx.cs" Inherits="WebApplication1.Reviews" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="LocalPage.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server" Text="Name Of Page Here"></asp:Label>
        </div>
        <br />
        <div>
            <asp:Label ID="lblRestaurantName" runat="server" OnRowUpdating="gvReviews_RowUpdating" Text="Label"></asp:Label>
            <%-- Session goes here with the Restuarant Name for the review --%>

            <asp:GridView ID="gvReviews" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Reviews">
                        <ItemTemplate>
                            <asp:Button ID="btnReviews" runat="server" CommandName="Update" Text="Select" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <%-- change gridview into reviews and have a back button that changes back into all the restaurants
                again --%>
        </div>
    </form>
</body>
</html>
