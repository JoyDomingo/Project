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
                <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
                    </Columns>
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
