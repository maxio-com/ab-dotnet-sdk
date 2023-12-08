// <copyright file="SubscriptionSort.cs" company="APIMatic">
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
    /// SubscriptionSort.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionSort
    {
        /// <summary>
        /// SignupDate.
        /// </summary>
        [EnumMember(Value = "signup_date")]
        SignupDate,

        /// <summary>
        /// PeriodStart.
        /// </summary>
        [EnumMember(Value = "period_start")]
        PeriodStart,

        /// <summary>
        /// PeriodEnd.
        /// </summary>
        [EnumMember(Value = "period_end")]
        PeriodEnd,

        /// <summary>
        /// NextAssessment.
        /// </summary>
        [EnumMember(Value = "next_assessment")]
        NextAssessment,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt,

        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt
    }
}