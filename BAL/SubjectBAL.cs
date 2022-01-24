using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class SubjectBAL
    {
        public DataTable SelectAll()
        {
            SubjectDAL subjectDAL = new SubjectDAL();
            return subjectDAL.SelectAll();
        }
    }
}
