<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProfessorPage.aspx.cs" Inherits="Project.ProfessorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="TermProject.css" />
</head>
<body>
    <form id="form1" runat="server">

            <h3>Welcome!<asp:Label ID="lblName" runat="server" Text="Professor Name here"></asp:Label></h3>

        <ul class="nav">
            <li>
                <asp:Button ID="btnModifyCourses" runat="server" Text="Modify Courses" OnClick="btnModifyCourses_Click" /></li>
            <li>Announcement</li>
            <li>Post Assignments</li>
            <li>Grade Assignments</li>
            <li>Roster</li>
            <li>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /></li>
        </ul>
        <div class="mainContent">
            <div id="leftSide">
                <p>Course Contents</p>
                <ul>
                    <li>class 1</li>
                    <li>class 2</li>
                </ul>
            </div>
            <div id="middleSide">
                <p> courses owned are here</p>
                <ul>
                    <li>
                        <asp:Label ID="lblCourse1" runat="server" Text="Course 1"></asp:Label><br />
                    </li>
                    
                    <li>
                        <asp:Label ID="lblCourse2" runat="server" Text="Course 2"></asp:Label></li>
                    <li>
                        <asp:Label ID="lblCourse3" runat="server" Text="Course 3"></asp:Label></li>
                </ul>
            </div>

            <div id="rightSide">
                <p>List Course Assignments are here.</p>

                <ul>
                    <li>
                        <asp:Label ID="lblCourseGrade1" runat="server" Text="Course Assignments 1"></asp:Label></li>
                    <li>
                        <asp:Label ID="lblCourseGrade2" runat="server" Text="Course Assignments 2"></asp:Label></li>
                </ul>
            </div>

        </div>

        <div class="footer">
            <p>Temple University 3342: Server-Side Term Project</p>
        </div>
    </form>
</body>
</html>
