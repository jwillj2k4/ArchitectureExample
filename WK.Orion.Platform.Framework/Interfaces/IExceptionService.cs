using WK.Orion.Platform.Examples.Components.Framework.Models;

namespace WK.Orion.Platform.Examples.Components.Framework.Interfaces
{
    /// <summary>   Interface for exception service. </summary>
    public interface IExceptionService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Writes the given exception dto. </summary>
        ///
        /// <param name="exceptionDto"> The exception dto. </param>
        ///-------------------------------------------------------------------------------------------------
        void Write(ExceptionDto exceptionDto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Throws the given exception dto. </summary>
        ///
        /// <param name="exceptionDto"> The exception dto. </param>
        ///-------------------------------------------------------------------------------------------------
        void Throw(ExceptionDto exceptionDto);
    }
}