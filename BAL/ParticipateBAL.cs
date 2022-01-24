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
    public class ParticipateBAL
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

        public ParticipateENT loginAsStudent(ParticipateENT participate)
        {
            ParticipateDAL pDAL = new ParticipateDAL();
            return pDAL.loginAsStudent((string)participate.UserName, (string)participate.Password);
        }

        public int SignUP(ParticipateENT participate)
        {
            ParticipateDAL pDAL = new ParticipateDAL();
            return pDAL.SignUP(participate);
        }

        public void AddMoredetails(ParticipateENT participate)
        {
            ParticipateDAL pDAL = new ParticipateDAL();
            pDAL.AddMoredetails(participate);
        }

        public ParticipateENT GetStudentByStudentId(int id)
        {
            ParticipateDAL participateDAL = new ParticipateDAL();
            return participateDAL.GetStudentByStudentId(id);
        }

        public DataTable GetStudentByStudentId_DataTable(int id)
        {
            ParticipateDAL participateDAL = new ParticipateDAL();
            return participateDAL.GetStudentByStudentId_DataTable(id);
        }

        public void EditStudentdata(ParticipateENT participate)
        {
            ParticipateDAL participateDAL = new ParticipateDAL();
            participateDAL.EditStudentdata(participate);
        }

        public DataTable GetQuizPreformancebyStudentId(int id)
        {
            ParticipateDAL participateDAL = new ParticipateDAL();
            return participateDAL.GetQuizPreformancebyStudentId(id);
        }

        public DataTable ListOfAllStudent()
        {
            ParticipateDAL participateDAL = new ParticipateDAL();
            return participateDAL.ListOfAllStudent();
        }
    }
}