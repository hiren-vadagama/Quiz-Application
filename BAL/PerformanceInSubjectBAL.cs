using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class PerformanceInSubjectBAL
    {
        public DataTable GetJoiningSubjectByPID(int id)
        {
            PerformanceInSubjectDAL performanceInSubjectDAL = new PerformanceInSubjectDAL();
            return performanceInSubjectDAL.GetJoiningSubjectByPID(id);
        }

        public DataTable GetNonJoiningSubjectByPID(int id)
        {
            PerformanceInSubjectDAL performanceInSubjectDAL = new PerformanceInSubjectDAL();
            return performanceInSubjectDAL.GetNonJoiningSubjectByPID(id);
        }

        public void SelectForPracticeSubjectByPID(int id, int SID)
        {
            PerformanceInSubjectDAL performanceInSubjectDAL = new PerformanceInSubjectDAL();
            performanceInSubjectDAL.SelectForPracticeSubjectByPID(id,SID);
        }

        public void insertScoreForSubQuiz(int id, int per)
        {
            PerformanceInSubjectDAL performanceInSubjectDAL = new PerformanceInSubjectDAL();
            performanceInSubjectDAL.insertScoreForSubQuiz(id, per);
        }
        public int PerformanceInSubjectGetPSID(int id, int SID)
        {
            PerformanceInSubjectDAL performanceInSubjectDAL = new PerformanceInSubjectDAL();
            return performanceInSubjectDAL.PerformanceInSubjectGetPSID(id,SID);
        }

    }
}
