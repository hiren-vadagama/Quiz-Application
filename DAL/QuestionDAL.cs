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
    public class QuestionDAL : DatabaseConfig
    {
        public QuestionsENT GetQuestionByQId(int id)
        {
            QuestionsENT questionsENT = new QuestionsENT();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Question_By_QId]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        questionsENT.question= objrdr["question"].ToString();
                        questionsENT.correct_answer= objrdr["correct_answer"].ToString();
                        questionsENT.distractor1 = objrdr["distractor1"].ToString();
                        questionsENT.distractor2 = objrdr["distractor2"].ToString();
                        questionsENT.distractor3 = objrdr["distractor3"].ToString();
                        questionsENT.support = objrdr["support"].ToString();
                    }
                }
                objConn.Close();
            }
            return questionsENT;
        }

        public List<QuestionsENT> GetQuestionENTForQuiz(List<int> q)
        {
            List<QuestionsENT> questions = new List<QuestionsENT>();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                

                    for(int i=0; i<q.Count; i++)
                    {
                    using (SqlCommand objCom = objConn.CreateCommand())
                    {
                        objCom.CommandType = CommandType.StoredProcedure;
                        objCom.CommandText = "[Get_Question_By_QId]";
                        QuestionsENT questionsENT = new QuestionsENT();
                        objCom.Parameters.Add("@Id", SqlDbType.Int).Value = q[i];
                        using (SqlDataReader objrdr = objCom.ExecuteReader())
                        {
                            while (objrdr.Read())
                            {

                                questionsENT.question = objrdr["question"].ToString();
                                questionsENT.correct_answer = objrdr["correct_answer"].ToString();
                                questionsENT.distractor1 = objrdr["distractor1"].ToString();
                                questionsENT.distractor2 = objrdr["distractor2"].ToString();
                                questionsENT.distractor3 = objrdr["distractor3"].ToString();
                                questionsENT.support = objrdr["support"].ToString();
                            }
                        }
                        questions.Add(questionsENT);
                    }
                    
                }
                objConn.Close();
            }
            return questions;
        }

        public void InsertDataForQuiz(QuestionsENT questionENT)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[InsertDataForQuiz]";
                    objCom.Parameters.Add("@Q", SqlDbType.VarChar).Value = questionENT.question;
                    objCom.Parameters.Add("@C", SqlDbType.VarChar).Value = questionENT.correct_answer;
                    objCom.Parameters.Add("@D1", SqlDbType.VarChar).Value = questionENT.distractor1;
                    objCom.Parameters.Add("@D2", SqlDbType.VarChar).Value = questionENT.distractor2;
                    objCom.Parameters.Add("@D3", SqlDbType.VarChar).Value = questionENT.distractor3;
                    objCom.Parameters.Add("@S", SqlDbType.VarChar).Value = questionENT.support;
                    objCom.Parameters.Add("@SubjectId", SqlDbType.Int).Value = questionENT.SubjectId;

                    objCom.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetQuestionList()
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_QuestionList]";
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                    }
                }
            }
            return dt;
        }

        public List<int> selectRandowmClick(int N)
        {
            int upLimit = 0;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Max_Qid]";
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while (objrdr.Read())
                        {
                            upLimit = int.Parse(objrdr["Qid"].ToString());
                        }
                    }
                }
            }
            int Qnum = N;
            List<int> Qlist = new List<int>();
            int i = Qnum;
            while (i > 0)
            {
                Random a = new Random();
                int MyNumber = 0;
                MyNumber = a.Next(0, upLimit);
                SqlConnection objConn = new SqlConnection(ConnectionString);
                objConn.Open();
                SqlCommand objcom = new SqlCommand();
                objcom.Connection = objConn;
                objcom.CommandType = CommandType.StoredProcedure;
                objcom.CommandText = "Check_Question_isPresent";
                objcom.Parameters.Add("@Id", SqlDbType.Int).Value = MyNumber;
                SqlDataReader objrdr = objcom.ExecuteReader();

                if (objrdr.HasRows)
                {
                    if (!Qlist.Contains(MyNumber))
                    {
                        Qlist.Add(MyNumber);
                        i--;
                    }
                }
                objConn.Close();

            }
            return Qlist;
        }


        public List<int> selectQuestionForSubjectQuiz(int N,int SID)
        {
            int upLimit = 0;
            int lowLimit = 0;
           using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Min_Qid_SID]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = SID;

                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while (objrdr.Read())
                        {
                            lowLimit = int.Parse(objrdr["Qid"].ToString());
                        }
                    }
                }
            }
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[Get_Max_Qid_SID]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = SID;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while (objrdr.Read())
                        {
                            upLimit = int.Parse(objrdr["Qid"].ToString());
                        }
                    }
                }
            }
            int Qnum = N;
            List<int> Qlist = new List<int>();
            int i = Qnum;
            while (i > 0)
            {
                Random a = new Random();
                int MyNumber = 0;
                MyNumber = a.Next(lowLimit, upLimit);
                SqlConnection objConn = new SqlConnection(ConnectionString);
                objConn.Open();
                SqlCommand objcom = new SqlCommand();
                objcom.Connection = objConn;
                objcom.CommandType = CommandType.StoredProcedure;
                objcom.CommandText = "[Check_Question_isPresent]";
                objcom.Parameters.Add("@Id", SqlDbType.Int).Value = MyNumber;
                SqlDataReader objrdr = objcom.ExecuteReader();

                if (objrdr.HasRows)
                {
                    if (!Qlist.Contains(MyNumber))
                    {
                        Qlist.Add(MyNumber);
                        i--;
                    }
                }
                objConn.Close();

            }
            return Qlist;
        }

    }
}
