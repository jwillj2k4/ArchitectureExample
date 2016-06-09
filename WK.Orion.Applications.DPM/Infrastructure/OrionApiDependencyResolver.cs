using Autofac;
using Autofac.Integration.WebApi;
using WK.Orion.Applications.DPM.Infrastructure.Interfaces;

namespace WK.Orion.Applications.DPM.Infrastructure
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An orion API dependency resolver. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class OrionApiDependencyResolver : AutofacWebApiDependencyResolver, IOrionDependencyResolver
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Applications.DPM.Infrastructure.OrionApiDependencyResolver class.
        /// </summary>
        ///
        /// <param name="container">    The container. </param>
        ///-------------------------------------------------------------------------------------------------
        public OrionApiDependencyResolver(ILifetimeScope container) : base(container)
        {
            
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the service. </summary>
        ///
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        ///
        /// <returns>   The service. </returns>
        ///-------------------------------------------------------------------------------------------------
        public virtual T GetService<T>()
        {
            T result;
            using (var z = this.GetRequestLifetimeScope())
            {
                z.TryResolve<T>(out result);
            }

            return result;
        }
    }
}