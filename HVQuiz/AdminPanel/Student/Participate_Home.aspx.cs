using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Student
{
    public partial class Participate_Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lbluser.Text += Session["name"].ToString();
            }
            try
            {
                QuizBAL quizBAL = new QuizBAL();
                    
                repeat.DataSource= quizBAL.getQuizByParticipateId(int.Parse(Session["id"].ToString()));
                repeat.DataBind();

                PerformanceInSubjectBAL performanceInSubjectBAL = new PerformanceInSubjectBAL();
                repeatForSubQuiz.DataSource = performanceInSubjectBAL.GetJoiningSubjectByPID(int.Parse(Session["id"].ToString()));
                repeatForSubQuiz.DataBind();

                repeatForSubQuizNonSelected.DataSource = performanceInSubjectBAL.GetNonJoiningSubjectByPID(int.Parse(Session["id"].ToString()));
                repeatForSubQuizNonSelected.DataBind();

                foreach (RepeaterItem item in repeatForSubQuiz.Items)
                {
                    var tbSelected = (Label)item.FindControl("LevelId");
                    var tbstr1 = (Label)item.FindControl("str1");
                    var tbstr2 = (Label)item.FindControl("str2");
                    var tbstr3 = (Label)item.FindControl("str3");
                    var tbstr4 = (Label)item.FindControl("str4");
                    var tbstr5 = (Label)item.FindControl("str5");
                    var SubjectId = (Label)item.FindControl("lblSubId");
                    var SubQuizlogo = (Label)item.FindControl("lblSublogo");
                    if (tbSelected.Text == "0")
                    {
                    }
                    else if (tbSelected.Text == "1")
                    {
                        tbstr1.CssClass = "fas fa-star";
                    }
                    else if(tbSelected.Text == "2")
                    {
                        tbstr1.CssClass = "fas fa-star";
                        tbstr2.CssClass = "fas fa-star";
                    }
                    else if(tbSelected.Text == "3")
                    {
                        tbstr1.CssClass = "fas fa-star";
                        tbstr2.CssClass = "fas fa-star";
                        tbstr3.CssClass = "fas fa-star";
                    }
                    else if(tbSelected.Text == "4")
                    {
                        tbstr1.CssClass = "fas fa-star";
                        tbstr2.CssClass = "fas fa-star";
                        tbstr3.CssClass = "fas fa-star";
                        tbstr4.CssClass = "fas fa-star";
                    }
                    else if(tbSelected.Text == "5")
                    {
                        tbstr1.CssClass = "fas fa-star";
                        tbstr2.CssClass = "fas fa-star";
                        tbstr3.CssClass = "fas fa-star";
                        tbstr4.CssClass = "fas fa-star";
                        tbstr5.CssClass = "fas fa-star";
                    }
                    else
                    {

                    }

                    if (SubjectId.Text == "1")
                    {
                        SubQuizlogo.CssClass = "fas fa-calculator";
                    }
                    else if (SubjectId.Text == "2")
                    {
                        SubQuizlogo.CssClass = "fab fa-java";
                    }
                    else if (SubjectId.Text == "3")
                    {
                        SubQuizlogo.CssClass = "fab fa-cuttlefish";
                    }
                    else if (SubjectId.Text == "4")
                    {
                        SubQuizlogo.CssClass = "fas fa-database";
                    }
                    else if (SubjectId.Text == "5")
                    {
                        SubQuizlogo.CssClass = "fas fa-network-wired";
                    }
                    else if (SubjectId.Text == "6")
                    {
                        SubQuizlogo.CssClass = "fab fa-python";
                    }
                    else if (SubjectId.Text == "7")
                    {
                        SubQuizlogo.CssClass = "fab fa-js";
                    }
                    else if (SubjectId.Text == "8")
                    {
                        SubQuizlogo.CssClass = "fab fa-angular";
                    }
                    else if (SubjectId.Text == "9")
                    {
                        SubQuizlogo.CssClass = "fab fa-html5";
                    }
                    else
                    {

                    }
                }

                foreach (RepeaterItem item in repeatForSubQuizNonSelected.Items)
                {
                    var SubjectId = (Label)item.FindControl("lbNonlSubId");
                    var SubQuizlogo = (Label)item.FindControl("lblSublogoForNon");


                    if (SubjectId.Text == "1")
                    {
                        SubQuizlogo.CssClass = "fas fa-calculator";
                    }
                    else if (SubjectId.Text == "2")
                    {
                        SubQuizlogo.CssClass = "fab fa-java";
                    }
                    else if (SubjectId.Text == "3")
                    {
                        SubQuizlogo.CssClass = "fab fa-cuttlefish";
                    }
                    else if (SubjectId.Text == "4")
                    {
                        SubQuizlogo.CssClass = "fas fa-database";
                    }
                    else if (SubjectId.Text == "5")
                    {
                        SubQuizlogo.CssClass = "fas fa-network-wired";
                    }
                    else if (SubjectId.Text == "6")
                    {
                        SubQuizlogo.CssClass = "fab fa-python";
                    }
                    else if (SubjectId.Text == "7")
                    {
                        SubQuizlogo.CssClass = "fab fa-js";
                    }
                    else if (SubjectId.Text == "8")
                    {
                        SubQuizlogo.CssClass = "fab fa-angular";
                    }
                    else if (SubjectId.Text == "9")
                    {
                        SubQuizlogo.CssClass = "fab fa-html5";
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception loadddl)
            {
                lblmsg.Text += loadddl.ToString();
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
        protected void btnLogout(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("../../Default.aspx");
        }

        protected void LinkButton1_Command(object sender, CommandEventArgs e)
        {
            String start = null;
            String min = null;
            String hh = null;
            String Endmin = null;
            String Endhh = null;
            String temp = null;
            String temp2 = null;
            String end = null;
            if (e.CommandName == "MyUpdate")
            {
                try
                {
                    QuizENT quizENT = new QuizENT();
                    QuizBAL quizBAL = new QuizBAL();
                    quizENT=quizBAL.GetQuizByQuizId(int.Parse(e.CommandArgument.ToString()));
                    temp = quizENT.StartTime.ToString();
                    start = quizENT.Date.ToString();
                    temp2 = quizENT.EndTime.ToString();
                    end = quizENT.EndDate.ToString();
                    hh = temp.Substring(0, 2);
                    min = temp.Substring(3);
                    Endhh = temp2.Substring(0, 2);
                    Endmin = temp2.Substring(3);
                    DateTime currentTime= GetDateTime();
                    DateTime startdate = DateTime.ParseExact(start.Substring(0, 10) + " " + hh + ":" + min, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime endtate = DateTime.ParseExact(end.Substring(0, 10) + " " + Endhh + ":" + Endmin, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);

                    if (currentTime >= startdate && currentTime <= endtate)
                    {
                        Response.Redirect("MCQQuiz.aspx?Qid=" + e.CommandArgument);
                    }
                    else
                    {
                        litScript.Text = "<script src='https://unpkg.com/sweetalert/dist/sweetalert.min.js'></script><script type='text/javascript'>swal('Quiz Not Start Yet');</script>";
                    }


                }
                catch (Exception e2)
                {
                    lblmsg.Text += e2.ToString();
                }
            }
        }

        protected void OnCommandForSubQuiz(object sender, CommandEventArgs e)
        {
            
            if (e.CommandName == "MyUpdateForSubQuiz")
            {
                try
                {

                        Response.Redirect("Subject_Quiz.aspx?SubId=" + e.CommandArgument);


                }
                catch (Exception e2)
                {
                    lblmsg.Text += e2.ToString();
                }
            }
        }

        protected void OnCommandForSubQuizNonSelected(object sender, CommandEventArgs e)
        {

            if (e.CommandName == "MyUpdateForSubQuizNonSelected")
            {
                try
                {
                    PerformanceInSubjectBAL performanceInSubjectBAL = new PerformanceInSubjectBAL();
                    performanceInSubjectBAL.SelectForPracticeSubjectByPID(int.Parse(Session["id"].ToString()),int.Parse(e.CommandArgument.ToString()));
                    Response.Redirect("Participate_Home.aspx");
                }
                catch (Exception e2)
                {
                    lblmsg.Text += e2.ToString();
                }
            }
        }

    }
}