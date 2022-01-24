using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz.AdminPanel.Student
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillState();
                getDataForUpdate();
            }

        }

        private void getDataForUpdate()
        {
            try
            {
                ParticipateENT participateENT = new ParticipateENT();
                ParticipateBAL participateBAL = new ParticipateBAL();
                participateENT = participateBAL.GetStudentByStudentId(int.Parse(Session["id"].ToString()));
                txtDate.Text = Convert.ToDateTime(participateENT.BirthDate).ToString("yyyyy-MM-dd");
                txtParticipatename.Text = participateENT.ParticipateName.ToString();
                txtCollege.Text = participateENT.CollegeName.ToString();
                txtEmail.Text = participateENT.Email.ToString();
                txtPassword.Text = participateENT.Password.ToString();
                txtCourseName.Text = participateENT.CourseName.ToString();
                if (participateENT.Gender.ToString() == "Male")
                {
                    rblGender.SelectedValue = "1";
                }
                if (participateENT.Gender.ToString() == "Female")
                {
                    rblGender.SelectedValue = "2";
                }
                if (participateENT.Gender.ToString() == "Other")
                {
                    rblGender.SelectedValue = "3";
                }
                txtMobileNo.Text = participateENT.MobileNo.ToString();
                ddlState.SelectedValue = participateENT.StateId.ToString();
                fillCity(int.Parse(ddlState.SelectedValue));
                ddlCity.SelectedValue = participateENT.CityId.ToString();
            }
            catch (Exception loadddl)
            {
                lblErromsg.Text += loadddl.ToString();
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
                ddlCity.Items.Insert(0, new ListItem("Select City", "0"));
            }
            catch (Exception e)
            {
                lblErromsg.Text += e;
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
                ddlState.Items.Insert(0, new ListItem("Selact State", "0"));
            }
            catch (Exception e)
            {
                lblErromsg.Text += e;
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
        protected void btnEdit(object sender, EventArgs e)
        {
            try
            {
                ParticipateBAL participateBAL = new ParticipateBAL();
                ParticipateENT participateENT = new ParticipateENT();

                
                participateENT.ParticipateId = int.Parse(Session["id"].ToString());
                participateENT.ParticipateName = txtParticipatename.Text.Trim();
                participateENT.Email = txtEmail.Text.Trim();
                participateENT.CourseName = txtCourseName.Text.Trim();
                participateENT.Password = txtPassword.Text.Trim();
                participateENT.MobileNo = txtMobileNo.Text.Trim();
                participateENT.CollegeName = txtCollege.Text.Trim();
                participateENT.BirthDate = txtDate.Text;
                participateENT.StateId = int.Parse(ddlState.SelectedValue);
                participateENT.CityId = int.Parse(ddlCity.SelectedValue);
                participateENT.Gender = rblGender.SelectedItem.Text;

                participateBAL.EditStudentdata(participateENT);
                Response.Redirect("Participate_Dashboard.aspx");
            }
            catch (Exception ex)
            {
                lblErromsg.Text = ex.ToString();
            }
        }
    }
}