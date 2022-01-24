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
    public class QuestionInQuizDAL:DatabaseConfig
    {
        public List<int> GetQuestionForQuiz(int id, int Qnum)
        {
            List<int> Qlist = new List<int>();
            int i = 0;
            QuestionInQuizENT questionInQuizENT = new QuestionInQuizENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Question_For_Quiz]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while (objrdr.Read())
                        {
                            Qlist.Add(int.Parse(objrdr["QId"].ToString()));
                            i++;
                        }
                    }
                }

                return Qlist;
            }
        }




        public void SetQuestion(QuestionInQuizENT questionInQuizENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Set_Question]";
                    objCom.Parameters.Add("@QId", SqlDbType.Int).Value = questionInQuizENT.QId;
                    objCom.Parameters.Add("@QuizId", SqlDbType.Int).Value = questionInQuizENT.QuizId;
                    objCom.ExecuteNonQuery();
                }
            }
        }
    }
}
