using WK.Orion.Platform.Framework.Enums;

namespace WK.Orion.Platform.Examples.Components.Framework.Infrastructure.Bootstrapping
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An application configuration. </summary>
    ///-------------------------------------------------------------------------------------------------
    public static class ApplicationConfiguration
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Type of the service. </summary>
        ///-------------------------------------------------------------------------------------------------
        private static ServiceTypes _serviceType;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Sets application configuration. </summary>
        ///
        /// <param name="serviceType">  Type of the service. </param>
        ///-------------------------------------------------------------------------------------------------
        public static void SetApplicationConfiguration(ServiceTypes serviceType)
        {
            _serviceType = serviceType;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets application configuration. </summary>
        ///
        /// <returns>   The application configuration. </returns>
        ///-------------------------------------------------------------------------------------------------
        public static ServiceTypes GetApplicationConfiguration()
        {
            return _serviceType;
        }
    }
}