using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters.Interfaces;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;

namespace WK.Orion.Platform.Examples.Components.Framework.Integration.WebAPI.Filters
{
    /// <summary>   A logging action filter. </summary>
    public class LoggingActionFilter : IOrionActionFilter
    {
        /// <summary>   The logger. </summary>
        readonly ILogService _logger;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Applications.Example.WebAPI.Filters.Logging.LoggingActionFilter class.
        /// </summary>
        ///
        /// <param name="logger">   The logger. </param>
        ///-------------------------------------------------------------------------------------------------
        public LoggingActionFilter(ILogService logger)
        {
            _logger = logger;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Executes the action executing action. </summary>
        ///
        /// <param name="actionContext">    Context for the action. </param>
        ///-------------------------------------------------------------------------------------------------
        public void OnActionExecuting(HttpActionContext actionContext)
        {
            _logger.Write(actionContext.ActionDescriptor.ActionName);
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Executes the action executed action. </summary>
        ///
        /// <param name="actionExecutedContext">    Context for the action executed. </param>
        ///-------------------------------------------------------------------------------------------------
        public void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            _logger.Write(actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
        }
    }
}