// <copyright file="ItemCategory.cs" company="APIMatic">
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
    /// ItemCategory.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ItemCategory
    {
        /// <summary>
        /// EnumBusinessSoftware.
        /// </summary>
        [EnumMember(Value = "Business Software")]
        EnumBusinessSoftware,

        /// <summary>
        /// EnumConsumerSoftware.
        /// </summary>
        [EnumMember(Value = "Consumer Software")]
        EnumConsumerSoftware,

        /// <summary>
        /// EnumDigitalServices.
        /// </summary>
        [EnumMember(Value = "Digital Services")]
        EnumDigitalServices,

        /// <summary>
        /// EnumPhysicalGoods.
        /// </summary>
        [EnumMember(Value = "Physical Goods")]
        EnumPhysicalGoods,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "Other")]
        Other
    }
}