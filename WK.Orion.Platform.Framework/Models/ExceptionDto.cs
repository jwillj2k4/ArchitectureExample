namespace WK.Orion.Platform.Examples.Components.Framework.Models
{
    /// <summary>   An exception dto. </summary>
    public class ExceptionDto
    {
        /// <summary>   Message describing the error. </summary>
        private readonly string _errorMessage;
        /// <summary>   The arguments. </summary>
        private readonly object[] _args;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.Framework.Exceptions.Models.ExceptionDto class.
        /// </summary>
        ///
        /// <param name="errorMessage"> Message describing the error. </param>
        /// <param name="args">         A variable-length parameters list containing arguments. </param>
        ///-------------------------------------------------------------------------------------------------
        public ExceptionDto(string errorMessage, params object[] args)
        {
            _errorMessage = errorMessage;
            _args = args;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets the message. </summary>
        ///
        /// <returns>   The message. </returns>
        ///-------------------------------------------------------------------------------------------------
        public string GetMessage()
        {
            var result = _errorMessage;

            if (_args != null && _args.Length > 0)
            {
                result = string.Format(_errorMessage, _args);
            }

            return result;
        }
    }
}