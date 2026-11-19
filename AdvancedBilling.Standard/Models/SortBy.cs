// <copyright file="SortBy.cs" company="APIMatic">
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
    /// SortBy.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortBy
    {
        /// <summary>
        /// Name.
        /// </summary>
        [EnumMember(Value = "name")]
        Name,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt,

        /// <summary>
        /// Kind.
        /// </summary>
        [EnumMember(Value = "kind")]
        Kind,

        /// <summary>
        /// ValueType.
        /// </summary>
        [EnumMember(Value = "value_type")]
        ValueType
    }
}