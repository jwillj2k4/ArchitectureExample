using System.ServiceProcess;
using WK.Orion.Services.DPM.BusinessLogic.Interfaces;

namespace WK.Orion.Services.DPM
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A service 1. </summary>
    ///-------------------------------------------------------------------------------------------------
    public partial class Service1 : ServiceBase
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The document processing service. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IDocumentProcessingService _documentProcessingService;

        public Service1(IDocumentProcessingService documentProcessingService)
        {
            _documentProcessingService = documentProcessingService;
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
            _documentProcessingService.Run();
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