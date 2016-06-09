using Autofac;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Entities.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections;
using WK.Orion.Platform.Examples.Components.Tasks.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.Core.Infrastructure.Bootstrapping
{
    public class Base
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Boot strap. </summary>
        ///
        /// <param name="builder">  The builder. </param>
        ///-------------------------------------------------------------------------------------------------
        public static void BootStrap(ContainerBuilder builder)
        {
            builder.RegisterType<OrionTask>().As<IOrionTask>();
            builder.RegisterType<OrionTaskDto>().As<IOrionTaskDto>();
        }
    }
}