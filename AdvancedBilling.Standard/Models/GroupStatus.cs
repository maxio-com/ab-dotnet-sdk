// <copyright file="GroupStatus.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// GroupStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupStatus
    {
        /// <summary>
        /// Ungrouped.
        /// </summary>
        [EnumMember(Value = "ungrouped")]
        Ungrouped,

        /// <summary>
        /// Grouped.
        /// </summary>
        [EnumMember(Value = "grouped")]
        Grouped
    }
}