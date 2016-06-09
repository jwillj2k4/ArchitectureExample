namespace WK.Orion.Platform.Examples.Components.Framework.Interfaces
{
    /// <summary>   Interface for log service. </summary>
    public interface ILogService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Writes. </summary>
        ///
        /// <param name="message">   The action name to write. </param>
        ///-------------------------------------------------------------------------------------------------
        void Write(string message);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Writes a fatal. </summary>
        ///
        /// <param name="message">  The message. </param>
        ///-------------------------------------------------------------------------------------------------
        void WriteFatal(string message);
    }
}