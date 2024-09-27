// <copyright file="BillingManifestLineItemKind.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// BillingManifestLineItemKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BillingManifestLineItemKind
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
        /// Coupon.
        /// </summary>
        [EnumMember(Value = "coupon")]
        Coupon,

        /// <summary>
        /// Component.
        /// </summary>
        [EnumMember(Value = "component")]
        Component,

        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax
    }
}