using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Common.Constant
{
    public class Constant
    {
        public const string PAGE_TITLE_PROFILE_INDEX = "Profile";

        public enum StatusCode: int
        {
            OK = 0,
            InvalidModel = 1,
            UnAuthorized = 2,
            NotFound = 3,
            Deleted = 4,
            Duplicated = 5,
            BadRequest = 6,
            Failure = 7              
        }

        // Keep data within 15 days
        public const double DURATION_TIME_FOR_KEEPING_DATA = 15; // 15 days = 1296000000 miliseconds
    }
}
