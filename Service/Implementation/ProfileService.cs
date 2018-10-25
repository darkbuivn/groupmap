using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMap.Models;
using GroupMap.Repository;

namespace GroupMap.Service
{
    public class ProfileService : IProfileService
    {
        private IProfileRepository _repo = new ProfileRepository(new ApplicationDbContext());
        public ProfileService()
        {

        }
        public async Task<UserProfile> CreateAssociateProfile(ApplicationUser user)
        {
            return await Task.Run(() =>
            {
                return _repo.CreateNewProfile(user.UserName, user.Id);
            });
        }
    }   
}
