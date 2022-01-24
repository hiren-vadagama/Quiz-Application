using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Instructor
{
    public partial class Instructor_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbluser.Text = Session["name"].ToString();
                try
                {
                    QuizBAL quizBAL = new QuizBAL();

                    repeat.DataSource = quizBAL.GetQuizByInstructorId_DataTable(int.Parse(Session["id"].ToString()));
                    repeat.DataBind();
                }
                catch (Exception loadddl)
                {
                    lblError.Text = loadddl.ToString();
                }
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            lblError.Text = "ye";
        }
        protected void test()
        {
            lblError.Text = "ye";
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "MyUpdate")
            {
                Response.Redirect("CreateQuiz.aspx?Qid=" + e.CommandArgument);
            }
        }
        protected void btnLogout(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../../Default.aspx");
        }

        private void deleteFromDbQuiz()
        {
            lblError.Text += "yesh";
        }

        protected void btnDeleteQuiz(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "MyUpdate")
            {
                litScript.Text = "<script src='https://unpkg.com/sweetalert/dist/sweetalert.min.js'></script><script type ='text/javascript'>swal('Good job!','You clicked the button!', 'success');</script>";
                try
                {
                    QuizBAL quizBAL = new QuizBAL();
                    quizBAL.DeleteQuizByQuizId(int.Parse(e.CommandArgument.ToString()));
                    Response.Redirect("Instructor_Home.aspx");
                }
                catch (Exception loadddl)
                {
                    lblError.Text = loadddl.ToString();
                }
            }

        }

    }
}