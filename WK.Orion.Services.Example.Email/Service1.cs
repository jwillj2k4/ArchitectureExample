using System.ServiceProcess;
using WK.Orion.Services.Example.Email.BusinessLogic.Interfaces;

namespace WK.Orion.Services.Example.Email
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A service 1. </summary>
    ///-------------------------------------------------------------------------------------------------
    public partial class Service1 : ServiceBase
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The document processing service. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IEmailService _emailService;

        public Service1(IEmailService emailService)
        {
            _emailService = emailService;
            _emailService.Run();

        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     When implemented in a derived class, executes when a Start command is sent to the service
        ///     by the Service Control Manager (SCM) or when the operating system starts (for a service
        ///     that starts automatically). Specifies actions to take when the service starts.
        /// </summary>
        ///
        /// <param name="args"> Data passed by the start command. </param>
        ///-------------------------------------------------------------------------------------------------
        protected override void OnStart(string[] args)
        {
            _emailService.Run();
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     When implemented in a derived class, executes when a Stop command is sent to the service
        ///     by the Service Control Manager (SCM). Specifies actions to take when a service stops
        ///     running.
        /// </summary>
        ///-------------------------------------------------------------------------------------------------
        protected override void OnStop()
        {
        }
    }
}