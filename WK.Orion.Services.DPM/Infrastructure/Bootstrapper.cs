using Autofac;
using WK.Orion.Services.DPM.BusinessLogic.Interfaces;
using WK.Orion.Services.DPM.BusinessLogic.Services;

namespace WK.Orion.Services.DPM.Infrastructure
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A non web bootstrap handler. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class Bootstrapper
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Boot strap. </summary>
        ///
        /// <param name="builder">  The builder. </param>
        ///-------------------------------------------------------------------------------------------------
        public static void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<DocumentProcessingService>().As<IDocumentProcessingService>();
        }
    }
}
