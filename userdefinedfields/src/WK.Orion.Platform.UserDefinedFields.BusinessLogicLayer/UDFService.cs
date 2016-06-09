using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.BusinessLogicLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.BusinessLogicLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task service. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UDFService : IUDFService
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   The task unit of work. </summary>
        ///-------------------------------------------------------------------------------------------------
        private readonly IUDFUnitOfWork _udfUnitOfWork;

        public UDFService(IUDFUnitOfWork udfUnitOfWork)
        {
            _udfUnitOfWork = udfUnitOfWork;
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
            var taskDto = await _udfUnitOfWork.UDFRepo.GetOne(id);

            return taskDto;
        }
    }
}