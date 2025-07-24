// <copyright file="SubscriptionState.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// SubscriptionState.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionState
    {
        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// FailedToCreate.
        /// </summary>
        [EnumMember(Value = "failed_to_create")]
        FailedToCreate,

        /// <summary>
        /// Trialing.
        /// </summary>
        [EnumMember(Value = "trialing")]
        Trialing,

        /// <summary>
        /// Assessing.
        /// </summary>
        [EnumMember(Value = "assessing")]
        Assessing,

        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// SoftFailure.
        /// </summary>
        [EnumMember(Value = "soft_failure")]
        SoftFailure,

        /// <summary>
        /// PastDue.
        /// </summary>
        [EnumMember(Value = "past_due")]
        PastDue,

        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled,

        /// <summary>
        /// Expired.
        /// </summary>
        [EnumMember(Value = "expired")]
        Expired,

        /// <summary>
        /// Paused.
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused,

        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid,

        /// <summary>
        /// TrialEnded.
        /// </summary>
        [EnumMember(Value = "trial_ended")]
        TrialEnded,

        /// <summary>
        /// OnHold.
        /// </summary>
        [EnumMember(Value = "on_hold")]
        OnHold,

        /// <summary>
        /// AwaitingSignup.
        /// </summary>
        [EnumMember(Value = "awaiting_signup")]
        AwaitingSignup
    }
}