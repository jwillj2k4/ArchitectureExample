using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Converters.Interfaces
{
    /// <summary>   Interface for udf converter. </summary>
    public interface IUDFConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given udf. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An OrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionUdf Convert(OrionUdfDto dto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given udf. </summary>
        ///
        /// <param name="udf"> The udf. </param>
        ///
        /// <returns>   An OrionUdfDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        OrionUdfDto Convert(OrionUdf udf);
    }
}