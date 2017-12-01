<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModifyCourses.aspx.cs" Inherits="Project.ModifyCourses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Edit Courses for Course Builder/ Professor</h1>
    </div>

        <div>
            <asp:GridView ID="gvCourses" runat="server" AutoGenerateColumns="False" OnRowEditing="gvCourses_RowEditing" OnRowUpdating="gvCourses_RowUpdating" >
                <Columns>
                    <asp:TemplateField HeaderText="Course ID">
                        <ItemTemplate>
                            <asp:Label ID="lblCourseID" runat="server" Text='<%# Bind("CourseID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Course Name">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourseName" runat="server" Text='<%# Bind("CourseName") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourseDescription" runat="server" Text='<%# Bind("CourseDescription") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Section Number">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourseSectionNum" runat="server" Text='<%# Bind("SectionNumber") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Day">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourseDay" runat="server" Text='<%# Bind("SectionDay") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Hours">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourseHours" runat="server" Text='<%# Bind("SectionHours") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Credits">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCredit" runat="server" Text='<%# Bind("Credits") %>'></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEditCourse" runat="server" ShowEditButton="True" HeaderText ="Edit Course" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnDeleteCourse" runat="server" ShowSelectedButton="True" HeaderText="Delete Course"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
