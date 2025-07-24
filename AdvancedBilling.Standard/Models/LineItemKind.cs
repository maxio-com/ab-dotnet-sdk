// <copyright file="LineItemKind.cs" company="APIMatic">
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
    /// LineItemKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineItemKind
    {
        /// <summary>
        /// Baseline.
        /// </summary>
        [EnumMember(Value = "baseline")]
        Baseline,

        /// <summary>
        /// Initial.
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial,

        /// <summary>
        /// Trial.
        /// </summary>
        [EnumMember(Value = "trial")]
        Trial,

        /// <summary>
        /// QuantityBasedComponent.
        /// </summary>
        [EnumMember(Value = "quantity_based_component")]
        QuantityBasedComponent,

        /// <summary>
        /// PrepaidUsageComponent.
        /// </summary>
        [EnumMember(Value = "prepaid_usage_component")]
        PrepaidUsageComponent,

        /// <summary>
        /// OnOffComponent.
        /// </summary>
        [EnumMember(Value = "on_off_component")]
        OnOffComponent,

        /// <summary>
        /// MeteredComponent.
        /// </summary>
        [EnumMember(Value = "metered_component")]
        MeteredComponent,

        /// <summary>
        /// EventBasedComponent.
        /// </summary>
        [EnumMember(Value = "event_based_component")]
        EventBasedComponent,

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