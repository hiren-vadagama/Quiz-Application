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
    public class CityDAL : DatabaseConfig
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
        public CityDAL()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public DataTable SelectBYSID(int StateId)
        {
            DataTable dt = new DataTable();
            using (SqlConnection objConn = new SqlConnection(ConnectionString))
            {
                objConn.Open();
                using (SqlCommand objCmd = objConn.CreateCommand())
                {
                    objCmd.CommandType = CommandType.StoredProcedure;
                    objCmd.CommandText = "City_From_dropdown";
                    objCmd.Parameters.Add("@SID", SqlDbType.Int).Value = StateId;
                    using (SqlDataReader objRed = objCmd.ExecuteReader())
                    {

                        dt.Load(objRed);
                        objConn.Close();
                        objRed.Close();
                    }
                }
            }
            return dt;
        }
    }
}