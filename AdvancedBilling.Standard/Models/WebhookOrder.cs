// <copyright file="WebhookOrder.cs" company="APIMatic">
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
    /// WebhookOrder.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookOrder
    {
        /// <summary>
        /// NewestFirst.
        /// </summary>
        [EnumMember(Value = "newest_first")]
        NewestFirst,

        /// <summary>
        /// OldestFirst.
        /// </summary>
        [EnumMember(Value = "oldest_first")]
        OldestFirst
    }
}