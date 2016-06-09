using Autofac;
using WK.Orion.Platform.Examples.Components.Framework.Enums;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces
{
    /// <summary>   Interface for product. </summary>
    public interface IFeatureService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the type of the product. </summary>
        ///
        /// <value> The type of the product. </value>
        ///-------------------------------------------------------------------------------------------------
        FeatureType FeatureType { get; }

        /// -------------------------------------------------------------------------------------------------
        ///  <summary>   Runs the given bootstrap type. </summary>
        /// <param name="builder"></param>
        /// <param name="serviceTypes">    Type of the bootstrap. </param>
        /// <returns>   An OrionAPIDependencyResolver. </returns>
        /// -------------------------------------------------------------------------------------------------
        void Run(ContainerBuilder builder, ServiceTypes serviceTypes);
    }
}