using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    class PerformanceInSubjectENT
    {
        protected SqlInt32 _ParticipateId;

        public SqlInt32 ParticipateId
        {
            get
            {
                return _ParticipateId;
            }
            set
            {
                _ParticipateId = value;
            }
        }

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
    }
}
