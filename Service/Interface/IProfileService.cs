using GroupMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Service
{
    public interface IProfileService
    {
        Task<UserProfile> CreateAssociateProfile(ApplicationUser user);
    }
}
