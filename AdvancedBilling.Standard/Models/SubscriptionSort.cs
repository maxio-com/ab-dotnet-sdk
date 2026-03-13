// <copyright file="SubscriptionSort.cs" company="APIMatic">
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
        CreatedAt,

        /// <summary>
        /// TotalPayments.
        /// </summary>
        [EnumMember(Value = "total_payments")]
        TotalPayments,

        /// <summary>
        /// Id.
        /// </summary>
        [EnumMember(Value = "id")]
        Id,

        /// <summary>
        /// OpenBalance.
        /// </summary>
        [EnumMember(Value = "open_balance")]
        OpenBalance,

        /// <summary>
        /// ExpiresAt.
        /// </summary>
        [EnumMember(Value = "expires_at")]
        ExpiresAt
    }
}