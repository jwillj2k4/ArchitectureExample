using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.UserDefinedFields.Core.Converters.Interfaces;
using WK.Orion.Platform.UserDefinedFields.Core.Converters.Services;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Entities;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Entities.Interfaces;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Projections;
using WK.Orion.Platform.UserDefinedFields.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.UserDefinedFields.Core.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //wire things here that apply to both environments
                builder.RegisterType<OrionUdf>().As<IOrionUdf>();
                builder.RegisterType<OrionUdfDto>().As<IOrionUdfDto>();
                builder.RegisterType<UDFConverter>().As<IUDFConverter>();

            if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
