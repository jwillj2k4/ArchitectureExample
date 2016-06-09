using Autofac;
using WK.Orion.Services.Example.Email.BusinessLogic.Interfaces;
using WK.Orion.Services.Example.Email.BusinessLogic.Services;

namespace WK.Orion.Services.Example.Email.Infrastructure
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
        public static void RegisterTypes(OrionContainerBuilder builder)
        {
            builder.RegisterType<EmailService>().As<IEmailService>().SingleInstance();
        }
    }
}
