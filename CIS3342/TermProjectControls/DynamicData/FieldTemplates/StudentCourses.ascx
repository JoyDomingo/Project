<%@ Control Language="C#" CodeBehind="StudentCourses.ascx.cs" Inherits="TermProjectControls.DynamicData.FieldTemplates.StudentCourses" %>

<style type="text/css">
    .auto-style1 {
        height: 23px;
        width: 116px;
    }
    .auto-style2 {
        height: 23px;
        width: 100px;
    }
    .auto-style3 {
        height: 23px;
        width: 289px;
    }
</style>

<table style="width:37%;">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="lblCourseID" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:Label ID="lblCourseName" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style1">
            <asp:Button ID="btnSelectCourse" runat="server" style="margin-left: 0px" Text="Select" />
        </td>
    </tr>
</table>

