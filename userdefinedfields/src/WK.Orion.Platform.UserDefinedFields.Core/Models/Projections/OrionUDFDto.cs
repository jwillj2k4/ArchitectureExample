using System;
using WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections.Interfaces;

namespace WK.Orion.Platform.Examples.Components.UserDefinedFields.Core.Models.Projections
{
    public class OrionUdfDto : IOrionUdfDto
    {
        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ///-------------------------------------------------------------------------------------------------
        public int Id { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        ///-------------------------------------------------------------------------------------------------
        public string Name { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the date created. </summary>
        ///
        /// <value> The date created. </value>
        ///-------------------------------------------------------------------------------------------------
        public DateTimeOffset DateCreated { get; set; }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>   Gets or sets the identifier of the created by user. </summary>
        ///
        /// <value> The identifier of the created by user. </value>
        ///-------------------------------------------------------------------------------------------------
        public long CreatedByUserId { get; set; }
    }
}