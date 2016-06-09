using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.ML.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.ML.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.ML.DataAccessLayer.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An udf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class MultiLingualRepository : IMultiLingualRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The udf converter. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IMultilingualConverter _iudfConverter;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Repositories.MultiLingualRepository class.
        /// </summary>
        ///
        /// <param name="iudfConverter"> The udf converter. </param>
        ///-------------------------------------------------------------------------------------------------
        public MultiLingualRepository(IMultilingualConverter iudfConverter)
        {
            _iudfConverter = iudfConverter;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets an one. </summary>
        ///
        /// <param name="id">   The identifier. </param>
        ///
        /// <returns>   The one. </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IMultiLingualDto> GetOne(long id)
        {
            //wire up db context, call to get task
            var task = await Task.FromResult(new Multilingual());

            var taskDto = _iudfConverter.Convert(task);

            return taskDto;
        }
    }
}