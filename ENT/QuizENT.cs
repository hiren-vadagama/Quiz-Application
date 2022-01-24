using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class QuizENT
    {

        protected SqlInt32 _QuizId;

        public SqlInt32 QuizId
        {
            get
            {
                return _QuizId;
            }
            set
            {
                _QuizId = value;
            }
        }

        protected SqlString _QuizName;

        public SqlString QuizName
        {
            get
            {
                return _QuizName;
            }
            set
            {
                _QuizName = value;
            }
        }

        protected String _Date;

        public String Date
        {
            get
            {
                return _Date;
            }
            set
            {
                _Date = value;
            }
        }

        protected SqlInt32 _TimeDuration;

        public SqlInt32 TimeDuration
        {
            get
            {
                return _TimeDuration;
            }
            set
            {
                _TimeDuration = value;
            }
        }

        protected SqlInt32 _NumOfQuestion;

        public SqlInt32 NumOfQuestion
        {
            get
            {
                return _NumOfQuestion;
            }
            set
            {
                _NumOfQuestion = value;
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

        protected SqlInt32 _InstructorId;

        public SqlInt32 InstructorId
        {
            get
            {
                return _InstructorId;
            }
            set
            {
                _InstructorId = value;
            }
        }

        protected String _StartTime;

        public String StartTime
        {
            get
            {
                return _StartTime;
            }
            set
            {
                _StartTime = value;
            }
        }

        protected String _EndTime;

        public String EndTime
        {
            get
            {
                return _EndTime;
            }
            set
            {
                _EndTime = value;
            }
        }

        protected String _EndDate;

        public String EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                _EndDate = value;
            }
        }

        protected SqlInt32 _TotalMarks;

        public SqlInt32 TotalMarks
        {
            get
            {
                return _TotalMarks;
            }
            set
            {
                _TotalMarks = value;
            }
        }
    }
}