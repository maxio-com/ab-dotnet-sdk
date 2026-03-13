// <copyright file="SubscriptionStateFilter.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionStateFilter.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionStateFilter
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

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
        /// ExpiredCards.
        /// </summary>
        [EnumMember(Value = "expired_cards")]
        ExpiredCards,

        /// <summary>
        /// OnHold.
        /// </summary>
        [EnumMember(Value = "on_hold")]
        OnHold,

        /// <summary>
        /// PastDue.
        /// </summary>
        [EnumMember(Value = "past_due")]
        PastDue,

        /// <summary>
        /// PendingCancellation.
        /// </summary>
        [EnumMember(Value = "pending_cancellation")]
        PendingCancellation,

        /// <summary>
        /// PendingRenewal.
        /// </summary>
        [EnumMember(Value = "pending_renewal")]
        PendingRenewal,

        /// <summary>
        /// Suspended.
        /// </summary>
        [EnumMember(Value = "suspended")]
        Suspended,

        /// <summary>
        /// TrialEnded.
        /// </summary>
        [EnumMember(Value = "trial_ended")]
        TrialEnded,

        /// <summary>
        /// Trialing.
        /// </summary>
        [EnumMember(Value = "trialing")]
        Trialing,

        /// <summary>
        /// Unpaid.
        /// </summary>
        [EnumMember(Value = "unpaid")]
        Unpaid
    }
}