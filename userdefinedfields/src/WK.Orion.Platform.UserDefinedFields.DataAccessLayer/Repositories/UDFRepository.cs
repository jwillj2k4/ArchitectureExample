using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Converters.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Entities;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Repositories
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   An udf repository. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UDFRepository : IUDFRepository
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The udf converter. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IUDFConverter _iudfConverter;

        ///-------------------------------------------------------------------------------------------------
        /// <summary>
        ///     initializes a new instance of the
        ///     WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Repositories.UDFRepository class.
        /// </summary>
        ///
        /// <param name="iudfConverter"> The udf converter. </param>
        ///-------------------------------------------------------------------------------------------------
        public UDFRepository(IUDFConverter iudfConverter)
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
        public async Task<IOrionUdfDto> GetOne(long id)
        {
            //wire up db context, call to get task
            var task = await Task.FromResult(new OrionUdf());

            var taskDto = _iudfConverter.Convert(task);

            return taskDto;
        }
    }
}