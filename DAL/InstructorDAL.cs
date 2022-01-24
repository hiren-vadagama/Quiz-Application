using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InstructorDAL : DatabaseConfig
    {
        protected string _Message;

        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        public InstructorENT loginAsInstructor(String txtUsername, String txtPassword)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[LoginAsInstructor]";
                    objCom.Parameters.Add("@U", SqlDbType.VarChar).Value = txtUsername;
                    objCom.Parameters.Add("@P", SqlDbType.VarChar).Value = txtPassword;

                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        if (objrdr.HasRows)
                        {
                            InstructorENT instructor = new InstructorENT();
                            while (objrdr.Read())
                            {
                                instructor.InstructorId = int.Parse(objrdr["InstructorId"].ToString());
                                instructor.InstructorName = objrdr["InstructorName"].ToString();
                            }
                            objConn.Close();

                            return instructor;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public int SignUP(InstructorENT instructor)
        {
            int strid = 0;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[PR_Instructor_Insert]";

                    objCom.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = instructor.InstructorName;
                    objCom.Parameters.Add("@Password", SqlDbType.VarChar).Value = instructor.Password;
                    objCom.Parameters.Add("@Email", SqlDbType.VarChar).Value = instructor.Email;
                    objCom.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = instructor.MobileNo;

                    objCom.ExecuteNonQuery();
                    strid = int.Parse(objCom.Parameters["@id"].Value.ToString());

                    objConn.Close();

                    return strid;
                }
            }
        }

        public void AddMoredetails(InstructorENT instructor)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[PR_Instructor_Insert_MoreDetails]";

                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = instructor.InstructorId;
                    objCom.Parameters.Add("@CName", SqlDbType.VarChar).Value = instructor.InstructorName;
                    objCom.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = instructor.JoiningDate;
                    objCom.Parameters.Add("@StateId", SqlDbType.Int).Value = instructor.StateId;
                    objCom.Parameters.Add("@CityId", SqlDbType.Int).Value = instructor.CityId;
                    objCom.Parameters.Add("@Gender", SqlDbType.VarChar).Value = instructor.Gender;
                    objCom.ExecuteNonQuery();

                    objConn.Close();
                }
            }
        }

        public InstructorENT GetInstructorByInstructorId(int id)
        {
            InstructorENT instructorENT = new InstructorENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Instructor_By_InstructorId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while (objrdr.Read())
                        {
                            instructorENT.CityId = int.Parse(objrdr["CityId"].ToString());
                            instructorENT.StateId = int.Parse(objrdr["StateId"].ToString());
                            instructorENT.Experince = int.Parse(objrdr["Experince"].ToString());
                            instructorENT.College = objrdr["College"].ToString();
                            instructorENT.Email = objrdr["Email"].ToString();
                            instructorENT.Gender = objrdr["Gender"].ToString();
                            instructorENT.MobileNo = objrdr["MobileNo"].ToString();
                            instructorENT.InstructorName = objrdr["InstructorName"].ToString();
                            instructorENT.Password = objrdr["Password"].ToString();
                            instructorENT.UserName = objrdr["UserName"].ToString();
                            instructorENT.JoiningDate = objrdr["JoiningDate"].ToString();
                        }

                    }
                    return instructorENT;
                }
            }
        }

        public DataTable GetInstructorByInstructorId_DataTable(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Instructor_By_InstructorId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);

                    }
                    return dt;
                }
            }
        }

        public void Edit_Instructor_data(InstructorENT instructorENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Edit_Instructor_data]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Value = instructorENT.InstructorId;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = instructorENT.InstructorName;
                    objCom.Parameters.Add("@Email", SqlDbType.VarChar).Value = instructorENT.Email;
                    objCom.Parameters.Add("@Password", SqlDbType.VarChar).Value = instructorENT.Password;
                    objCom.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = instructorENT.MobileNo;
                    objCom.Parameters.Add("@CName", SqlDbType.VarChar).Value = instructorENT.College;
                    objCom.Parameters.Add("@JoinDate", SqlDbType.Date).Value = instructorENT.JoiningDate;
                    objCom.Parameters.Add("@StateId", SqlDbType.Int).Value = instructorENT.StateId;
                    objCom.Parameters.Add("@CityId", SqlDbType.Int).Value = instructorENT.CityId;
                    objCom.Parameters.Add("@Gender", SqlDbType.VarChar).Value = instructorENT.Gender;
                    objCom.ExecuteNonQuery();
                }
            }
        }
    }
}