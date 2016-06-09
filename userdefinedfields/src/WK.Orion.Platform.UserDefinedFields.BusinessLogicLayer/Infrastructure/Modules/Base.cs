using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserDefinedFields.BusinessLogicLayer.Interfaces;

namespace WK.Orion.Platform.UserDefinedFields.BusinessLogicLayer.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //wire things here that apply to both environments
                builder.RegisterType<UDFService>().As<IUDFService>();

                if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
