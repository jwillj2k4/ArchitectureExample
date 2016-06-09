using System;
using System.Web.Http.Dependencies;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces
{
    public interface IOrionDependencyResolver : IDependencyResolver
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a service. </summary>
        ///
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <param name="type"> The type. </param>
        ///
        /// <returns>   The service. </returns>
        ///-------------------------------------------------------------------------------------------------
        T GetService<T>();
    }
}