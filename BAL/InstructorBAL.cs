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
    public class InstructorBAL
    {
        protected string _Message;
        public string Message
        {
            get
            {
                return _Message;
            }
            set
            {
                _Message = value;
            }
        }

        public InstructorENT loginAsInstructor(InstructorENT instructor)
        {
            InstructorDAL iDAL = new InstructorDAL();
            return iDAL.loginAsInstructor((string)instructor.UserName, (string)instructor.Password);
        }

        public int SignUP(InstructorENT instructor)
        {
            InstructorDAL iDAL = new InstructorDAL();
            return iDAL.SignUP(instructor);
        }

        public void AddMoredetails(InstructorENT instructor)
        {
            InstructorDAL iDAL = new InstructorDAL();
            iDAL.AddMoredetails(instructor);
        }

        public InstructorENT GetInstructorByInstructorId(int id)
        {
            InstructorDAL instructorDAL = new InstructorDAL();
            return instructorDAL.GetInstructorByInstructorId(id);
        }
        public void Edit_Instructor_data(InstructorENT instructorENT)
        {
            InstructorDAL instructorDAL = new InstructorDAL();
            instructorDAL.Edit_Instructor_data(instructorENT);
        }

        public DataTable GetInstructorByInstructorId_DataTable(int id)
        {
            InstructorDAL instructorDAL = new InstructorDAL();
            return instructorDAL.GetInstructorByInstructorId_DataTable(id);
        }
    }
}
