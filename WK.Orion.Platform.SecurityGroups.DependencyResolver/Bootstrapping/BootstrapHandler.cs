using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using API        = WK.Orion.Platform.SecurityGroups.Infrastructure.Bootstrapping;
using Business   = WK.Orion.Platform.SecurityGroups.BusinessLogicLayer.Infrastructure.Bootstrapping;
using DataAccess = WK.Orion.Platform.SecurityGroups.DataAccessLayer.Infrastructure.Bootstrapping;
using OrionCore  = WK.Orion.Platform.SecurityGroups.Core.Infrastructure.Bootstrapping;

namespace WK.Orion.Platform.SecurityGroups.DR.Bootstrapping
{
    public class BootstrapHandler
    {
        public static void Run(ContainerBuilder builder, ServiceTypes serviceType)
        {
            if (serviceType == ServiceTypes.Web)
            {
                API.Web.BootStrap(builder);
                Business.Web.BootStrap(builder);
                DataAccess.Web.BootStrap(builder);
                OrionCore.Web.BootStrap(builder);
            }
            else
            {
                API.Windows.BootStrap(builder);
                Business.Windows.BootStrap(builder);
                DataAccess.Windows.BootStrap(builder);
                OrionCore.Windows.BootStrap(builder);
            }
        }
    }
}