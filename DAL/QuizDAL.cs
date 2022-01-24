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
    public class QuizDAL : DatabaseConfig
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

        public DataTable getQuizByParticipateId(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Quiz_By_StudentId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);

                    }
                }
            }
            return dt;
        }

        public DataTable getQuizforPerformance(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[getQuiz_for_Performance]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);

                    }
                }
            }
            return dt;
        }

        public QuizENT GetQuizByQuizId(int id)
        {
            QuizENT quizENT = new QuizENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Quiz_By_QuizId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        if (objrdr.HasRows)
                        {
                            while (objrdr.Read())
                            {
                                quizENT.QuizName = objrdr["QuizName"].ToString();
                                quizENT.TimeDuration = int.Parse(objrdr["TimeDuration"].ToString());
                                quizENT.TotalMarks = int.Parse(objrdr["TotalMarks"].ToString());
                                quizENT.NumOfQuestion= int.Parse(objrdr["NumOfQuestion"].ToString());
                                quizENT.InstructorId= int.Parse(objrdr["InstructorId"].ToString());
                                quizENT.SubjectId= int.Parse(objrdr["SubjectId"].ToString());
                                quizENT.StartTime = objrdr["StartTime"].ToString();
                                quizENT.Date = objrdr["Date"].ToString();
                                quizENT.EndTime = objrdr["EndTime"].ToString();
                                quizENT.EndDate = objrdr["EndDate"].ToString();
                            }
                        }
                    }
                }
            }
            return quizENT;
        }

        public QuizENT GetQuizByInstructorId(int id)
        {
            QuizENT quizENT = new QuizENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Quiz_By_InstructorId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        if (objrdr.HasRows)
                        {
                            while (objrdr.Read())
                            {
                                quizENT.QuizName = objrdr["QuizName"].ToString();
                                quizENT.TimeDuration = int.Parse(objrdr["TimeDuration"].ToString());
                                quizENT.TotalMarks = int.Parse(objrdr["TotalMarks"].ToString());
                                quizENT.NumOfQuestion = int.Parse(objrdr["NumOfQuestion"].ToString());
                                quizENT.InstructorId = int.Parse(objrdr["InstructorId"].ToString());
                                quizENT.SubjectId = int.Parse(objrdr["SubjectId"].ToString());
                                quizENT.StartTime = objrdr["StartTime"].ToString();
                                quizENT.Date = objrdr["Date"].ToString();
                                quizENT.EndTime = objrdr["EndTime"].ToString();
                                quizENT.EndDate = objrdr["EndDate"].ToString();
                            }
                        }
                    }
                }
            }
            return quizENT;
        }

        public DataTable GetQuizByInstructorId_DataTable(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Quiz_By_InstructorId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                    }
                }
            }
            return dt;
        }

        public void DeleteQuizByQuizId(int id)
        {
            QuizENT quizENT = new QuizENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Delete_Quiz_By_QuizId]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public void UpdateQuiz(QuizENT quizENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Update_Quiz]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Value = quizENT.QuizId;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = quizENT.QuizName;
                    objCom.Parameters.Add("@Date", SqlDbType.VarChar).Value = quizENT.Date;
                    objCom.Parameters.Add("@TD", SqlDbType.Int).Value = quizENT.TimeDuration;
                    objCom.Parameters.Add("@Numq", SqlDbType.Int).Value = quizENT.NumOfQuestion;
                    objCom.Parameters.Add("@Sub", SqlDbType.Int).Value = quizENT.SubjectId;
                    objCom.Parameters.Add("@InsId", SqlDbType.Int).Value = quizENT.InstructorId;
                    objCom.Parameters.Add("@Strat", SqlDbType.VarChar).Value = quizENT.StartTime;
                    objCom.Parameters.Add("@EndTime", SqlDbType.VarChar).Value = quizENT.EndTime;
                    objCom.Parameters.Add("@EndDate", SqlDbType.Date).Value = quizENT.EndDate;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public int InsertNewQuiz(QuizENT quizENT)
        {
            int id;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Insert_NewQuiz]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                    objCom.Parameters.Add("@Name", SqlDbType.VarChar).Value = quizENT.QuizName;
                    objCom.Parameters.Add("@Date", SqlDbType.VarChar).Value = quizENT.Date;
                    objCom.Parameters.Add("@TD", SqlDbType.Int).Value = quizENT.TimeDuration;
                    objCom.Parameters.Add("@Numq", SqlDbType.Int).Value = quizENT.NumOfQuestion;
                    objCom.Parameters.Add("@Sub", SqlDbType.Int).Value = quizENT.SubjectId;
                    objCom.Parameters.Add("@InsId", SqlDbType.Int).Value = quizENT.InstructorId;
                    objCom.Parameters.Add("@Strat", SqlDbType.VarChar).Value = quizENT.StartTime;
                    objCom.Parameters.Add("@EndTime", SqlDbType.VarChar).Value = quizENT.EndTime;
                    objCom.Parameters.Add("@EndDate", SqlDbType.Date).Value = quizENT.EndDate;
                    objCom.ExecuteNonQuery();
                    id= int.Parse(objCom.Parameters["@id"].Value.ToString());
                }
            }
            return id;
        }
    }
}
