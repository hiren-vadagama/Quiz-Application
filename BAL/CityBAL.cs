using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class CityBAL
    {
        protected string _Message;

        public CityBAL()
        {

        }

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

        public DataTable SelectBYSID(int stateid)
        {
            CityDAL cityDAL =new CityDAL();
            return cityDAL.SelectBYSID(stateid);
        }

    }
}