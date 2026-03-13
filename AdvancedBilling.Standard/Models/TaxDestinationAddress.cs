// <copyright file="TaxDestinationAddress.cs" company="APIMatic">
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