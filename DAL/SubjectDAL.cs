using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SubjectDAL:DatabaseConfig
    {
        public DataTable SelectAll()
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {

                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = "Subject_From_dropdown";
                    using (SqlDataReader objRed = objCmd.ExecuteReader())
                    {
                        dt.Load(objRed);
                        objConn.Close();
                    }
                }
            }
            return dt;
        }
    }
}
