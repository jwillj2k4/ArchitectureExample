using System.Web.Http.Filters;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters.Interfaces;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Framework.Models;

namespace WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters
{
    /// <summary>   An exception handler action filter. </summary>
    public class ExceptionHandlerActionFilter : IOrionExceptionFilter
    {
        /// <summary>   The exception service. </summary>
        private readonly IExceptionService _exceptionService;

        /// <summary>   Gets or sets the log service. </summary>
        private  readonly ILogService _logService;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Applications.Example.WebAPI.Filters.Logging.ExceptionHandlerActionFilter class.
        /// </summary>
        ///
        /// <param name="exceptionService"> The exception service. </param>
        /// <param name="logService">       Gets or sets the log service. </param>
        ///-------------------------------------------------------------------------------------------------
        public ExceptionHandlerActionFilter(IExceptionService exceptionService, ILogService logService)
        {
            _exceptionService = exceptionService;
            _logService = logService;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Executes the exception action. </summary>
        ///
        /// <param name="actionExecutedContext">    Context for the action executed. </param>
        ///-------------------------------------------------------------------------------------------------
        public void OnException(HttpActionExecutedContext actionExecutedContext)
        {
           _logService.Write(actionExecutedContext.ActionContext.ActionDescriptor.ActionName);

            //TODO populate exception dto. should be generic enough to work with web/non web technologies
            _exceptionService.Write(new ExceptionDto(actionExecutedContext.ActionContext.ActionDescriptor.ActionName));
        }
    }
}