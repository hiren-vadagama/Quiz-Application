using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class InstructorENT
    {
        public InstructorENT()
        {

        }

        protected SqlInt32 _InstructorId;

        public SqlInt32 InstructorId
        {
            get
            {
                return _InstructorId;
            }
            set
            {
                _InstructorId = value;
            }
        }

        protected SqlString __InstructoreName;

        public SqlString InstructorName
        {
            get
            {
                return __InstructoreName;
            }
            set
            {
                __InstructoreName = value;
            }
        }

        protected SqlString _College;

        public SqlString College
        {
            get
            {
                return _College;
            }
            set
            {
                _College = value;
            }
        }

        protected String _JoiningDate;

        public String JoiningDate
        {
            get
            {
                return _JoiningDate;
            }
            set
            {
                _JoiningDate = value;
            }
        }

        protected SqlString _Email;

        public SqlString Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }

        protected SqlString _Password;

        public SqlString Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        protected SqlInt32 _StateId;

        public SqlInt32 StateId
        {
            get
            {
                return _StateId;
            }
            set
            {
                _StateId = value;
            }
        }

        protected SqlInt32 _CityId;

        public SqlInt32 CityId
        {
            get
            {
                return _CityId;
            }
            set
            {
                _CityId = value;
            }
        }

        protected SqlInt32 _Experince;

        public SqlInt32 Experince
        {
            get
            {
                return _Experince;
            }
            set
            {
                _Experince = value;
            }
        }
        protected SqlString _Gender;

        public SqlString Gender
        {
            set
            {
                _Gender = value;
            }
            get
            {
                return _Gender;
            }
        }

        protected SqlString _MobileNo;

        public SqlString MobileNo
        {
            get
            {
                return _MobileNo;
            }
            set
            {
                _MobileNo = value;
            }
        }

        protected SqlString _UserName;

        public SqlString UserName
        {
            get
            {
                return _UserName;
            }
            set
            {
                _UserName = value;
            }
        }
    }
}