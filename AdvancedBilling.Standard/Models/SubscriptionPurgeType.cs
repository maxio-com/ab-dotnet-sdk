// <copyright file="SubscriptionPurgeType.cs" company="APIMatic">
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
    /// SubscriptionPurgeType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPurgeType
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// PaymentProfile.
        /// </summary>
        [EnumMember(Value = "payment_profile")]
        PaymentProfile
    }
}