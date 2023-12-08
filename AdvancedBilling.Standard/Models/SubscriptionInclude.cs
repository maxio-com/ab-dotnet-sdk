// <copyright file="SubscriptionInclude.cs" company="APIMatic">
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
    /// SubscriptionInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionInclude
    {
        /// <summary>
        /// Coupons.
        /// </summary>
        [EnumMember(Value = "coupons")]
        Coupons,

        /// <summary>
        /// SelfServicePageToken.
        /// </summary>
        [EnumMember(Value = "self_service_page_token")]
        SelfServicePageToken
    }
}