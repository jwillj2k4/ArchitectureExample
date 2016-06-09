using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Castle.Core.Internal;
using WK.Orion.Platform.Examples.Components.Framework.Enums;
using WK.Orion.Platform.Examples.Components.Infrastructure.DR.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Infrastructure.DR
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A product handler. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class BoostrapHandler
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The product handlers. </summary>
        ///-------------------------------------------------------------------------------------------------
        private static readonly IDictionary<FeatureType, IFeatureService> ProductHandlers = new ConcurrentDictionary<FeatureType, IFeatureService>();

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Initializes static members of the WK.Orion.Platform.Examples.Components.Infrastructure.DR.BoostrapHandler
        ///     class.
        /// </summary>
        ///-------------------------------------------------------------------------------------------------
        static BoostrapHandler()
        {
            LoadProducts();
        }

        /// -------------------------------------------------------------------------------------------------
        ///  <summary>   Runs a product handler depending on the type </summary>
        /// <param name="builder"></param>
        /// <param name="featureType">  Type of the product. </param>
        /// <param name="serviceTypes"> List of types of the services. </param>
        /// -------------------------------------------------------------------------------------------------
        public static void RegisterDependencies(ContainerBuilder builder, FeatureType featureType, ServiceTypes serviceTypes)
        {
            ProductHandlers[featureType].Run(builder, serviceTypes);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Loads the products. </summary>
        ///-------------------------------------------------------------------------------------------------
        private static void LoadProducts()
        {
            //find the types of products
            var lookupType = typeof(IFeatureService);

            //for each one, add a new instance to the dictionary
            Assembly.GetExecutingAssembly().GetTypes().Where(
                t => lookupType.IsAssignableFrom(t) && !t.IsInterface).ForEach(product =>
                {
                    var p = (IFeatureService) Activator.CreateInstance(product);

                    ProductHandlers.Add(new KeyValuePair<FeatureType, IFeatureService>(p.FeatureType, p));

                });
        }
    }
}