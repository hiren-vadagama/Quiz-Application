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
    public class ParticipateDAL : DatabaseConfig
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

        public ParticipateENT loginAsStudent(String txtUsername, String txtPassword)
        {
            ParticipateENT participate = new ParticipateENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "LoginAsStu";
                    objCom.Parameters.Add("@U", SqlDbType.VarChar).Value = txtUsername;
                    objCom.Parameters.Add("@P", SqlDbType.VarChar).Value = txtPassword;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        if (objrdr.HasRows)
                        {
                            while (objrdr.Read())
                            {
                                participate.ParticipateId = int.Parse(objrdr["ParticipateId"].ToString());
                                participate.ParticipateName = objrdr["ParticipateName"].ToString();
                            }
                            objConn.Close();
                        }
                    }
                }
            }
            return participate;
        }

        public int SignUP(ParticipateENT participate)
        {
            int strid = 0;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "PR_Participate_Insert";

                    objCom.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = participate.ParticipateName;
                    objCom.Parameters.Add("@Password", SqlDbType.VarChar).Value = participate.Password;
                    objCom.Parameters.Add("@Email", SqlDbType.VarChar).Value = participate.Email;
                    objCom.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = participate.MobileNo;

                    objCom.ExecuteNonQuery();

                    strid = int.Parse(objCom.Parameters["@id"].Value.ToString());
                    objConn.Close();

                }
            }
            return strid;
        }

        public void AddMoredetails(ParticipateENT participate)
        {
            int strid = 0;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "PR_Participate_Insert_MoreDetails";

                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = participate.ParticipateId;
                    objCom.Parameters.Add("@Course", SqlDbType.VarChar).Value = participate.CourseName;
                    objCom.Parameters.Add("@CName", SqlDbType.VarChar).Value = participate.CollegeName;
                    objCom.Parameters.Add("@BirthDate", SqlDbType.VarChar).Value = participate.BirthDate;
                    objCom.Parameters.Add("@StateId", SqlDbType.Int).Value = participate.StateId;
                    objCom.Parameters.Add("@CityId", SqlDbType.Int).Value = participate.CityId;
                    objCom.Parameters.Add("@Gender", SqlDbType.VarChar).Value = participate.Gender;
                    objCom.ExecuteNonQuery();
                    objConn.Close();
                }
            }
        }

        public ParticipateENT GetStudentByStudentId(int id)
        {
            ParticipateENT participateENT = new ParticipateENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Student_By_StudentId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while(objrdr.Read())
                        {
                            participateENT.CityId = int.Parse(objrdr["CityId"].ToString());
                            participateENT.StateId = int.Parse(objrdr["StateId"].ToString());
                            participateENT.LevelId = int.Parse(objrdr["LevelId"].ToString());
                            participateENT.Age = int.Parse(objrdr["Age"].ToString());
                            participateENT.CollegeName = objrdr["CollegeName"].ToString();
                            participateENT.CourseName = objrdr["CourseName"].ToString();
                            participateENT.Email = objrdr["Email"].ToString();
                            participateENT.Gender = objrdr["Gender"].ToString();
                            participateENT.MobileNo = objrdr["MobileNo"].ToString();
                            participateENT.ParticipateName = objrdr["ParticipateName"].ToString();
                            participateENT.Password = objrdr["Password"].ToString();
                            participateENT.UserName = objrdr["UserName"].ToString();
                            participateENT.BirthDate = objrdr["BirthDate"].ToString();
                        }

                    }
                    return participateENT;
                }
            }
        }

        public DataTable GetStudentByStudentId_DataTable(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Student_By_StudentId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                    }
                    return dt;
                }
            }
        }

        public void EditStudentdata(ParticipateENT participateENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Edit_Student_data]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Value = participateENT.ParticipateId;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = participateENT.ParticipateName;
                    objCom.Parameters.Add("@Email", SqlDbType.VarChar).Value = participateENT.Email;
                    objCom.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = participateENT.CourseName;
                    objCom.Parameters.Add("@Password", SqlDbType.VarChar).Value = participateENT.Password;
                    objCom.Parameters.Add("@MobileNo", SqlDbType.VarChar).Value = participateENT.MobileNo;
                    objCom.Parameters.Add("@CName", SqlDbType.VarChar).Value = participateENT.CollegeName;
                    objCom.Parameters.Add("@BirthDate", SqlDbType.Date).Value = participateENT.BirthDate;
                    objCom.Parameters.Add("@StateId", SqlDbType.Int).Value = participateENT.StateId;
                    objCom.Parameters.Add("@CityId", SqlDbType.Int).Value = participateENT.CityId;
                    objCom.Parameters.Add("@Gender", SqlDbType.VarChar).Value = participateENT.Gender;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetQuizPreformancebyStudentId(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Quiz_Preformance_by_StudentId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);

                    }
                }
            }
            return dt;
        }

        public DataTable ListOfAllStudent()
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[ListOfAllStudent]";
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                    }
                    return dt;
                }
            }
        }

    }
}