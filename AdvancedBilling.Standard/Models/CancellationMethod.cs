// <copyright file="CancellationMethod.cs" company="APIMatic">
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
        BillingPortal
    }
}