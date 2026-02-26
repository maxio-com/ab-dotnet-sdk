// <copyright file="SortingDirection.cs" company="APIMatic">
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
    /// SortingDirection.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortingDirection
    {
        /// <summary>
        /// Asc.
        /// </summary>
        [EnumMember(Value = "asc")]
        Asc,

        /// <summary>
        /// Desc.
        /// </summary>
        [EnumMember(Value = "desc")]
        Desc
    }
}