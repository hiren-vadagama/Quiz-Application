using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class SubjectENT
    {
        protected SqlInt32 _SubjectId;

        public SqlInt32 SubjectId
        {
            get
            {
                return _SubjectId;
            }
            set
            {
                _SubjectId = value;
            }
        }

        protected SqlString _SubjectName;

        public SqlString SubjectName
        {
            get
            {
                return _SubjectName;
            }
            set
            {
                _SubjectName = value;
            }
        }

    }
}