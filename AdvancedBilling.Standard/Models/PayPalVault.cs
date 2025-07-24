// <copyright file="PayPalVault.cs" company="APIMatic">
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
    /// PayPalVault.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayPalVault
    {
        /// <summary>
        /// BraintreeBlue.
        /// </summary>
        [EnumMember(Value = "braintree_blue")]
        BraintreeBlue,

        /// <summary>
        /// Paypal.
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal,

        /// <summary>
        /// Moduslink.
        /// </summary>
        [EnumMember(Value = "moduslink")]
        Moduslink,

        /// <summary>
        /// PaypalComplete.
        /// </summary>
        [EnumMember(Value = "paypal_complete")]
        PaypalComplete
    }
}