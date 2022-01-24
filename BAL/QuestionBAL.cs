using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class QuestionBAL
    {
        public QuestionsENT GetQuestionByQId(int id)
        {
            QuestionDAL questionDAL = new QuestionDAL();
            return questionDAL.GetQuestionByQId(id);
        }
        public List<QuestionsENT> GetQuestionENTForQuiz(List<int> q)
        {
            QuestionDAL questionsDAL = new QuestionDAL();
            return questionsDAL.GetQuestionENTForQuiz(q);
        }

            public void InsertDataForQuiz(QuestionsENT questionENT)
        {
            QuestionDAL questionDAL = new QuestionDAL();
            questionDAL.InsertDataForQuiz(questionENT);
        }

        public DataTable GetQuestionList()
        {
            QuestionDAL questionDAL = new QuestionDAL();
            return questionDAL.GetQuestionList();
        }

        public List<int> selectRandowmClick(int N)
        {
            QuestionDAL questionDAL = new QuestionDAL();
            return questionDAL.selectRandowmClick(N);
        }

        public List<int> selectQuestionForSubjectQuiz(int N,int SID)
        {
            QuestionDAL questionDAL = new QuestionDAL();
            return questionDAL.selectQuestionForSubjectQuiz(N,SID);
        }

    }
}
