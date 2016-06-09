using WK.Orion.Platform.Examples.Components.ML.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections;

namespace WK.Orion.Platform.Examples.Components.ML.Core.Converters.Interfaces
{
    /// <summary>   Interface for multilingual converter. </summary>
    public interface IMultilingualConverter
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given multilingual. </summary>
        ///
        /// <param name="dto">  The dto. </param>
        ///
        /// <returns>   An multiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        Multilingual Convert(MultiLingualDto dto);

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Converts the given multilingual. </summary>
        ///
        /// <param name="multilingual"> The multilingual. </param>
        ///
        /// <returns>   An multiLingualDto. </returns>
        ///-------------------------------------------------------------------------------------------------
        MultiLingualDto Convert(Multilingual multilingual);
    }
}