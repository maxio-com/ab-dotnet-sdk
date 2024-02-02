// <copyright file="CustomFieldOwner.cs" company="APIMatic">
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
    /// CustomFieldOwner.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomFieldOwner
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer,

        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "Subscription")]
        Subscription
    }
}