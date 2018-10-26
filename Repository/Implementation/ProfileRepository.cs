using System;
using GroupMap.Models;
using GroupMap.Common.Helper;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

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
                FullName = string.Empty,
                Email = name,
                RegisterDate = Utility.GetUtcTimeStamp(DateTime.UtcNow),               
                Id = Guid.NewGuid()
            };
            Insert(res);
            return res;
        }

        public UserProfile GetByUserId(string aspNetUserID)
        {
            UserProfile res = context.UserProfiles.FirstOrDefault(x => x.AspNetUserId == aspNetUserID);

            ApplicationUser aspNetUser = context.Users.Find(aspNetUserID);
            if (string.IsNullOrEmpty(res.Email))
            {
                res.Email = aspNetUser.Email;
            }

            if (string.IsNullOrEmpty(aspNetUser.PhoneNumber))
            {
                res.PhoneNum = aspNetUser.PhoneNumber;
            }
            return res;
        }

        public async Task UpdateProfile(UserProfile profile)
        {
            await Task.Run(() =>
            {
                Update(profile);
            });
        }
    }
}
