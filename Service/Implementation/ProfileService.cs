using System;
using System.Threading.Tasks;
using GroupMap.Models;
using GroupMap.Repository;
using GroupMap.Common.Helper;

namespace GroupMap.Service
{
    public class ProfileService : IProfileService
    {
        private IProfileRepository _repo = new ProfileRepository(new ApplicationDbContext());
        public ProfileService()
        {

        }

        /// <summary>
        /// Create profile for new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<UserProfile> CreateAssociateProfile(ApplicationUser user)
        {
            return await Task.Run(() =>
            {
                return _repo.CreateNewProfile(user.UserName, user.Id);
            });
        }

        public UserProfile GetByUserID(string userId)
        {
            return _repo.GetByUserId(userId);
        }

        /// <summary>
        /// Save the latest location coordiate of user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        /// <returns></returns>
        public bool SaveNewCoordinate(string userId, decimal latitude, decimal longitude)
        {
            // invalid userId
            if (String.IsNullOrEmpty(userId))
            {
                return false;
            }

            UserProfile profile = _repo.GetByUserId(userId);

            // profile not exist
            if (profile == null)
            {
                return false;
            }

            // save user latest localtion
            profile.Coordinates.Add(
                new GpsCoordinate()
                {
                    Id = Guid.NewGuid(),
                    Latitude = latitude,
                    Longitude = longitude,
                    UserProfileId = profile.Id,
                    ReceivedDate = Utility.GetUtcTimeStamp(DateTime.UtcNow)
                });
             _repo.UpdateProfile(profile);

            return true;
        }
    }   
}
