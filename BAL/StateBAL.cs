using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{

    public class StateBAL
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

        public DataTable SelctAll()
        {
            StateDAL stateDAL = new StateDAL();
            return stateDAL.SelectAll();
        }
    }



}
