// <copyright file="PricePointType.cs" company="APIMatic">
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
    /// PricePointType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricePointType
    {
        /// <summary>
        /// Catalog.
        /// </summary>
        [EnumMember(Value = "catalog")]
        Catalog,

        /// <summary>
        /// Default.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// Custom.
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom
    }
}