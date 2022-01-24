using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class StateENT
    {
        protected SqlInt32 _StateID;

        public SqlInt32 StateID
        {
            get
            {
                return _StateID;
            }
            set
            {
                _StateID = value;
            }
        }

        protected SqlString _StateName;

        public SqlString StateName
        {
            get
            {
                return _StateName;
            }
            set
            {
                _StateName = value;
            }
        }
    }
}