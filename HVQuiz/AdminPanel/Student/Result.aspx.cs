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
    public partial class Result : System.Web.UI.Page
    {
        int Qnum = 0;
        String TimeDuration = null;
        static List<int> Qlist = new List<int>();
        static string total = null;
        List<QuestionsENT> questions = new List<QuestionsENT>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getQuizDetails();
                getQuestionsForQuiz();
                fillMcg();
                msgL.Text = "Your Score is " + Session["marks"].ToString() + " Out Of " + total.ToString();
            }
        }

        private void getQuizDetails()
        {
            try
            {
                QuizENT quizENT = new QuizENT();
                QuizBAL quizBAL = new QuizBAL();

                quizENT = quizBAL.GetQuizByQuizId(int.Parse(Request.QueryString["Qid"].ToString()));

                Qnum = int.Parse(quizENT.NumOfQuestion.ToString());
                TimeDuration = quizENT.TimeDuration.ToString();
                total = quizENT.TotalMarks.ToString();
            }
            catch (Exception e)
            {
                msgL.Text += e.ToString();
            }
        }

        private void getQuestionsForQuiz()
        {
            QuestionInQuizENT questionInQuizENT = new QuestionInQuizENT();
            QuestionInQuizBAL questionInQuizBAL = new QuestionInQuizBAL();

            Qlist = questionInQuizBAL.GetQuestionForQuiz(int.Parse(Request.QueryString["Qid"].ToString()),Qnum);
        }

        public void fillMcg()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Qid", typeof(string));
            dt.Columns.Add("question", typeof(string));
            dt.Columns.Add("correct_answer", typeof(string));
            dt.Columns.Add("support", typeof(string));
            try
            {
                QuestionBAL questionBAL = new QuestionBAL();
                QuestionsENT questionsENT = new QuestionsENT();
                questions = questionBAL.GetQuestionENTForQuiz(Qlist);

                for (int j = 0; j < Qnum; j++)
                {


                    DataRow NewRow = dt.NewRow();
                    NewRow[0] = (j + 1).ToString();
                    NewRow[1] = questions[j].question.ToString();
                    NewRow[2] = questions[j].correct_answer.ToString();
                    NewRow[3] = questions[j].support.ToString();
                    dt.Rows.Add(NewRow);
                }
                Repeater1.DataSource = dt;
                Repeater1.DataBind();


            }
            catch (Exception loadddl)
            {
                msgL.Text += loadddl;
            }
        }

        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Participate_Home.aspx");
        }

    }
}