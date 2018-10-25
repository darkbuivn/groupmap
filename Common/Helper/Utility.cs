using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Common.Helper
{
    public class Utility
    {
        /// <summary>
        /// Convert UTC.Now to time stamp
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static double GetUtcTimeStamp(DateTime val)
        {            
            DateTime baseTime = new DateTime(1970, 1, 1, 0, 0, 0);
            TimeSpan timeStamp = DateTime.UtcNow - baseTime;
            return timeStamp.TotalMilliseconds;
        }

        /// <summary>
        /// Get date time from time stamp value
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static DateTime GetUtcTimeFromTimeStamp(double timeStamp)
        {
            DateTime baseTime = new DateTime(1970, 1, 1, 0, 0, 0);           
            return baseTime.AddMilliseconds(timeStamp);
        }
    }
}
