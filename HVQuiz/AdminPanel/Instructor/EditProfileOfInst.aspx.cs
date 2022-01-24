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
    public partial class EditProfileOfInst : System.Web.UI.Page
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
                InstructorENT instructorENT = new InstructorENT();
                InstructorBAL instructorBAL = new InstructorBAL();
                instructorENT = instructorBAL.GetInstructorByInstructorId(int.Parse(Session["id"].ToString()));


                txtDate.Text = Convert.ToDateTime(instructorENT.JoiningDate).ToString("yyyy-MM-dd");
                txtInstructorName.Text = instructorENT.InstructorName.ToString();
                txtCollege.Text = instructorENT.College.ToString();
                txtEmail.Text = instructorENT.Email.ToString();
                txtPassword.Text = instructorENT.Password.ToString();
                if (instructorENT.Gender.ToString() == "Male")
                {
                    rblGender.SelectedValue = "1";
                }
                if (instructorENT.Gender.ToString() == "Female")
                {
                    rblGender.SelectedValue = "2";
                }
                if (instructorENT.Gender.ToString() == "Other")
                {
                    rblGender.SelectedValue = "3";
                }
                txtMobileNo.Text = instructorENT.MobileNo.ToString();
                ddlState.SelectedValue = instructorENT.StateId.ToString();
                fillCity(int.Parse(ddlState.SelectedValue));
                ddlCity.SelectedValue = instructorENT.CityId.ToString();

            }
            catch (Exception e)
            {
                lblErromsg.Text = e.ToString();
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
                InstructorBAL instructorBAL = new InstructorBAL();
                InstructorENT instructorENT = new InstructorENT();

              
                instructorENT.InstructorId = int.Parse(Session["id"].ToString());
                instructorENT.InstructorName = txtInstructorName.Text.Trim();
                instructorENT.Email = txtEmail.Text.Trim();
                instructorENT.Password = txtPassword.Text.Trim();
                instructorENT.MobileNo = txtMobileNo.Text.Trim();
                instructorENT.College = txtCollege.Text.Trim();
                instructorENT.JoiningDate = txtDate.Text.Trim();
                instructorENT.StateId = int.Parse(ddlState.SelectedValue);
                instructorENT.CityId = int.Parse(ddlCity.SelectedValue);
                instructorENT.Gender = rblGender.SelectedItem.Text;

                instructorBAL.Edit_Instructor_data(instructorENT);
                Response.Redirect("Instructor_Home.aspx");
            }
            catch (Exception ex)
            {
                lblErromsg.Text = ex.ToString();
            }
        }
    }
}