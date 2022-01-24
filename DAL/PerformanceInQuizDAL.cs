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
    public class PerformanceInQuizDAL:DatabaseConfig
    {
        public void insertPercentage(PerformanceInQuizENT performanceInQuizENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[insertPercentage]";
                    objCom.Parameters.Add("@PID", SqlDbType.Int).Value = performanceInQuizENT.ParticipateId;
                    objCom.Parameters.Add("@QID", SqlDbType.Int).Value = performanceInQuizENT.QuizId;
                    objCom.Parameters.Add("@PER", SqlDbType.Decimal).Value = performanceInQuizENT.Percentage;
                    objCom.ExecuteNonQuery();
                }
            }
        }
        public void DeleteStudentforQuiz(int id)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Delete_Student_for_Quiz]";
                    objCom.Parameters.Add("@QuizId", SqlDbType.Int).Value = id;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public void SelectedStuForQuiz(PerformanceInQuizENT performanceInQuizENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Selected_Stu_For_Quiz]";
                    objCom.Parameters.Add("@PId", SqlDbType.Int).Value = performanceInQuizENT.ParticipateId;
                    objCom.Parameters.Add("@QuizId", SqlDbType.Int).Value = performanceInQuizENT.QuizId;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetSelectedStudentForQuiz(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Selected_Student_For_Quiz]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                    }
                    return dt;
                }
            }
        }

        public DataTable GetStudentperformancedata(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Student_performance_data]";
                    objCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
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
