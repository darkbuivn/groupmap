using GroupMap.Models;
using GroupMap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Repository.BaseClass
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private GenericRepository<MapGroup> groupsRepository;
        private GenericRepository<UserProfile> profilesRepository;

        public GenericRepository<MapGroup> GroupstRepository
        {
            get
            {

                if (this.groupsRepository == null)
                {
                    this.groupsRepository = new GenericRepository<MapGroup>(context);
                }
                return groupsRepository;
            }
        }

        public GenericRepository<UserProfile> ProfilesRepository
        {
            get
            {

                if (this.profilesRepository == null)
                {
                    this.profilesRepository = new GenericRepository<UserProfile>(context);
                }
                return profilesRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
