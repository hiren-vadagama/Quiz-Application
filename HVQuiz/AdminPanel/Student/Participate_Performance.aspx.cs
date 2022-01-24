using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Student
{
    public partial class Participate_Performance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbluser.Text += Session["name"].ToString();
                try
                {
                    ParticipateENT participateENT = new ParticipateENT();
                    ParticipateBAL participateBAL = new ParticipateBAL();

                    repeat.DataSource = participateBAL.GetQuizPreformancebyStudentId(int.Parse(Session["id"].ToString())); ;
                    repeat.DataBind();
                }
                catch (Exception loadddl)
                {
                    lblmsg.Text += loadddl.ToString();
                }
                CheckData();
            }
        }
        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "MyUpdate")
            {
                try
                {
                    QuizENT quizENT = new QuizENT();
                    QuizBAL quizBAL = new QuizBAL();
                    quizBAL.GetQuizByQuizId(int.Parse(e.CommandArgument.ToString()));

                }
                catch (Exception e2)
                {
                    lblmsg.Text += e2.ToString();
                }
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
        protected void CheckData()
        {
            foreach (RepeaterItem item in repeat.Items)
            {
                var tbSelected = (Label)item.FindControl("per");
                var tbSelectedsim = (Label)item.FindControl("simbol");
                var tbSelectedrank = (Label)item.FindControl("lblrank");
                if (tbSelected.Text == "")
                {
                    tbSelectedsim.Text = "";
                    tbSelected.Text = "absent";
                    tbSelectedrank.Text = "absent";
                }
            }
        }
    }
}