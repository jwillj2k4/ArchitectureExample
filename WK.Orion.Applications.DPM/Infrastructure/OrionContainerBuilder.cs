using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Core;
using Autofac.Integration.WebApi;
using WebGrease.Css.Extensions;
using WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping;
using WK.Orion.Platform.Framework.Enums;
using WK.Orion.Platform.Framework.Integration.WebAPI.Controllers;
using WK.Orion.Platform.Framework.Integration.WebAPI.Filters;
using WK.Orion.Platform.Framework.Interfaces;

namespace WK.Orion.Applications.DPM.Infrastructure
{
    /// <summary>   An orion container builder. </summary>
    public class OrionContainerBuilder : ContainerBuilder
    {
        public void Register()
        {
            ApplicationConfiguration.SetApplicationConfiguration(ServiceTypes.Web);

            RegisterControllers();

            RegisterFilters();

            RegisterExternalDependencies();
          
            SetDependencyResolver();
        }
        
        private void RegisterFilters()
        {
            // Register the Autofac filter provider.
            this.RegisterWebApiFilterProvider(GlobalConfiguration.Configuration);

            //Register Logging for all controller actions
            this.Register(z => new LoggingActionFilter(z.Resolve<ILogService>()))
                .AsWebApiActionFilterFor<OrionApiController>()
                .InstancePerRequest();

            //Register Exception handling for all controller actions
            this.Register(
                z => new ExceptionHandlerActionFilter(z.Resolve<IExceptionService>(), z.Resolve<ILogService>()))
                .AsWebApiExceptionFilterFor<OrionApiController>();
        }

        
        private void RegisterControllers()
        {
            // Register your Web API controllers.
            this.RegisterApiControllers(Assembly.GetExecutingAssembly());
        }

        
        private void RegisterExternalDependencies()
        {
            //get the current directory, probably the bin
            var path = HttpContext.Current.Server.MapPath("~/bin");

                //Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("RegisterExternalDependencies: Unable to retrieve assemblies");
            
            //example: register at the component level
            var assemblies = Directory.GetFiles(path, "WK.Orion.Platform.Clients*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);

            assemblies = Directory.GetFiles(path, "WK.Orion.Platform.UserManagement*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);

            assemblies = Directory.GetFiles(path, "WK.Orion.Platform.UserDefinedFields*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);

            assemblies = Directory.GetFiles(path, "WK.Orion.Platform.SecurityGroups*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);

            assemblies = Directory.GetFiles(path, "WK.Orion.Platform.Tasks*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);

            assemblies = Directory.GetFiles(path, "WK.Orion.Platform.MultiLanguage*.dll", SearchOption.TopDirectoryOnly)
                .Select(Assembly.LoadFrom);
            RegisterAssembly(assemblies);


        }

        private void RegisterAssembly(IEnumerable<Assembly> assemblies)
        {
//for each assembly
            assemblies.ForEach(assembly =>
            {
                //find where it implements AutoFac.Imodule and create an instance of it
                var modules = assembly.GetTypes()
                    .Where(p => typeof(IModule).IsAssignableFrom(p)
                                && !p.IsAbstract)
                    .Select(p => (IModule) Activator.CreateInstance(p));

                //call the register module method for each assembly
                modules.ForEach(module => this.RegisterModule(module));
            });
        }


        private void SetDependencyResolver()
        {
            GlobalConfiguration.Configuration.DependencyResolver = new OrionApiDependencyResolver(Build());
        }
    }
}