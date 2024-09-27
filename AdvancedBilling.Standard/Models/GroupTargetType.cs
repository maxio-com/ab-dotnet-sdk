// <copyright file="GroupTargetType.cs" company="APIMatic">
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
    /// GroupTargetType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupTargetType
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "subscription")]
        Subscription,

        /// <summary>
        /// Self.
        /// </summary>
        [EnumMember(Value = "self")]
        Self,

        /// <summary>
        /// Parent.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent,

        /// <summary>
        /// Eldest.
        /// </summary>
        [EnumMember(Value = "eldest")]
        Eldest
    }
}