using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.Tasks.Core.Infrastructure.Modules;
using WK.Orion.Platform.Tasks.DataAccessLayer.Interfaces;
using WK.Orion.Platform.Tasks.DataAccessLayer.Interfaces.Repositories;
using WK.Orion.Platform.Tasks.DataAccessLayer.Repositories;

namespace WK.Orion.Platform.Tasks.DataAccessLayer.Infrastructure.Modules
    {
        public class Base : Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                //wire things here that apply to both environments
                builder.RegisterType<TaskRepository>().As<ITaskRepository>();
                builder.RegisterType<TaskUnitOfWork>().As<ITaskUnitOfWork>();

                if (ApplicationConfiguration.GetApplicationConfiguration() == ServiceTypes.Web)
                    Web.Load(builder);
                else
                    Windows.Load(builder);
            }
        }
    }
