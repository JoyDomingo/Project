<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="Project.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <link rel="stylesheet" type="text/css" href="TermProject.css"/>
    <style type="text/css">
        #ProfessorInput {
            z-index: 1;
            left: 2px;
            top: 250px;
            position: absolute;
            height: auto;
            width: 35%;
        }
        #AdminInput {
            z-index: 1;
            left: 2px;
            top: 250px;
            position: absolute;
            height: auto;
            width: 35%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h2>Create a New Account</h2>
    </div>
        <div id="menu">
            <asp:Button ID="btnBack" runat="server" Text="Back To Login" OnClick="btnBack_Click" />
        </div>
        <div id ="info" runat="server">
            <asp:Label ID="lblUserType" runat="server" Text="What Type of User Are You?"></asp:Label>
            <div id="buttons">
            <asp:Button ID="btnStudent" runat="server" Text="Student" OnClick="btnStudent_Click" />
            <asp:Button ID="btnProfessor" runat="server" Text="Professor" OnClick="btnProfessor_Click" />
            <asp:Button ID="btnAdmin" runat="server" Text="Admin" OnClick="btnAdmin_Click" />
            </div>
        </div>

       <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>

        <div id="StudentInput" runat="server">
            <asp:Label ID="lblStudentID" runat="server" Text="Student Number (This will be used as your UserName): "></asp:Label>
            <asp:TextBox ID="txtStudentID" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valName" runat="server" ValidationGroup ="student"
            ControlToValidate="txtStudentID" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblEnterPassword" runat="server" Text="Enter Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valPassword" runat="server" ValidationGroup ="student"
            ControlToValidate="txtPassword" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtConfirmPassword" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:CustomValidator ID="valConfirmStudentPass" runat="server" 
            ControlToValidate="txtConfirmPassword" ErrorMessage="* Passwords do not match" 
            ForeColor="#CC0000" OnServerValidate="valConfirmStudentPass_ServerValidate"></asp:CustomValidator>

            <br />
            <br />
            <asp:Label ID="lblEnterFName" runat="server" Text="First Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterFName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valFName" runat="server" ValidationGroup ="student"
            ControlToValidate="txtEnterFName" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblEnterLName" runat="server" Text="Last Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterLName" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valLName" runat="server" ValidationGroup ="student"
            ControlToValidate="txtEnterLName" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="lblGradYear" runat="server" Text="Graduation Year:"></asp:Label>
&nbsp;<asp:DropDownList ID="ddlGradYear" runat="server">
                <asp:ListItem>2018</asp:ListItem>
                <asp:ListItem>2019</asp:ListItem>
                <asp:ListItem>2020</asp:ListItem>
                <asp:ListItem>2021</asp:ListItem>
                <asp:ListItem>2022</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblEnterEmail" runat="server" Text="E-mail:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEnterEmail" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valEmail" runat="server" ValidationGroup ="student"
            ControlToValidate="txtEnterEmail" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:CheckBox ID="chkcookiestudent" runat="server" Text ="Remember Me"/>
            <asp:Button ValidationGroup ="student" ID="btnStudentRegister" runat="server" Text="Register" OnClick="btnStudentRegister_Click" />
        </div>

        <div id="ProfessorInput" runat="server">
            <asp:Label ID="lblProfID" runat="server" Text="Professor Number (This will be used as your UserName): "></asp:Label>
            <asp:TextBox ID="txtProfID" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valProfID" runat="server" ValidationGroup ="prof"
            ControlToValidate="txtProfID" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblEnterPasswordProf" runat="server" Text="Enter Password:"></asp:Label>
            <asp:TextBox ID="txtPasswordProf" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valProfPassword" runat="server" ValidationGroup ="prof"
            ControlToValidate="txtPasswordProf" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblConfirmPasswordProf" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtConfirmPasswordProf" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:CustomValidator ID="valConfirmProfPass" runat="server" 
            ControlToValidate="txtConfirmPasswordProf" ErrorMessage="* Passwords do not match" 
            ForeColor="#CC0000" OnServerValidate="valConfirmProfPass_ServerValidate"></asp:CustomValidator>

            <br />
            <br />
            <asp:Label ID="lblEnterFNameProf" runat="server" Text="First Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterFNameProf" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valProfFName" runat="server" ValidationGroup ="prof"
            ControlToValidate="txtEnterFNameProf" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblEnterLNameProf" runat="server" Text="Last Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterLNameProf" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valProfLName" runat="server" ValidationGroup ="prof"
            ControlToValidate="txtEnterLNameProf" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <br />
            <asp:Label ID="lblDepartment" runat="server" Text="Department: "></asp:Label>
            <asp:DropDownList ID="ddlDepartment" runat="server">
                <asp:ListItem>Math</asp:ListItem>
                <asp:ListItem>IST</asp:ListItem>
                <asp:ListItem>CIS</asp:ListItem>
                <asp:ListItem>English</asp:ListItem>
                <asp:ListItem>Science</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="lblEnterEmailProf" runat="server" Text="E-mail:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEnterEmailProf" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="valProfEmail" runat="server" ValidationGroup ="prof"
            ControlToValidate="txtEnterEmailProf" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:CheckBox ID="chkcookieProf" runat="server" Text ="Remember Me"/>
            <asp:Button ValidationGroup ="prof" ID="btnProfessorRegister" runat="server" Text="Register" OnClick="btnProfessorRegister_Click" />
        </div>


        <div id="AdminInput" runat="server">
            <asp:Label ID="lblAdminID" runat="server" Text="Admin Number(This will be used as your UserName): "></asp:Label>
            <asp:TextBox ID="txtAdminNumber" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valAdminID" runat="server" ValidationGroup ="Admin"
            ControlToValidate="txtAdminNumber" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblEnterPasswordAdmin" runat="server" Text="Enter Password:"></asp:Label>
            <asp:TextBox ID="txtPasswordAdmin" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valAdminPassword" runat="server" ValidationGroup ="Admin"
            ControlToValidate="txtAdminNumber" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblConfirmPasswordAdmin" runat="server" Text="Confirm Password: "></asp:Label>
            <asp:TextBox ID="txtConfirmPasswordAdmin" TextMode ="Password" runat="server"></asp:TextBox>

            <asp:CustomValidator ID="valConfirmAdminPass" runat="server" 
            ControlToValidate="txtConfirmPasswordAdmin" ErrorMessage="* Passwords do not match" 
            ForeColor="#CC0000" OnServerValidate="valConfirmAdminPass_ServerValidate"></asp:CustomValidator>

            <br />
            <br />
            <asp:Label ID="lblEnterFNameAdmin" runat="server" Text="First Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterFNameAdmin" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valAdminFName" runat="server" ValidationGroup ="Admin"
            ControlToValidate="txtEnterFNameAdmin" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:Label ID="lblEnterLNameAdmin" runat="server" Text="Last Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtEnterLNameAdmin" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valAdminLName" runat="server" ValidationGroup ="Admin"
            ControlToValidate="txtEnterLNameAdmin" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <br />
            <asp:Label ID="lblEnterEmailAdmin" runat="server" Text="E-mail:"></asp:Label>
&nbsp;<asp:TextBox ID="txtEnterEmailAdmin" runat="server"></asp:TextBox>

            <asp:RequiredFieldValidator ID="valAdminEmail" runat="server" ValidationGroup ="Admin"
            ControlToValidate="txtEnterEmailAdmin" ErrorMessage="* Required" Font-Bold="False" 
            ForeColor="#CC0000" ></asp:RequiredFieldValidator>

            <br />
            <asp:CheckBox ID="chkCookieAdmin" runat="server" Text ="Remember Me"/>
            <asp:Button ValidationGroup ="Admin" ID="btnAdminRegister" runat="server" Text="Register" OnClick="btnAdminRegister_Click" />
        </div>

    </form>
</body>
</html>
