// <copyright file="TaxDestinationAddress.cs" company="APIMatic">
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