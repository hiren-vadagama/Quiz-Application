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
    public class QuizBAL
    {
        public DataTable getQuizByParticipateId(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.getQuizByParticipateId(id);
        }

        public DataTable getQuizforPerformance(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.getQuizforPerformance(id);
        }

        public QuizENT GetQuizByQuizId(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.GetQuizByQuizId(id);
        }

        public QuizENT GetQuizByInstructorId(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.GetQuizByInstructorId(id);
        }

        public DataTable GetQuizByInstructorId_DataTable(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.GetQuizByInstructorId_DataTable(id);
        }

        public void DeleteQuizByQuizId(int id)
        {
            QuizDAL quizDAL = new QuizDAL();
            quizDAL.DeleteQuizByQuizId(id);
        }
        public int InsertNewQuiz(QuizENT quizENT)
        {
            QuizDAL quizDAL = new QuizDAL();
            return quizDAL.InsertNewQuiz(quizENT);
        }
        public void UpdateQuiz(QuizENT quizENT)
        {
            QuizDAL quizDAL = new QuizDAL();
            quizDAL.UpdateQuiz(quizENT);
        }
    }
}
