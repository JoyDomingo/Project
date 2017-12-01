<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WSTestPage.aspx.cs" Inherits="TermProjectWSTest.WSTestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Test Page</h1>
    </div>
        <div id="addCourse">
            <asp:Label ID="lbladdcourse" runat="server" Text="Add a Course"></asp:Label>
            <br />
            <asp:Label ID="lblCourseName" runat="server" Text="Course Name"></asp:Label>
            <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCourseDescription" runat="server" Text="Course Description"></asp:Label>
            <asp:TextBox ID="txtCourseDescription" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCourseCredit" runat="server" Text="Course Credit"></asp:Label>
            <asp:TextBox ID="txtCourseCredit" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmitCourse" runat="server" Text="Submit" OnClick="btnSubmitCourse_Click" />
        </div>
        <br />
        <div id ="deleteCourse">
            <asp:Label ID="lblDeleteCourse" runat="server" Text="Delete A Course"></asp:Label>
            <br />
            <asp:Label ID="lblDeleteCourseID" runat="server" Text="Enter Course ID to delete"></asp:Label>
            <asp:TextBox ID="txtDeleteCourse" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </div>
    </form>
</body>
</html>
