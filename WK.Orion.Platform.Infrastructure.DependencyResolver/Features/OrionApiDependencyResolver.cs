using Autofac;
using Autofac.Integration.WebApi;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features
{
    /// <summary>   An orion dependency resolver. </summary>
    public class OrionApiDependencyResolver : AutofacWebApiDependencyResolver, IOrionDependencyResolver
    {
        private readonly IContainer _container;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.IOC.OrionAPIDependencyResolver class.
        /// </summary>
        ///
        /// <param name="container">    The container. </param>
        ///-------------------------------------------------------------------------------------------------
        public OrionApiDependencyResolver(IContainer container) : base(container)
        {
            _container = container;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a service. </summary>
        ///
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <param name="type"> The type. </param>
        ///
        /// <returns>   The service. </returns>
        ///-------------------------------------------------------------------------------------------------
        public virtual T GetService<T>()
        {
            T service;
            
            //http://docs.autofac.org/en/latest/resolve/index.html
            //While it is possible to resolve components right from the root container, doing this through your application in some cases may result in a memory leak.
            using (var scope = _container.BeginLifetimeScope())
                scope.TryResolve(out service);
            
            //will return null if no service is found
            
            return service;
        }
    }
}
