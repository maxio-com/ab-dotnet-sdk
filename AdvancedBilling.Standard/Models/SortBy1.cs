// <copyright file="SortBy1.cs" company="APIMatic">
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
    /// SortBy1.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortBy1
    {
        /// <summary>
        /// Name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,

        /// <summary>
        /// UnitName.
        /// </summary>
        [EnumMember(Value = "unit_name")]
        UnitName,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt
    }
}