using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class PerformanceInQuizENT
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

        protected SqlInt32 _Rank;

        public SqlInt32 Rank
        {
            get
            {
                return _Rank;
            }
            set
            {
                _Rank = value;
            }
        }

        protected float _Percentage;

        public float Percentage
        {
            get
            {
                return _Percentage;
            }
            set
            {
                _Percentage = value;
            }
        }

    }
}