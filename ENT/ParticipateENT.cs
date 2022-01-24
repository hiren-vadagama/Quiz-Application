using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT
{
    public class ParticipateENT
    {
        public ParticipateENT()
        {

        }

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

        protected SqlString _ParticipateName;

        public SqlString ParticipateName
        {
            get
            {
                return _ParticipateName;
            }
            set
            {
                _ParticipateName = value;
            }
        }

        protected SqlString _CollegeName;

        public SqlString CollegeName
        {
            get
            {
                return _CollegeName;
            }
            set
            {
                _CollegeName = value;
            }
        }

        protected String _BirthDate;

        public String BirthDate
        {
            get
            {
                return _BirthDate;
            }
            set
            {
                _BirthDate = value;
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

        protected SqlString _CourseName;

        public SqlString CourseName
        {
            get
            {
                return _CourseName;
            }
            set
            {
                _CourseName = value;
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

        protected SqlInt32 _LevelId;

        public SqlInt32 LevelId
        {
            get
            {
                return _LevelId;
            }
            set
            {
                _LevelId = value;
            }
        }

        protected SqlInt32 _Age;

        public SqlInt32 Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
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