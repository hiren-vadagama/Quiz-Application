using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Instructor
{
    public partial class PerformanceTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Qid"] != null)
                {
                    try
                    {
                        PerformanceInQuizBAL performanceInQuizBAL = new PerformanceInQuizBAL();

                        gvStuList.DataSource = performanceInQuizBAL.GetStudentperformancedata(int.Parse(Request.QueryString["Qid"]));
                        gvStuList.DataBind();
                    }
                    catch (Exception loadddl)
                    {
                        lblErromsg.Text += loadddl;
                    }


                }

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Instructor_Performance.aspx");
        }
    }
}