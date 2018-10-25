using Autofac;
using GroupMap.Models;
using GroupMap.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMap.Service
{ 
    /// <summary>
    /// Setup for eFramework.Offline.
    /// </summary>
    public class Buider
    {
        private IContainer _container;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Buider()
        {
            //Initialize();
            //RegisterMappings();
        }

        /// <summary>
        /// Initialize dependency injection.
        /// </summary>
        public static void Initialize()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            containerBuilder.Register(c => new ProfileRepository(new ApplicationDbContext())).As<IProfileRepository>();
            //containerBuilder.RegisterType<ProfileRepository>().As<IProfileRepository>();
            containerBuilder.Register(c => new ProfileService()).As<IProfileService>();
            //containerBuilder.RegisterType<ProfileService>().As<IProfileService>();
            containerBuilder.Build();
        }
        public static void RegisterMappings()
        {
            AutoMapperConfig.Initialize();
        }
    }
}
