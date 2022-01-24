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
    public class PerformanceInQuizBAL
    {
        public void insertPercentage(PerformanceInQuizENT performanceInQuizENT)
        {
            PerformanceInQuizDAL performanceInQuizDAL = new PerformanceInQuizDAL();
            performanceInQuizDAL.insertPercentage(performanceInQuizENT);
        }
        public void DeleteStudentforQuiz(int id)
        {
            PerformanceInQuizDAL performanceInQuizDAL = new PerformanceInQuizDAL();
            performanceInQuizDAL.DeleteStudentforQuiz(id);
        }
        public void SelectedStuForQuiz(PerformanceInQuizENT performanceInQuizENT)
        {
            PerformanceInQuizDAL performanceInQuizDAL = new PerformanceInQuizDAL();
            performanceInQuizDAL.SelectedStuForQuiz(performanceInQuizENT);
        }
        public DataTable GetSelectedStudentForQuiz(int id)
        {
            PerformanceInQuizDAL performanceInQuizDAL = new PerformanceInQuizDAL();
            return performanceInQuizDAL.GetSelectedStudentForQuiz(id);
        }

        public DataTable GetStudentperformancedata(int id)
        {
            PerformanceInQuizDAL performanceInQuizDAL = new PerformanceInQuizDAL();
            return performanceInQuizDAL.GetSelectedStudentForQuiz(id);
        }
    }
}
