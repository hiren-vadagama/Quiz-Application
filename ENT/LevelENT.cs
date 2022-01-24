using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class LevelENT
    {
        LevelENT()
        {

        }

        protected SqlInt32 _LevelId;
        public SqlInt32 LevelId
        {
            get
            {
                return _LevelId;
            }
            set
            {
                _LevelId = value;
            }
        }


        protected SqlString _LevelName;
        public SqlString LevelName
        {
            get
            {
                return _LevelName;
            }
            set
            {
                _LevelName = value;
            }
        }

    }
}