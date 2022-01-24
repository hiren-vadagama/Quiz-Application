using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Instructor
{
    public partial class SelectQuestion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Qid"] != null)
                {
                    btnsave.Text = "Edit And Save";
                    try
                    {
                        QuestionBAL questionBAL = new QuestionBAL();                       
                        gvStuList.DataSource = questionBAL.GetQuestionList();
                        gvStuList.DataBind();
                    }
                    catch (Exception loadddl)
                    {
                        lblErromsg.Text += loadddl;
                    }


                    foreach (GridViewRow gvr1 in gvStuList.Rows)
                    {
                        foreach (GridViewRow gvr2 in gvSelected.Rows)
                        {
                            if (gvr1.Cells[0].Text == gvr2.Cells[0].Text)
                            {
                                gvr1.Cells[3].Enabled = false;
                            }
                        }
                    }
                }
                else
                {
                    try
                    {
                        QuestionBAL questionBAL = new QuestionBAL();
                        gvStuList.DataSource = questionBAL.GetQuestionList(); ;
                        gvStuList.DataBind();
                    }
                    catch (Exception loadddl)
                    {
                        lblErromsg.Text += loadddl;
                    }
                }
            }
        }

        protected void gvStuList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            DataRow dr;
            dt.Columns.Add("Qid", typeof(string));
            dt.Columns.Add("question", typeof(string));
            dt.Columns.Add("correct_answer", typeof(string));

            if (e.CommandName == "selectRow")
            {
                if (int.Parse(gvSelected.Rows.Count.ToString()) < int.Parse(Session["NumOfQues"].ToString()))
                {
                    int rowIndex = Convert.ToInt32(e.CommandArgument);

                    //Reference the GridView Row.
                    GridViewRow row = gvStuList.Rows[rowIndex - 1];

                    //Access Cell values
                    string ParticipateId = row.Cells[0].Text;
                    string participateName = row.Cells[1].Text;
                    string CollegeName = row.Cells[2].Text;
                    row.Cells[3].Enabled = false;

                    foreach (GridViewRow gvr in gvSelected.Rows)
                    {
                        dr = dt.NewRow();

                        string id = gvr.Cells[0].Text.Trim();
                        string name = gvr.Cells[1].Text.Trim();
                        string coll = gvr.Cells[2].Text.Trim();

                        dr[0] = id;
                        dr[1] = name;
                        dr[2] = coll;

                        dt.Rows.Add(dr); // add grid values in to row and add row to the blank table
                    }
                    DataRow NewRow = dt.NewRow();
                    NewRow[0] = ParticipateId;
                    NewRow[1] = participateName.Trim();
                    NewRow[2] = CollegeName.Trim();

                    dt.Rows.Add(NewRow);
                    gvSelected.DataSource = dt;
                    gvSelected.DataBind();
                }
                else
                {
                    lblErromsg.Text = "Number of question must selected " + Session["NumOfQues"].ToString();
                }

            }
            if (e.CommandName == "deleteRow")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                //Reference the GridView Row.
                GridViewRow row = gvStuList.Rows[rowIndex - 1];

                //Access Cell values
                string ParticipateId = row.Cells[0].Text;
                string participateName = row.Cells[1].Text;
                string CollegeName = row.Cells[2].Text;
                row.Cells[3].Enabled = true;

                foreach (GridViewRow gvr in gvSelected.Rows)
                {
                    dr = dt.NewRow();

                    string id = gvr.Cells[0].Text.Trim();
                    string name = gvr.Cells[1].Text.Trim();
                    string coll = gvr.Cells[2].Text.Trim();

                    dr[0] = id;
                    dr[1] = name;
                    dr[2] = coll.Trim();
                    if (ParticipateId != id)
                    {
                        dt.Rows.Add(dr); // add grid values in to row and add row to the blank table
                    }
                }
                gvSelected.DataSource = dt;
                gvSelected.DataBind();
            }
        }

        protected void btnselectall_Click(object sender, EventArgs e)
        {
            gvSelected.DataSource = null;
            gvSelected.DataBind();
            try
            {
                QuestionBAL questionBAL = new QuestionBAL();
                gvSelected.DataSource = questionBAL.GetQuestionList();
                gvSelected.DataBind();
                foreach (GridViewRow gvr in gvStuList.Rows)
                {
                    gvr.Cells[3].Enabled = false;
                }
            }
            catch (Exception loadddl)
            {
                lblErromsg.Text += loadddl;
            }
        }
        protected void btnDeselectall_Click(object sender, EventArgs e)
        {
            gvSelected.DataSource = null;
            gvSelected.DataBind();
            foreach (GridViewRow gvr in gvStuList.Rows)
            {
                gvr.Cells[3].Enabled = true;
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            if (int.Parse(gvSelected.Rows.Count.ToString()) == int.Parse(Session["NumOfQues"].ToString()))
            {

                try
                {
                    QuestionInQuizBAL questionInQuizBAL = new QuestionInQuizBAL();
                    foreach (GridViewRow gvr in gvSelected.Rows)
                    {
                        QuestionInQuizENT questionInQuizENT = new QuestionInQuizENT();
                        int id = Convert.ToInt32(gvr.Cells[0].Text);
                        questionInQuizENT.QId = id;
                        questionInQuizENT.QuizId= int.Parse(Session["Quizid"].ToString());
                        questionInQuizBAL.SetQuestion(questionInQuizENT);
                    }
                    Response.Redirect("SetParticipate.aspx");

                }
                catch (Exception loadddl)
                {
                    lblErromsg.Text += loadddl;
                }
            }
            else
            {
                lblErromsg.Text = "Number of question must selected " + Session["NumOfQues"].ToString();
            }

        }

        protected void selectRandowm_Click(object sender, EventArgs e)
        {
            QuestionBAL questionBAL = new QuestionBAL();
            int Qnum = int.Parse(Session["NumOfQues"].ToString());
            List<int> Qlist = new List<int>();
            int i = Qnum;
            Qlist = questionBAL.selectRandowmClick(Qnum);
            try
            {
                QuestionInQuizBAL questionInQuizBAL = new QuestionInQuizBAL();

                for (int j = 0; j < Qnum; j++)
                {

                    QuestionInQuizENT questionInQuizENT = new QuestionInQuizENT();
                    questionInQuizENT.QId = Qlist[j];
                    questionInQuizENT.QuizId = int.Parse(Session["Quizid"].ToString());
                    questionInQuizBAL.SetQuestion(questionInQuizENT);
                }
                Response.Redirect("SetParticipate.aspx");
            }
            catch (Exception loadddl)
            {
                lblErromsg.Text += loadddl;
            }

        }
    }
}