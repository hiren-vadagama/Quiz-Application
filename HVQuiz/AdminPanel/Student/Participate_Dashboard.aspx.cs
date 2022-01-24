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
    public partial class Participate_Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbluser.Text += Session["name"].ToString();
                try
                {
                    ParticipateBAL participateBAL = new ParticipateBAL();

                    repeat.DataSource = participateBAL.GetStudentByStudentId_DataTable(int.Parse(Session["id"].ToString()));
                    repeat.DataBind();
                }
                catch (Exception loadddl)
                {
                    lblmsg.Text += loadddl.ToString();
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

        protected void EditDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }
    }

}