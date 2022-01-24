using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class QuestionsENT
    {
        public QuestionsENT()
        {

        }

        protected int _QuestionId;

        public int QuestionId
        {
            get
            {
                return _QuestionId;
            }
            set
            {
                _QuestionId = value;
            }
        }

        protected String _question;

        public String question
        {
            get
            {
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        protected String _correct_answer;

        public String correct_answer
        {
            get
            {
                return _correct_answer;
            }
            set
            {
                _correct_answer = value;
            }
        }

        protected String _distractor1;

        public String distractor1
        {
            get
            {
                return _distractor1;
            }
            set
            {
                _distractor1 = value;
            }
        }

        protected String _distractor2;

        public String distractor2
        {
            get
            {
                return _distractor2;
            }
            set
            {
                _distractor2 = value;
            }
        }

        protected String _distractor3;

        public String distractor3
        {
            get
            {
                return _distractor3;
            }
            set
            {
                _distractor3 = value;
            }
        }

        protected String _support;

        public String support
        {
            get
            {
                return _support;
            }
            set
            {
                _support = value;
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

        protected SqlInt32 _CategoryId;

        public SqlInt32 CategoryId
        {
            get
            {
                return _CategoryId;
            }
            set
            {
                _CategoryId = value;
            }
        }

    }
}