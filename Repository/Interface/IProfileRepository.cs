using GroupMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Repository
{
    public interface IProfileRepository
    {
        UserProfile CreateNewProfile(string name, string userID);
        UserProfile UpdateProfile(UserProfile profile);
    }
}
