<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Representative.aspx.cs" Inherits="WebApplication1.Representative" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="LocalPage.css" />
</head>
<body style="height: 819px">
    <form id="form1" runat="server">
        <div class="title">
            <asp:Label ID="lblTitle" runat="server" Text="Joy's Restaurant Review"></asp:Label>
        </div>
        <div class="SignIn">
            <asp:Button ID="btnSignOut" runat="server" OnClick="btnSignOut_Click" Text="SignOut" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReviews" runat="server" OnClick="btnReviews_Click" Text="Reviews" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReservations" runat="server" OnClick="btnReservations_Click" Text="Reservations" />
        </div>

        <br />

        <div class="search">

            <asp:Label ID="lblSearchType" runat="server" Text="Search by Restaurant Type: "></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearchType" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvType1" runat="server" ControlToValidate ="txtSearchType" ErrorMessage ="Type is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearchType" runat="server" Text="Search" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Label ID="lblViewAllRes" runat="server" Text="Click To View All Restaurants"></asp:Label>

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="lblAdd" runat="server" Text="Click To Add a Restaurant"></asp:Label>

            <br />
            <br />
            <asp:Label ID="lblSearchName" runat="server" Text="Search By Restaurant Name:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
            <%--<asp:RequiredFieldValidator id="rfvName" runat="server" ControlToValidate ="txtSearchName" ErrorMessage ="Name is Required" ForeColor ="Red">*</asp:RequiredFieldValidator>--%>&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearchName" runat="server" Text="Search" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
            <asp:Button ID="btnAllRestaurant" runat="server" Text="Restaurants" OnClick="btnAllRestaurant_Click" />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddRestaurant" runat="server" Text="Add Restaurant" OnClick="btnAddRestaurant_Click" />

        </div>

        <br />

        <div class="Representative">

            <asp:GridView ID="gvRepresentative" runat="server" OnRowUpdating="gvRepresentative_RowUpdating" OnSelectedIndexChange="gvRepresentative_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" Width="967px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />

                <Columns>
                    <asp:TemplateField HeaderText="Edit Restaurant" ShowHeader="False">
                        <ItemTemplate>
                            <asp:Button ID="btnEdit" runat="server" CausesValidation="False" CommandName="Update" Text="Edit" />
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Restaurant Name">

                        <ItemTemplate>
                            <asp:Label ID="lblName" runat="server"  Text='<%# Bind("RestaurantName") %>'></asp:Label>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="City">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCity" runat="server" Height="20px" Width="135px" Text='<%# Bind("City") %>'></asp:TextBox>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="State">

                        <ItemTemplate>
                            <asp:TextBox ID="txtState" runat="server" Height="20px" Width="142px" Text='<%# Bind("ResState") %>'></asp:TextBox>
                        </ItemTemplate>

                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Restaurant Type">
                        <ItemTemplate>                            
                            <asp:DropDownList ID="ddlType" runat="server"  SelectedValue='<%# Bind ("RestaurantTypeID") %>' DataTextField="RestaurantType" Width="149px">                               
                                <asp:ListItem Text="Italian" Value="1"></asp:ListItem>
                                <asp:ListItem Text="Pizza" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Seafood" Value="3"></asp:ListItem>
                                <asp:ListItem Text="Asian" Value="4"></asp:ListItem>
                                <asp:ListItem Text="Bar" Value="5"></asp:ListItem>
                                <asp:ListItem Text="Mexican" Value="6"></asp:ListItem>
                                <asp:ListItem Text="SteakHouse" Value="7"></asp:ListItem>
                                <asp:ListItem Text="Vegan" Value="8"></asp:ListItem>
                                <asp:ListItem Text="Korean" Value="9"></asp:ListItem>
                                <asp:ListItem Text="American" Value="10"></asp:ListItem>
                                <asp:ListItem Text="Middle Eastern" Value="11"></asp:ListItem>
                                <asp:ListItem Text="Dessert" Value="12"></asp:ListItem>
                            
                            </asp:DropDownList>
                        </ItemTemplate>
                    </asp:TemplateField>

                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle ForeColor="#333333" BackColor="#F7F6F3" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <br />
                           
            <%--<asp:Button ID="btnEditRestaurant" runat="server" OnClick="btnEditRestaurant_Click" Text="Edit" Style="height: 26px" />--%>
        </div>

    </form>
</body>
</html>

