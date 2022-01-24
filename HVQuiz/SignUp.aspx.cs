using BAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HVQuiz
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signUpUser(object sender, EventArgs e)
        {
            SqlInt32 strid;
            if (rbStu.Checked == true)
            {
                try
                {
                    ParticipateENT participateENT_In = new ParticipateENT();
                    ParticipateBAL participateBAL = new ParticipateBAL();

                    participateENT_In.ParticipateName = txtUsername.Text.Trim();
                    participateENT_In.Password = txtPassword.Text.Trim();
                    participateENT_In.Email = txtEmail.Text.Trim();
                    participateENT_In.MobileNo = txtMobile.Text.Trim();


                    strid = participateBAL.SignUP(participateENT_In);

                    if(strid!=0)
                    {
                        Session["id"] = strid.ToString();
                        Session["name"] = txtUsername.Text;
                        Session["UserName"] = txtUsername.Text + strid;
                        Response.Redirect("SignUp2.aspx?As=" + 0);
                    }
                    else
                    {
                        lblmsg.Text = "Error";
                    }
                }
                catch (Exception exe)
                {
                    lblmsg.Text = "Error " + exe.Message;
                }

            }
            else
            {
                try
                {
                    InstructorENT instructorENT_In = new InstructorENT();
                    InstructorBAL instructorBAL = new InstructorBAL();

                    instructorENT_In.InstructorName = txtUsername.Text.Trim();
                    instructorENT_In.Password = txtPassword.Text.Trim();
                    instructorENT_In.Email = txtEmail.Text.Trim();
                    instructorENT_In.MobileNo = txtMobile.Text.Trim();


                    strid = instructorBAL.SignUP(instructorENT_In);

                    if (strid != 0)
                    {
                        Session["id"] = strid.ToString();
                        Session["name"] = txtUsername.Text;
                        Session["UserName"] = txtUsername.Text + strid;
                        Response.Redirect("SignUp2.aspx?As=" + 1);
                    }
                    else
                    {
                        lblmsg.Text = "Error";
                    }
                }
                catch (Exception exe)
                {
                    lblmsg.Text = "Error " + exe.Message;
                }
            }
        }
    }
}