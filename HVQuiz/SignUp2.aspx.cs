using BAL;
using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz
{
    public partial class SignUp2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblmsg.Text += "Hi, " + Session["name"].ToString() + " your UserName is " + Session["UserName"].ToString();
                fillState();
                ddlCity.Enabled = false;
                if (int.Parse(Request.QueryString["As"]) == 1)
                {
                    lblbdlogo.Visible = false;
                    lbldate.Text = "JoiningDate";
                }
            }
        }

        protected void btnSkip_Click(object sender, EventArgs e)
        {
            int person = int.Parse(Request.QueryString["As"]);
            if (person == 0)
            {
                Response.Redirect("AdminPanel/Student/Home.aspx");
            }
            else
            {
                Response.Redirect("AdminPanel/Instructor/InstructorHome.aspx");
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            int person = int.Parse(Request.QueryString["As"]);
            if (person == 0)
            {
                try
                {
                    ParticipateENT participateENT = new ParticipateENT();
                    ParticipateBAL participateBAL = new ParticipateBAL();

                    participateENT.ParticipateId= int.Parse(Session["id"].ToString());
                    participateENT.CourseName = txtCourse.Text;
                    participateENT.CollegeName = txtCollege.Text;
                    participateENT.BirthDate = txtBirthDate.Text;
                    participateENT.StateId = Int32.Parse(ddlState.SelectedValue);
                    participateENT.CityId = Int32.Parse(ddlCity.SelectedValue);
                    participateENT.Gender = rblGender.SelectedItem.Text;

                    participateBAL.AddMoredetails(participateENT);

                    Response.Redirect("AdminPanel/Student/Participate_Home.aspx");

                }
                catch (Exception loadddl)
                {
                    lblmsg.Text += loadddl;
                }
            }
            else
            {
                try
                {
                    InstructorENT instructorENT = new InstructorENT();
                    InstructorBAL instructorBAL = new InstructorBAL();
                    instructorENT.InstructorId = int.Parse(Session["id"].ToString());

                    instructorENT.InstructorId = int.Parse(Session["id"].ToString());
                    instructorENT.College = txtCollege.Text;
                    instructorENT.JoiningDate = txtBirthDate.Text;
                    instructorENT.StateId = Int32.Parse(ddlState.SelectedValue);
                    instructorENT.CityId = Int32.Parse(ddlCity.SelectedValue);
                    instructorENT.Gender = rblGender.SelectedItem.Text;

                    instructorBAL.AddMoredetails(instructorENT);

                    Response.Redirect("AdminPanel/Instructor/InstructorHome.aspx");
                }
                catch (Exception loadddl)
                {
                    lblmsg.Text += loadddl;
                }
            }

        }
        private void fillCity(int sid)
        {
            try
            {
                CityBAL cityBAL = new CityBAL();

                ddlCity.DataSource = cityBAL.SelectBYSID(sid);
                ddlCity.DataValueField = "CityId";
                ddlCity.DataTextField = "City_name";
                ddlCity.DataBind();
                ddlCity.Items.Insert(0, new ListItem("Select City","0"));
            }
            catch (Exception e)
            {
                lblmsg.Text += e;
            }
        }

        private void fillState()
        {
            try
            {
                StateBAL stateBAL = new StateBAL();

                ddlState.DataSource = stateBAL.SelctAll();
                ddlState.DataValueField = "StateId";
                ddlState.DataTextField = "StateName";
                ddlState.DataBind();
                ddlState.Items.Insert(0,new ListItem("Selact State","0"));
            }
            catch (Exception e)
            {
                lblmsg.Text += e;
            }

        }
        protected void changeValueOfddl(object sender, EventArgs e)
        {
            if (ddlState.SelectedValue == "0")
            {
                ddlCity.Enabled = false;
            }

            else
            {
                ddlCity.Items.Clear();
                ListItem l2 = new ListItem();
                l2.Value = "0";
                l2.Text = "Select City";
                ddlCity.Items.Add(l2);
                fillCity(int.Parse(ddlState.SelectedValue));
                ddlCity.Enabled = true;
            }

        }

    }
}