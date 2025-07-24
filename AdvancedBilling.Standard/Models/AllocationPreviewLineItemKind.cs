// <copyright file="AllocationPreviewLineItemKind.cs" company="APIMatic">
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
    /// AllocationPreviewLineItemKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllocationPreviewLineItemKind
    {
        /// <summary>
        /// QuantityBasedComponent.
        /// </summary>
        [EnumMember(Value = "quantity_based_component")]
        QuantityBasedComponent,

        /// <summary>
        /// OnOffComponent.
        /// </summary>
        [EnumMember(Value = "on_off_component")]
        OnOffComponent,

        /// <summary>
        /// Coupon.
        /// </summary>
        [EnumMember(Value = "coupon")]
        Coupon,

        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax
    }
}