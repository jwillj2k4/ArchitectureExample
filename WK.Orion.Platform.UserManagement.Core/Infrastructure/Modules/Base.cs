using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserManagement.Core.Models.Entities;
using WK.Orion.Platform.UserManagement.Core.Models.Entities.Interfaces;
using WK.Orion.Platform.UserManagement.Core.Models.Projections;
using WK.Orion.Platform.UserManagement.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.UserManagement.Core.Infrastructure.Modules
{
    public class Base : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //wire things here that apply to both environments
            builder.RegisterType<OrionUser>().As<IOrionUser>();
            builder.RegisterType<OrionUserDto>().As<IOrionUserDto>();

            if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                Web.Load(builder);
            else
                Windows.Load(builder);
        }
    }
}
