using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PerformanceInSubjectDAL:DatabaseConfig
    {
        public DataTable GetJoiningSubjectByPID(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "PerformanceInSubject_GetJointSubByPID";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                        objConn.Close();                   
                    }
                }
            }
            return dt;
        }

        public DataTable GetNonJoiningSubjectByPID(int id)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[PerformanceInSubject_Get_Non_JointSubByPID]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        dt.Load(objrdr);
                        objConn.Close();
                    }
                }
            }
            return dt;
        }

        public void SelectForPracticeSubjectByPID(int id,int SID)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[PerformanceInSubject_SelectForPracticeSubjectByPID]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    objCom.Parameters.Add("@SID", SqlDbType.Int).Value = SID;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public void insertScoreForSubQuiz(int id, int per)
        {
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "PerformanceInSubject_InsertScore";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    objCom.Parameters.Add("@Sco", SqlDbType.Int).Value = per;
                    objCom.ExecuteNonQuery();
                }
            }
        }

        public int PerformanceInSubjectGetPSID (int id, int SID)
        {
            int PSID=0;
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                using (SqlCommand objCom = objConn.CreateCommand())
                {
                    objConn.Open();
                    objCom.CommandType = CommandType.StoredProcedure;
                    objCom.CommandText = "[PerformanceInSubject_GetPSID]";
                    objCom.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    objCom.Parameters.Add("@SID", SqlDbType.Int).Value = SID;
                    using (SqlDataReader objrdr = objCom.ExecuteReader())
                    {
                        while(objrdr.Read())
                        {
                            PSID = int.Parse(objrdr["PSID"].ToString());
                        }
                    }
                }
            }
            return PSID;
        }

    }
}
