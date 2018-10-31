using GroupMap.Models;
using System;
using System.Collections.Generic;

namespace GroupMap.Repository
{
    interface IGroupRepository
    {
        MapGroup CreateGroup(string grName, Guid creator);
        void AddMembers(List<Guid> memberIds);
    }
}
