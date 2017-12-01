<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditCard.aspx.cs" Inherits="Project_4.CreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CreditCard.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div id="title">    
        Credit Card Transaction
    </div>
        <div id="menu">            

            <asp:Button ID="btnGetAccount" runat="server" Text= "View Credit Card Account" OnClick="btnGetAccount_Click" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAddCreditCard" runat="server" OnClick="btnAddCreditCard_Click" Text="Add New Credit Card" />

        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnUpdateCreditCard" runat="server" OnClick="btnUpdateCreditCard_Click" Text="Update Credit Card" />

        &nbsp;&nbsp;&nbsp;<asp:Button ID="btnMakePayment" runat="server" OnClick="btnMakePayment_Click" Text="Make Payment" />
&nbsp;<asp:Button ID="btnAddTransaction" runat="server" Text="Add New Transaction" OnClick="btnAddTransaction_Click" />

        </div>

            <div>
            <asp:Label ID="lblEnterCardNumber" runat="server" Text="Enter Your Credit Card Number" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCreditNumber" runat="server" Visible="False"></asp:TextBox>
            <asp:Button ID="btnSubmitCardNumber" runat="server" OnClick="btnSubmitCardNumber_Click" Text="Submit" Visible="False" />
                <asp:Button ID="btnSubmitUpdate" runat="server" OnClick="btnSubmitUpdate_Click" style="z-index: 1; left: 340px; top: 63px; position: absolute" Text="Submit" Visible="False" />
            <br />
            <asp:GridView ID="gvViewAccount" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Visible="False">
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
                <asp:GridView ID="gvUpdate" runat="server" OnRowUpdating ="gvUpdate_RowUpdating" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" style="z-index: 1; left: 12px; top: 98px; position: absolute; height: 133px; width: 187px">
                    <Columns>
                        <asp:TemplateField HeaderText="Credit Card Number">
                            <ItemTemplate>
                                <asp:Label ID="lblUpdateCardNumber" runat="server" Text='<%# Bind("CreditCardNumber") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="First Name">
                            <ItemTemplate>
                                <asp:TextBox ID="txtUpdateFirstName" runat="server" Text='<%# Bind("CardFirstName") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Last Name">
                            <ItemTemplate>
                                <asp:TextBox ID="txtUpdateLastName" runat="server" Text='<%# Bind("CardLastName") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Cvv">
                            <ItemTemplate>
                                <asp:TextBox ID="txtUpdateCvv" runat="server" Text='<%# Bind("CreditCardCvv") %>'></asp:TextBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Max Balance">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlUpdateMax" runat="server" SelectedValue='<%# Bind ("AvailableAmount") %>'>
                                    <asp:ListItem Text="700" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="800" Value="2"></asp:ListItem>
                                    <asp:ListItem Text="1000" Value="3"></asp:ListItem>
                                    <asp:ListItem Text="1200" Value="4"></asp:ListItem>
                                    <asp:ListItem Text="1600" Value="5"></asp:ListItem>
                                    <asp:ListItem Text="2000" Value="6"></asp:ListItem>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Amount Owed">
                            <ItemTemplate>
                                <asp:Label ID="lblUpdateAmountOwed" runat="server" Text='<%# Bind("AmountOwed") %>' ></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Update">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Button ID="btnSubmitgvUpdate" runat="server" CommandName="Update" Text="Submit" />
                            </ItemTemplate>
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
                <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 337px; top: 189px; position: absolute" Text="lblError" Visible="False"></asp:Label>
                <br />
                <asp:Label ID="lblNewFirstName" runat="server" Text="First Name" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtNewFirstName" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="lblAddLastName" runat="server" Text="Last Name" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtNewLastName" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="lblNewCvv" runat="server" Text="Enter a 3-digit Cvv" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtNewCvv" runat="server" Visible="False"></asp:TextBox>
                <br />
                <asp:Label ID="lblNewMaxAmount" runat="server" Text="Select a Max Amount" Visible="False"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlMaxBalance" runat="server" Visible="False">
                </asp:DropDownList>
                <br />
                <asp:Button ID="btnCreate" runat="server" OnClick="btnCreate_Click" Text="Create Account" Visible="False" />
            <br />
            </div>
        <div id="transactions">
            <asp:Label ID="lblCreditTransaction" runat="server" Text="Enter Your Credit Card Information" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblTransactionCardNumber" runat="server" Text="Credit Card Number" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtTransactionCardNumber" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblTransactionFirstName" runat="server" Text="Enter Your First Name" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtTransactionFirstName" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblTransactionLastName" runat="server" Text="Enter your Last Name" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtTransactionLastName" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblTransactionCvv" runat="server" Text="Enter your Cvv" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtTransactionCvv" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblTransactionExpDate" runat="server" Text="Enter Your Expiration Date" Visible="False"></asp:Label>
&nbsp;<asp:TextBox ID="txtTransactionExDate" runat="server" Visible="False">MM/YYYY</asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEnterProdInfo" runat="server" Text="Enter The Product Information" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblProductDescription" runat="server" Text="Enter Product Name" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewProductName" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewProductPrice" runat="server" Text="Enter Product Price" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewProductPrice" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblBillingInfo" runat="server" Text="Enter Your Billing Information" Visible="False"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblNewAddress" runat="server" Text="Enter Address" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewAddress" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewZipCode" runat="server" Text="Enter ZipCode" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewZipCode" runat="server" MaxLength="4" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewState" runat="server" Text="Enter State" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewState" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="lblNewCity" runat="server" Text="Enter City" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewCity" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmitTransaction" runat="server" Text="Submit" OnClick="btnSubmitTransaction_Click" Visible="False" />
        </div>

    </form>
</body>
</html>
