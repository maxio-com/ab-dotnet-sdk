// <copyright file="FeatureOwnerPricePointType.cs" company="APIMatic">
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
    /// FeatureOwnerPricePointType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureOwnerPricePointType
    {
        /// <summary>
        /// ProductPricePoint.
        /// </summary>
        [EnumMember(Value = "ProductPricePoint")]
        ProductPricePoint,

        /// <summary>
        /// PricePoint.
        /// </summary>
        [EnumMember(Value = "PricePoint")]
        PricePoint
    }
}