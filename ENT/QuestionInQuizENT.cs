using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class QuestionInQuizENT
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

        protected SqlInt32 _QId;

        public SqlInt32 QId
        {
            get
            {
                return _QId;
            }
            set
            {
                _QId = value;
            }
        }

    }
}