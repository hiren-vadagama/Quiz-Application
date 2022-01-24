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
    public partial class AddQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillSubject();
            }
        }
        private void fillSubject()
        {

            try
            {
                SubjectBAL subjectBAL = new SubjectBAL();
                ddlSubject.DataSource = subjectBAL.SelectAll();
                ddlSubject.DataValueField = "SubjectId";
                ddlSubject.DataTextField = "SubjectName";
                ddlSubject.DataBind();
                ddlSubject.Items.Insert(0, new ListItem("Select Subject", "0"));

            }
            catch (Exception e)
            {
                lblErromsg.Text += e;
            }

        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                QuestionBAL questionBAL = new QuestionBAL();
                QuestionsENT questionsENT = new QuestionsENT();

                questionsENT.question = txtQuestion.Text.Trim();
                questionsENT.correct_answer = txtans.Text.Trim();
                questionsENT.distractor1 = txtdistractor1.Text.Trim();
                questionsENT.distractor2= txtdistractor2.Text.Trim();
                questionsENT.distractor3 = txtdistractor3.Text.Trim();
                questionsENT.support = txtSupport.Text.Trim();
                questionsENT.SubjectId = int.Parse(ddlSubject.SelectedValue);
                questionBAL.InsertDataForQuiz(questionsENT);
                txtQuestion.Text = "";
                txtans.Text = "";
                txtdistractor1.Text = "";
                txtdistractor2.Text = "";
                txtdistractor3.Text = "";
                txtSupport.Text = "";
                ddlSubject.SelectedValue = "0";

            }
            catch (Exception ex)
            {
                lblErromsg.Text = ex.ToString();
            }
        }
    }
}