using Autofac;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Interfaces.Repositories;
using WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Repositories;

namespace WK.Orion.Platform.Examples.Components.Tasks.DataAccessLayer.Infrastructure.Bootstrapping
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
            builder.RegisterType<TaskUnitOfWork>().As<ITaskUnitOfWork>();
            builder.RegisterType<TaskRepository>().As<ITaskRepository>();
        }
    }
}