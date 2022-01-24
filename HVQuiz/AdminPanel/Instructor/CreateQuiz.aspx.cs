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
    public partial class CreateQuiz_aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmvDate.ValueToCompare = GetDateTime().ToString("dd/MM/yyyy");
            cmvTime.ValueToCompare = 1.ToString();
            cmvNum.ValueToCompare = 1.ToString();
            cmvstart.ValueToCompare = 23.ToString();
            cmvmin.ValueToCompare = 59.ToString();
            cmpEndhr.ValueToCompare = 23.ToString();
            cmpEndmin.ValueToCompare = 59.ToString();
            if (!IsPostBack)
            {
                fillSubject();
                if (Request.QueryString["Qid"] != null)
                {
                    getDataForUpdate();
                    btnSet.Text = "Edit And Next";
                }
            }

        }

        public static DateTime GetDateTime()
        {
            DateTime dateTime = DateTime.MinValue;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("http://www.microsoft.com");
            request.Method = "GET";
            request.Accept = "text/html, application/xhtml+xml, */*";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
            request.ContentType = "application/x-www-form-urlencoded";
            request.CachePolicy = new System.Net.Cache.RequestCachePolicy(System.Net.Cache.RequestCacheLevel.NoCacheNoStore);
            System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string todaysDates = response.Headers["date"];

                dateTime = DateTime.ParseExact(todaysDates, "ddd, dd MMM yyyy HH:mm:ss 'GMT'",
                    System.Globalization.CultureInfo.InvariantCulture.DateTimeFormat, System.Globalization.DateTimeStyles.AssumeUniversal);
            }

            return dateTime;
        }

        private void getDataForUpdate()
        {

            try
            {
                QuizENT quizENT = new QuizENT();
                QuizBAL quizBAL = new QuizBAL();

                quizENT = quizBAL.GetQuizByQuizId(int.Parse(Request.QueryString["Qid"].ToString()));

                txtDate.Text = Convert.ToDateTime(quizENT.Date).ToString("yyyy/MM/dd");
                txtEnddate.Text = Convert.ToDateTime(quizENT.EndDate).ToString("yyyy/MM/dd");
                txtQuizname.Text = quizENT.QuizName.ToString();
                txtNumberofQues.Text = quizENT.NumOfQuestion.ToString();
                txtTimeDuration.Text = quizENT.TimeDuration.ToString();
                txtQuizname.Text = quizENT.QuizName.ToString();
                ddlSubject.SelectedValue = quizENT.SubjectId.ToString();

                String temp = quizENT.StartTime.ToString();
                String temp2 = quizENT.EndTime.ToString();
                txtEndhr.Text = temp2.Substring(0, 2);
                txtEndmin.Text = temp2.Substring(3);
                txtstart.Text = temp.Substring(0, 2);
                txtmin.Text = temp.Substring(3);
            }
            catch (Exception e)
            {
                lblErromsg.Text = e.ToString();
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

        protected void btn_createQuiz(object sender, EventArgs e)
        {
            if (txtstart.Text.Trim().Length == 1)
            {
                String t = txtstart.Text;
                txtstart.Text = "0" + t;
            }
            if (txtmin.Text.Trim().Length == 1)
            {
                String t = txtmin.Text;
                txtmin.Text = "0" + t;
            }

            if (txtEndhr.Text.Trim().Length == 1)
            {
                String t = txtEndhr.Text;
                txtEndhr.Text = "0" + t;
            }
            if (txtEndmin.Text.Trim().Length == 1)
            {
                String t = txtEndmin.Text;
                txtEndmin.Text = "0" + t;
            }

            DateTime s = DateTime.Parse(txtDate.Text);
            DateTime emn = DateTime.Parse(txtEnddate.Text);
            DateTime startdate = DateTime.ParseExact(s.ToString("dd-MM-yyyy") + " " + txtstart.Text + ":" + txtmin.Text, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            DateTime endtate = DateTime.ParseExact(emn.ToString("dd-MM-yyyy") + " " + txtEndhr.Text + ":" + txtEndmin.Text, "dd-MM-yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            if (startdate <= endtate)
            {
                if (Request.QueryString["Qid"] != null)
                {
                    try
                    {
                        QuizBAL quizBAL = new QuizBAL();
                        QuizENT quizENT = new QuizENT();

                        quizENT.InstructorId = int.Parse(Request.QueryString["Qid"]);
                        quizENT.QuizName = txtQuizname.Text.Trim();
                        quizENT.Date= txtDate.Text.Trim();
                        quizENT.TimeDuration = int.Parse(txtTimeDuration.Text.Trim());
                        quizENT.NumOfQuestion = int.Parse(txtNumberofQues.Text.Trim());
                        quizENT.SubjectId = Int32.Parse(ddlSubject.SelectedValue);
                        quizENT.InstructorId = int.Parse(Session["id"].ToString());
                        quizENT.StartTime = txtstart.Text.Trim() + ":" + txtmin.Text;
                        quizENT.EndTime= txtEndhr.Text.Trim() + ":" + txtEndmin.Text;
                        quizENT.EndDate = txtEnddate.Text;

                        quizBAL.UpdateQuiz(quizENT);

                        Session["Quizid"] = int.Parse(Request.QueryString["Qid"].ToString());
                        Session["NumOfQues"] = int.Parse(txtNumberofQues.Text.Trim());
                        Response.Redirect("SelectQuestion.aspx?Qid=" + Request.QueryString["Qid"]);                       
                    }
                    catch (Exception ex)
                    {
                        lblErromsg.Text = ex.ToString();
                    }
                }
                else
                {

                    try
                    {
                        QuizBAL quizBAL = new QuizBAL();
                        QuizENT quizENT = new QuizENT();

                        quizENT.QuizName = txtQuizname.Text.Trim();
                        quizENT.Date = txtDate.Text.Trim();
                        quizENT.TimeDuration = int.Parse(txtTimeDuration.Text.Trim());
                        quizENT.NumOfQuestion = int.Parse(txtNumberofQues.Text.Trim());
                        quizENT.SubjectId = Int32.Parse(ddlSubject.SelectedValue);
                        quizENT.InstructorId = int.Parse(Session["id"].ToString());
                        quizENT.StartTime = txtstart.Text.Trim() + ":" + txtmin.Text;
                        quizENT.EndTime = txtEndhr.Text.Trim() + ":" + txtEndmin.Text;
                        quizENT.EndDate = txtEnddate.Text;

                        int Qid=quizBAL.InsertNewQuiz(quizENT);

                        Session["Quizid"] = Qid;
                        Session["NumOfQues"] = int.Parse(txtNumberofQues.Text.Trim());
                        Response.Redirect("SelectQuestion.aspx?Qid=" + Request.QueryString["Qid"]);
                    }
                    catch (Exception ex)
                    {
                        lblErromsg.Text = ex.ToString();
                    }
                }
            }
        }


    }
}