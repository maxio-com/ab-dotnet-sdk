// <copyright file="SubscriptionGroupInclude.cs" company="APIMatic">
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
    /// SubscriptionGroupInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionGroupInclude
    {
        /// <summary>
        /// CurrentBillingAmountInCents.
        /// </summary>
        [EnumMember(Value = "current_billing_amount_in_cents")]
        CurrentBillingAmountInCents
    }
}