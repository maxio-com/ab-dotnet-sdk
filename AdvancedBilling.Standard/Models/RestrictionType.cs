// <copyright file="RestrictionType.cs" company="APIMatic">
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
    /// RestrictionType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestrictionType
    {
        /// <summary>
        /// Component.
        /// </summary>
        [EnumMember(Value = "Component")]
        Component,

        /// <summary>
        /// Product.
        /// </summary>
        [EnumMember(Value = "Product")]
        Product
    }
}