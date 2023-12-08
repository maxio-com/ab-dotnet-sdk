// <copyright file="TaxDestinationAddress.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// TaxDestinationAddress.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxDestinationAddress
    {
        /// <summary>
        /// ShippingThenBilling.
        /// </summary>
        [EnumMember(Value = "shipping_then_billing")]
        ShippingThenBilling,

        /// <summary>
        /// BillingThenShipping.
        /// </summary>
        [EnumMember(Value = "billing_then_shipping")]
        BillingThenShipping,

        /// <summary>
        /// ShippingOnly.
        /// </summary>
        [EnumMember(Value = "shipping_only")]
        ShippingOnly,

        /// <summary>
        /// BillingOnly.
        /// </summary>
        [EnumMember(Value = "billing_only")]
        BillingOnly
    }
}