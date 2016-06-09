using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserDefinedFields.DataAccessLayer.Interfaces;
using WK.Orion.Platform.UserDefinedFields.DataAccessLayer.Interfaces.Repositories;
using WK.Orion.Platform.UserDefinedFields.DataAccessLayer.Repositories;

namespace WK.Orion.Platform.UserDefinedFields.DataAccessLayer.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //wire things here that apply to both environments
                builder.RegisterType<UDFRepository>().As<IUDFRepository>();
                builder.RegisterType<UDFUnitOfWork>().As<IUDFUnitOfWork>();

            if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
