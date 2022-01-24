using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class QuestionInQuizBAL
    {
        public List<int> GetQuestionForQuiz(int id,int Qnum)
        {
            QuestionInQuizDAL questionDAL = new QuestionInQuizDAL();
            return questionDAL.GetQuestionForQuiz(id,Qnum);
        }
        public void SetQuestion(QuestionInQuizENT questionInQuizENT)
        {
            QuestionInQuizDAL questionInQuizDAL = new QuestionInQuizDAL();
            questionInQuizDAL.SetQuestion(questionInQuizENT);
        }
    }
}
