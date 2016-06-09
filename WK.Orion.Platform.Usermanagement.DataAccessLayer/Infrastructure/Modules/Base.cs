using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Interfaces.Repositories;
using WK.Orion.Platform.UserManagement.DataAccessLayer.Repositories;

namespace WK.Orion.Platform.UserManagement.DataAccessLayer.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
            //wire things here that apply to both environments
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<UserUnitOfWork>().As<IUserUnitOfWork>();

            if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
