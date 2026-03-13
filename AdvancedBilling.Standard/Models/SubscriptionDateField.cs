// <copyright file="SubscriptionDateField.cs" company="APIMatic">
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