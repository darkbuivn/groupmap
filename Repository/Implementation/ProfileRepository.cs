using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMap.Models;
using GroupMap.Common.Helper;

namespace GroupMap.Repository
{
    public class ProfileRepository: GenericRepository<UserProfile>, IProfileRepository 
    {   
        public ProfileRepository(ApplicationDbContext context) : base(context)
        {
        }

        public UserProfile CreateNewProfile(string name, string userID)
        {
            UserProfile res = new UserProfile()
            {
                AspNetUserId = userID,
                FullName = name,
                RegisterDate = Utility.GetUtcTimeStamp(DateTime.UtcNow),               
                Id = Guid.NewGuid()
            };
            Insert(res);
            return res;
        }

        public UserProfile UpdateProfile(UserProfile profile)
        {
            return null;   
        }
    }
}
