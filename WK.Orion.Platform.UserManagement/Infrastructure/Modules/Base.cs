using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserManagement.BusinessLogicLayer;
using WK.Orion.Platform.UserManagement.Interfaces;

namespace WK.Orion.Platform.UserManagement.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //wire things here that apply to both environments
                builder.RegisterType<UserService>().As<IUserService>();

                if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
