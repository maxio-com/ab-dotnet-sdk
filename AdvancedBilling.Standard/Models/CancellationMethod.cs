// <copyright file="CancellationMethod.cs" company="APIMatic">
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
    /// CancellationMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CancellationMethod
    {
        /// <summary>
        /// MerchantUi.
        /// </summary>
        [EnumMember(Value = "merchant_ui")]
        MerchantUi,

        /// <summary>
        /// MerchantApi.
        /// </summary>
        [EnumMember(Value = "merchant_api")]
        MerchantApi,

        /// <summary>
        /// Dunning.
        /// </summary>
        [EnumMember(Value = "dunning")]
        Dunning,

        /// <summary>
        /// BillingPortal.
        /// </summary>
        [EnumMember(Value = "billing_portal")]
        BillingPortal,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Imported.
        /// </summary>
        [EnumMember(Value = "imported")]
        Imported
    }
}