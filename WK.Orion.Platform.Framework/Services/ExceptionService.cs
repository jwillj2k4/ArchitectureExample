using System;
using WK.Orion.Platform.Examples.Components.Framework.Interfaces;
using WK.Orion.Platform.Examples.Components.Framework.Models;

namespace WK.Orion.Platform.Examples.Components.Framework.Services
{
    /// <summary>   An exception service. </summary>
    [Serializable]
    public class ExceptionService : Exception, IExceptionService
    {
        /// <summary>   The log service. </summary>
        private readonly ILogService _logService;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the WK.Orion.Platform.Examples.Components.Framework.Exceptions.ExceptionService
        ///     class.
        /// </summary>
        ///
        /// <param name="logService">   The log service. </param>
        ///-------------------------------------------------------------------------------------------------
        public ExceptionService(ILogService logService)
        {
            _logService = logService;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Writes the given exception dto. </summary>
        ///
        /// <param name="exceptionDto"> The exception dto. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Write(ExceptionDto exceptionDto)
        {
            _logService.Write(exceptionDto.GetMessage());
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Throws the given exception dto. </summary>
        ///
        /// <exception cref="Exception">    Thrown when an exception error condition occurs. </exception>
        ///
        /// <param name="exceptionDto"> The exception dto. </param>
        ///-------------------------------------------------------------------------------------------------
        public void Throw(ExceptionDto exceptionDto)
        {
            throw new Exception(exceptionDto.GetMessage());
        }
    }
}
