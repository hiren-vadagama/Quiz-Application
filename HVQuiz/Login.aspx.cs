using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["As"].ToString() == "1")
                {
                    lblHead.Text += "Instructor";
                }
                else
                {
                    lblHead.Text += "Student";
                }
            }
        }

        protected void loginAs(object sender, EventArgs e)
        {
            if (Request.QueryString["As"].ToString() == "1")
            {
                Boolean flag = false;
                InstructorENT instructorENTIn = new InstructorENT();
                InstructorENT instructorENTOut = new InstructorENT();
                InstructorBAL instructorBAL = new InstructorBAL();

                instructorENTIn.UserName = txtUsername.Text;
                instructorENTIn.Password = txtPassword.Text;

                instructorENTOut = instructorBAL.loginAsInstructor(instructorENTIn);

                if (instructorENTOut != null)
                {
                    flag = true;
                    Session["id"] = instructorENTOut.InstructorId;
                    Session["name"] = instructorENTOut.InstructorName;    
                }

                if (flag == true)
                {
                    Response.Redirect("AdminPanel/Instructor/Instructor_Home.aspx");

                }
                else
                {
                    lblErromsg.Text = "User Name or Password not Currect";
                }
            }
            else
            {

                ParticipateENT participateENTIn = new ParticipateENT();
                ParticipateENT participateENTOut = new ParticipateENT();
                ParticipateBAL participateBAL = new ParticipateBAL();
                Boolean flag = false;
                participateENTIn.UserName = txtUsername.Text;
                participateENTIn.Password = txtPassword.Text;

                participateENTOut = participateBAL.loginAsStudent(participateENTIn);
                if (participateENTOut != null)
                {
                    flag = true;
                    Session["id"] = participateENTOut.ParticipateId;
                    Session["name"] = participateENTOut.ParticipateName;
                }

                if (flag == true)
                {
                    Response.Redirect("AdminPanel/Student/Participate_Home.aspx");
                }
                else
                {
                    lblErromsg.Text = "User Name or Password not Currect";
                }
            }

        }
    }
}