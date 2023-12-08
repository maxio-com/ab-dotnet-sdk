// <copyright file="ResourceType.cs" company="APIMatic">
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
    /// ResourceType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResourceType
    {
        /// <summary>
        /// Subscriptions.
        /// </summary>
        [EnumMember(Value = "subscriptions")]
        Subscriptions,

        /// <summary>
        /// Customers.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers
    }
}