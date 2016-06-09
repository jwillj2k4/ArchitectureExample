using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Autofac;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features
{
    /// <summary>   An orion dependency resolver. </summary>
    public class OrionDependencyResolver : IOrionDependencyResolver
    {
        private IContainer _container;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.Infrastructure.DR.Features.OrionDependencyResolver
        ///     class.
        /// </summary>
        ///
        /// <param name="container">    The container. </param>
        ///-------------------------------------------------------------------------------------------------
        public OrionDependencyResolver(IContainer container)
        {
            _container = container;
        }

        /// -------------------------------------------------------------------------------------------------
        ///  <summary>   Gets a service. </summary>
        /// 
        ///  <typeparam name="T">    Generic type parameter. </typeparam>
        /// <returns>   The service. </returns>
        /// -------------------------------------------------------------------------------------------------
        public T GetService<T>()
        {
            T service;

            //http://docs.autofac.org/en/latest/resolve/index.html
            //While it is possible to resolve components right from the root container, doing this through your application in some cases may result in a memory leak.
            using (var scope = _container.BeginLifetimeScope())
                scope.TryResolve(out service);

            //will return null if no service is found

            return service;
        }

        public IDependencyScope BeginScope()
        {
            return new OrionDependencyResolver(_container);
        }

        public object GetService(Type serviceType)
        {
            //todo finish this
            return null;
        }

        IEnumerable<object> IDependencyScope.GetServices(Type serviceType)
        {
            //todo finish this
            return null;
        }

        public void Dispose()
        {
            _container = null;
        }
    }
}