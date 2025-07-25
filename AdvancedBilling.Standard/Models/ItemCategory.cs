// <copyright file="ItemCategory.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

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