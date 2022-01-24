using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Instructor
{
    public partial class Instructor_Performance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbluser.Text = Session["name"].ToString();
                try
                {
                    QuizBAL quizBAL = new QuizBAL();
                    
                    repeat.DataSource = quizBAL.getQuizforPerformance(int.Parse(Session["id"].ToString())); ;
                    repeat.DataBind();

                }
                catch (Exception loadddl)
                {
                    lblError.Text = loadddl.ToString();
                }
            }
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "MyUpdate")
            {
                Response.Redirect("PerformanceTable.aspx?Qid=" + e.CommandArgument);
            }
        }
        protected void btnLogout(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../../Default.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.UtcNow.ToLocalTime();
            lblmin.Text = currentTime.ToString("mm");
            lblhr.Text = currentTime.ToString("HH");
            lblsec.Text = currentTime.ToString("ss");
            lblDate.Text = currentTime.ToString("dd:MM:yyyy");
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
                    Response.Redirect("Instructor_Performance.aspx");
                }
                catch (Exception loadddl)
                {
                    lblError.Text = loadddl.ToString();
                }
            }

        }

    }
}