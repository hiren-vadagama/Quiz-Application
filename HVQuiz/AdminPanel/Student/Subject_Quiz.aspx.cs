﻿using BAL;
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
    public partial class Subject_Quiz : System.Web.UI.Page
    {
        static int Qnum = 50;
        static String TimeDuration = "60";
        static int[] opList;
        static List<int> Qlist = new List<int>();
        static string total = "50";
        List<QuestionsENT> questions = new List<QuestionsENT>();
        static int PSID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getQuizDetails();
                opList = new int[Qnum];
                getQuestionsForQuiz();
                fillMcg();
            }
        }

        private void getQuizDetails()
        {
            try
            {
                PerformanceInSubjectBAL performanceInSubjectBAL = new PerformanceInSubjectBAL();
                PSID = performanceInSubjectBAL.PerformanceInSubjectGetPSID(int.Parse(Session["id"].ToString()), int.Parse(Request.QueryString["SubId"].ToString()));
                lblmin.Text = TimeDuration;
                txttotal.Text = total;
                txtNumOfQue.Text = Qnum.ToString();

            }
            catch (Exception e)
            {
                msgL.Text += e.ToString();
            }
        }
        public void fillMcg()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Qid", typeof(string));
            dt.Columns.Add("question", typeof(string));
            dt.Columns.Add("distractor1", typeof(string));
            dt.Columns.Add("distractor2", typeof(string));
            dt.Columns.Add("distractor3", typeof(string));
            dt.Columns.Add("distractor4", typeof(string));
            try
            {
                Random a = new Random();
                int MyNumber = 0;
                QuestionBAL questionBAL = new QuestionBAL();
                QuestionsENT questionsENT = new QuestionsENT();

                questions = questionBAL.GetQuestionENTForQuiz(Qlist);
                for (int j = 0; j < Qnum; j++)
                {
                    MyNumber = a.Next(1, 5);
                    opList[j] = MyNumber;
                    msgL.Text += (j + 1) + " :" + MyNumber.ToString() + " | ";

                    DataRow NewRow = dt.NewRow();
                    NewRow[0] = (j + 1).ToString();
                    NewRow[1] = questions[j].question.ToString();

                    if (opList[j] == 1)
                    {
                        NewRow[2] = questions[j].correct_answer.ToString();
                        NewRow[3] = questions[j].distractor1.ToString();
                        NewRow[4] = questions[j].distractor2.ToString();
                        NewRow[5] = questions[j].distractor3.ToString();
                    }
                    if (opList[j] == 2)
                    {

                        NewRow[3] = questions[j].correct_answer.ToString();
                        NewRow[2] = questions[j].distractor1.ToString();
                        NewRow[4] = questions[j].distractor2.ToString();
                        NewRow[5] = questions[j].distractor3.ToString();
                    }
                    if (opList[j] == 3)
                    {

                        NewRow[4] = questions[j].correct_answer.ToString();
                        NewRow[2] = questions[j].distractor1.ToString();
                        NewRow[3] = questions[j].distractor2.ToString();
                        NewRow[5] = questions[j].distractor3.ToString();
                    }
                    if (opList[j] == 4)
                    {
                        NewRow[5] = questions[j].correct_answer.ToString();
                        NewRow[2] = questions[j].distractor1.ToString();
                        NewRow[3] = questions[j].distractor2.ToString();
                        NewRow[4] = questions[j].distractor3.ToString();
                    }

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

        private void getQuestionsForQuiz()
        {
            QuestionBAL questionBAL = new QuestionBAL();
            Qlist = questionBAL.selectQuestionForSubjectQuiz(Qnum, int.Parse(Request.QueryString["SubId"].ToString()));
        }
        protected void Timer1_Tick(object sender, EventArgs e)
        {
            int min = int.Parse(lblmin.Text);
            int seconds = int.Parse(lblsec.Text);
            if (min >= 0)
            {
                if (seconds > 0)
                {
                    lblsec.Text = (seconds - 1).ToString();
                }
                else
                {
                    lblmin.Text = (min - 1).ToString();
                    lblsec.Text = 60.ToString();
                }
            }
            else
            {
                Timer1.Enabled = false;
                btnTempClick();
            }

        }

        private void insertPer(int per)
        {
            try
            {
                PerformanceInSubjectBAL performanceInSubjectBAL = new PerformanceInSubjectBAL();
                performanceInSubjectBAL.insertScoreForSubQuiz(PSID, per);
            }
            catch (Exception e)
            {
                msgL.Text += e;
            }

        }

        private void btnTempClick()
        {
            msgL.Text = "";
            int i = 0;
            int mark = 0;

            foreach (RepeaterItem item in Repeater1.Items)
            {
                RadioButton rbtn1 = (RadioButton)item.FindControl("RadioButton1");
                RadioButton rbtn2 = (RadioButton)item.FindControl("RadioButton2");
                RadioButton rbtn3 = (RadioButton)item.FindControl("RadioButton3");
                RadioButton rbtn4 = (RadioButton)item.FindControl("RadioButton4");

                if (opList[i] == 1)
                {
                    if (rbtn1.Checked == true)
                    {
                        mark++;
                    }
                }
                if (opList[i] == 2)
                {
                    if (rbtn2.Checked == true)
                    {
                        mark++;
                    }
                }
                if (opList[i] == 3)
                {
                    if (rbtn3.Checked == true)
                    {
                        mark++;
                    }
                }
                if (opList[i] == 4)
                {
                    if (rbtn4.Checked == true)
                    {
                        mark++;
                    } 
                }


                i++;

            }
            Session["marks"] = mark;
           
            insertPer(mark);
            Response.Redirect("ResultOfSubQuiz.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            btnTempClick();
        }
    }
}