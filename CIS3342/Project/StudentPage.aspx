<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="Project.StudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="TermProject.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Welcome!<asp:Label ID="lblName" runat="server" Text="Student Name here"></asp:Label></h3>
        </div>

        <ul class="nav">
            <li>Student Course Page here</li>
            <li>Assignment Submission Tool</li>
            <li>(Optional Enroll in a class)</li>
            <li>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" /></li>
        </ul>
        <div class="mainContent">
            <div id="leftSide">
                <p>assignments due dates goes here</p>
                <ul>
                    <li>class 1</li>
                    <li>class 2</li>
                </ul>
            </div>
            <div id="middleSide">
                <p> List of their courses that they are able to click goes here.</p>
                <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" >
                    <Columns>
                        <asp:TemplateField HeaderText="Course ID">
                            <ItemTemplate>
                                <asp:Label ID="lblCourseID" runat="server" Text='<%# Bind("CourseID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Course Name">
                            <ItemTemplate>
                                <asp:Label ID="lblCourseName" runat="server" Text='<%# Bind("CourseName") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btnSelectCourse" runat="server" Text="Select"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

            <div id="rightSide">
                <p>List of their grades here.</p>

                <ul>
                    <li>
                        <asp:Label ID="lblCourseGrade1" runat="server" Text="Course Grade 1"></asp:Label></li>
                    <li>
                        <asp:Label ID="lblCourseGrade2" runat="server" Text="Course Grade 2"></asp:Label></li>
                </ul>
            </div>

        </div>

        <div class="footer">
            <p>Temple University 3342: Server-Side Term Project</p>
        </div>
    </form>
</body>
</html>
