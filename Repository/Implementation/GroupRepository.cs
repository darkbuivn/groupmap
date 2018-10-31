using GroupMap.Common.Helper;
using GroupMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Repository
{
    public class GroupRepository : GenericRepository<MapGroup>, IGroupRepository
    {
        public GroupRepository(ApplicationDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Add user to group
        /// </summary>
        /// <param name="memberIds"></param>
        public void AddMembers(List<Guid> memberIds)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add new group if does not duplicate
        /// </summary>
        /// <param name="grName"></param>
        /// <param name="creator"></param>
        /// <returns></returns>
        public MapGroup CreateGroup(string grName, Guid creator)
        {
            // Check duplicate
            if (context.Groups.FirstOrDefault(x => x.Name == grName && x.RegisteredBy == creator) != null)
            {
                return null;
            }

            // Add new group
            MapGroup grp = new MapGroup()
            {
                Id = Guid.NewGuid(),
                Name = grName,
                RegisteredBy = creator,
                RegisterDate = Utility.GetUtcTimeStamp(DateTime.UtcNow)
            };

            Insert(grp);
            return grp;
        }
    }
}
