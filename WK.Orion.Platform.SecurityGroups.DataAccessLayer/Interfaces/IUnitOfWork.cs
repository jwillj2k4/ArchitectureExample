using WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces.Repositories;

namespace WK.Orion.Platform.SecurityGroups.DataAccessLayer.Interfaces
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>   Interface for task unit of work. </summary>
    ///-------------------------------------------------------------------------------------------------
    public interface ISecurityGroupUnitOfWork
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the task repo. </summary>
        ///
        /// <value> The task repo. </value>
        ///-------------------------------------------------------------------------------------------------
        ISecurityGroupRepository SecurityGroupRepo { get; }
    }
}
