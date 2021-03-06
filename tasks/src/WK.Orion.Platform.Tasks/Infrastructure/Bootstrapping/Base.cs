﻿using Autofac;
using WK.Orion.Platform.Examples.Components.Tasks.Interfaces;
using WK.Orion.Platform.Examples.Components.Tasks.Services;

namespace WK.Orion.Platform.Examples.Components.Tasks.Infrastructure.Bootstrapping
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