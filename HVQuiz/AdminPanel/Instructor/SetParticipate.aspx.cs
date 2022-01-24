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
    public partial class SetParticipate : System.Web.UI.Page
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
                        ParticipateBAL participateBAL = new ParticipateBAL();
                       
                        gvStuList.DataSource = participateBAL.ListOfAllStudent();
                        gvStuList.DataBind();

                    }
                    catch (Exception loadddl)
                    {
                        lblErromsg.Text += loadddl;
                    }
                    try
                    {
                        PerformanceInQuizBAL performanceInQuizBAL = new PerformanceInQuizBAL();

                        gvSelected.DataSource = performanceInQuizBAL.GetSelectedStudentForQuiz(int.Parse(Request.QueryString["Qid"]));
                        gvSelected.DataBind();

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
                        ParticipateBAL participateBAL = new ParticipateBAL();
                       
                        gvStuList.DataSource = participateBAL.ListOfAllStudent();
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
            dt.Columns.Add("ParticipateId", typeof(string));
            dt.Columns.Add("participateName", typeof(string));
            dt.Columns.Add("CollegeName", typeof(string));

            if (e.CommandName == "selectRow")
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
                ParticipateBAL participateBAL = new ParticipateBAL();

                gvSelected.DataSource = participateBAL.ListOfAllStudent();
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
            if (Request.QueryString["Qid"] != null)
            {
                try
                {
                    PerformanceInQuizBAL performanceInQuizBAL = new PerformanceInQuizBAL();
                    performanceInQuizBAL.DeleteStudentforQuiz(int.Parse(Request.QueryString["Qid"]));


                    foreach (GridViewRow gvr in gvSelected.Rows)
                    {
                        PerformanceInQuizENT performanceInQuizENT = new PerformanceInQuizENT();
                        performanceInQuizBAL.DeleteStudentforQuiz(int.Parse(Request.QueryString["Qid"]));

                        Int32 id = Convert.ToInt32(gvr.Cells[0].Text);
                        performanceInQuizENT.ParticipateId = id;
                        performanceInQuizENT.QuizId = int.Parse(Request.QueryString["Qid"]);
                        performanceInQuizBAL.SelectedStuForQuiz(performanceInQuizENT);

                    }
                }
                catch (Exception e2)
                {
                    lblErromsg.Text = e2.ToString();
                }
                Response.Redirect("Instructor_Home.aspx");


            }
            else
            {
                try
                {
                    PerformanceInQuizBAL performanceInQuizBAL = new PerformanceInQuizBAL();
                    foreach (GridViewRow gvr in gvSelected.Rows)
                    {
                        PerformanceInQuizENT performanceInQuizENT = new PerformanceInQuizENT();

                        int id =int.Parse(gvr.Cells[0].Text);
                        performanceInQuizENT.ParticipateId = id;
                        performanceInQuizENT.QuizId = int.Parse(Session["Quizid"].ToString());
                        performanceInQuizBAL.SelectedStuForQuiz(performanceInQuizENT);
                    }

                    Response.Redirect("Instructor_Home.aspx");
                }
                catch (Exception loadddl)
                {
                    lblErromsg.Text += loadddl;
                }

            }


        }
    }
}