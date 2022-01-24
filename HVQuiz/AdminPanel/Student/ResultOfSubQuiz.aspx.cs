using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Student
{
    public partial class ResultOfSubQuiz : System.Web.UI.Page
    {
        static int Qnum = 50;
        static String TimeDuration = "60";
        static int[] opList;
        static List<int> Qlist = new List<int>();
        static string total = "50";
        List<QuestionsENT> questions = new List<QuestionsENT>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                msgL.Text = "Your Score is " + Session["marks"].ToString() + " Out Of " + total.ToString();
            }
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Participate_Home.aspx");
        }

    }
}