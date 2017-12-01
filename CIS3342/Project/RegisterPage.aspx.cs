using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;

namespace Project
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        
        BlackboardSvc.Blackboard pxy = new BlackboardSvc.Blackboard();
        BlackboardSvc.Students newStudent = new BlackboardSvc.Students();
        BlackboardSvc.Professor newProf = new BlackboardSvc.Professor();
        BlackboardSvc.User newUser = new BlackboardSvc.User();

        protected void Page_Load(object sender, EventArgs e)
        {
            StudentInput.Visible = false;
            ProfessorInput.Visible = false;
            AdminInput.Visible = false;
            Session["check"] = 0;
        }

        protected void valConfirmStudentPass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Check the value of the control this validator is validating
            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                //set the validator to valid and also used to set the Page.IsValid to true
                args.IsValid = true;
            }
            else
            {
                // set the validator to invalid and also sets the Page.IsValid to false
                args.IsValid = false;
            }
        }

        protected void valConfirmProfPass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Check the value of the control this validator is validating
            if (txtPasswordProf.Text == txtConfirmPasswordProf.Text)
            {
                //set the validator to valid and also used to set the Page.IsValid to true
                args.IsValid = true;
            }
            else
            {
                // set the validator to invalid and also sets the Page.IsValid to false
                args.IsValid = false;
            }
        }

        protected void valConfirmAdminPass_ServerValidate(object source, ServerValidateEventArgs args)
        {
            // Check the value of the control this validator is validating
            if (txtPasswordAdmin.Text == txtConfirmPasswordAdmin.Text)
            {
                //set the validator to valid and also used to set the Page.IsValid to true
                args.IsValid = true;
            }
            else
            {
                // set the validator to invalid and also sets the Page.IsValid to false
                args.IsValid = false;
            }
        }

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            StudentInput.Visible = true;
            btnAdmin.Enabled = false;
            btnStudent.Enabled = false;
            btnProfessor.Enabled = false;
        }

        protected void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorInput.Visible = true;
            btnAdmin.Enabled = false;
            btnStudent.Enabled = false;
            btnProfessor.Enabled = false;
        }

        protected void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminInput.Visible = true;
            btnAdmin.Enabled = false;
            btnStudent.Enabled = false;
            btnProfessor.Enabled = false;
        }

        protected void btnAdminRegister_Click(object sender, EventArgs e)
        {

            if (!Page.IsValid)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Password Does Not Match";
            }
            else
            {
                int adminID = int.Parse(txtAdminNumber.Text);
                string firstName = txtEnterFNameAdmin.Text;
                string lastName = txtEnterLNameAdmin.Text;
                string password = txtPasswordAdmin.Text;
                string email = txtEnterEmailAdmin.Text;
                string type = "Admin";

                newUser = new BlackboardSvc.User();
                newUser.userID = adminID;
                newUser.UserFirstName = firstName;
                newUser.userLastName = lastName;
                newUser.Userpassword = password;
                newUser.userEmail = email;
                newUser.userType = type;

                if (pxy.AddNewUser(newUser))
                {
                    Session["check"] = 2;
                    lblMessage.Text = "Admin Account Created";
                    Response.Redirect("AdminPage.aspx");
                }
                else
                {
                    lblMessage.Text = "Account Not Created";
                }
            }
        }

        protected void btnStudentRegister_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Password Does Not Match";
            }
            else
            {
                int studentId = int.Parse(txtStudentID.Text);
                string password = txtPassword.Text;
                string firstName = txtEnterFName.Text;
                string lastName = txtEnterLName.Text;
                int gradYear = int.Parse(ddlGradYear.SelectedValue);
                string email = txtEnterEmail.Text;
                string type = "Student";

                newUser = new BlackboardSvc.User();
                newUser.userID = studentId;
                newUser.UserFirstName = firstName;
                newUser.userLastName = lastName;
                newUser.Userpassword = password;
                newUser.userEmail = email;
                newUser.userType = type;

                newStudent = new BlackboardSvc.Students();
                newStudent.StudentID = studentId;
                newStudent.StudentGradYear = gradYear;

                if (pxy.AddNewUser(newUser) && pxy.AddNewStudent(newStudent))
                {
                    Session["check"] = 2;
                    lblMessage.Text = "Student Account Created";
                    Response.Redirect("StudentPage.aspx");
                }
                else
                {
                    lblMessage.Text = "Account Not Created";
                }
            }
        }

        protected void btnProfessorRegister_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
            {
                lblMessage.Visible = true;
                lblMessage.Text = "Password Does Not Match";
            }
            else
            {
                int profID = int.Parse(txtProfID.Text);
                string password = txtPasswordProf.Text;
                string firstName = txtEnterFNameProf.Text;
                string lastName = txtEnterLNameProf.Text;
                string email = txtEnterEmailProf.Text;
                string department = ddlDepartment.SelectedValue;
                string type = "Professor";

                newUser = new BlackboardSvc.User();
                newUser.userID = profID;
                newUser.UserFirstName = firstName;
                newUser.userLastName = lastName;
                newUser.Userpassword = password;
                newUser.userEmail = email;
                newUser.userType = type;

                newProf = new BlackboardSvc.Professor();
                newProf.ProfDepartment = department;
                newProf.ProfId = profID;

                if (pxy.AddNewUser(newUser) && pxy.AddNewProfessor(newProf))
                {
                    Session["check"] = 3;
                    lblMessage.Text = "Professor Account Created";
                    Response.Redirect("ProfessorPage.aspx");
                }
                else
                {
                    lblMessage.Text = "Professor Account Not Created";
                }

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login Page.aspx");
        }
    }
}