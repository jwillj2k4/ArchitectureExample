using Autofac;
using WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Tasks.BusinessLogicLayer.Infrastructure.Bootstrapping
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
            builder.RegisterType<TaskService>().As<ITaskService>();
        }
    }
}