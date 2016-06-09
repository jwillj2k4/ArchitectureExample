using System.Threading.Tasks;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.DataAccessLayer
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   A task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public class UDFUnitOfWork : IUDFUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the udf repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        public IUDFRepository UDFRepo { get; }

        public UDFUnitOfWork(IUDFRepository udfRepo)
        {
            UDFRepo = udfRepo;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets a task&lt; i orion udf dto&gt; using the given identifier. </summary>
        ///
        /// <param name="id">   The identifier to get. </param>
        ///
        /// <returns>   A Task&lt;IOrionUdfDto&gt; </returns>
        ///-------------------------------------------------------------------------------------------------
        public async Task<IOrionUdfDto> Get(long id)
        {
            var taskDto = await UDFRepo.GetOne(id);
             
            return taskDto;
        }
    }
}