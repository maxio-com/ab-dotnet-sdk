// <copyright file="SubscriptionListInclude.cs" company="APIMatic">
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
    /// SubscriptionListInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionListInclude
    {
        /// <summary>
        /// SelfServicePageToken.
        /// </summary>
        [EnumMember(Value = "self_service_page_token")]
        SelfServicePageToken,

        /// <summary>
        /// CurrentAccountBalanceInCents.
        /// </summary>
        [EnumMember(Value = "current_account_balance_in_cents")]
        CurrentAccountBalanceInCents,

        /// <summary>
        /// CurrentBillingAmount.
        /// </summary>
        [EnumMember(Value = "current_billing_amount")]
        CurrentBillingAmount,

        /// <summary>
        /// ThreeDsActionLink.
        /// </summary>
        [EnumMember(Value = "three_ds_action_link")]
        ThreeDsActionLink,

        /// <summary>
        /// Coupons.
        /// </summary>
        [EnumMember(Value = "coupons")]
        Coupons
    }
}