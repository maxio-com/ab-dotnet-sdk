// <copyright file="SubscriptionDateField.cs" company="APIMatic">
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
    /// SubscriptionDateField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionDateField
    {
        /// <summary>
        /// CurrentPeriodEndsAt.
        /// </summary>
        [EnumMember(Value = "current_period_ends_at")]
        CurrentPeriodEndsAt,

        /// <summary>
        /// CurrentPeriodStartsAt.
        /// </summary>
        [EnumMember(Value = "current_period_starts_at")]
        CurrentPeriodStartsAt,

        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt,

        /// <summary>
        /// ActivatedAt.
        /// </summary>
        [EnumMember(Value = "activated_at")]
        ActivatedAt,

        /// <summary>
        /// CanceledAt.
        /// </summary>
        [EnumMember(Value = "canceled_at")]
        CanceledAt,

        /// <summary>
        /// ExpiresAt.
        /// </summary>
        [EnumMember(Value = "expires_at")]
        ExpiresAt,

        /// <summary>
        /// TrialStartedAt.
        /// </summary>
        [EnumMember(Value = "trial_started_at")]
        TrialStartedAt,

        /// <summary>
        /// TrialEndedAt.
        /// </summary>
        [EnumMember(Value = "trial_ended_at")]
        TrialEndedAt,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt
    }
}