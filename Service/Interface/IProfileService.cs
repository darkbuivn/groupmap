using GroupMap.Models;
using System.Threading.Tasks;

namespace GroupMap.Service
{
    public interface IProfileService
    {
        Task<UserProfile> CreateAssociateProfile(ApplicationUser user);

        bool SaveNewCoordinate(string userId, decimal latitude, decimal longitude);

        UserProfile GetByUserID(string userId);
    }
}
