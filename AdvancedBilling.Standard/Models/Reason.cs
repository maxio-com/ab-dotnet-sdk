// <copyright file="Reason.cs" company="APIMatic">
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
    /// Reason.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Reason
    {
        /// <summary>
        /// EntitlementMissing.
        /// </summary>
        [EnumMember(Value = "entitlement_missing")]
        EntitlementMissing,

        /// <summary>
        /// WalletArchived.
        /// </summary>
        [EnumMember(Value = "wallet_archived")]
        WalletArchived,

        /// <summary>
        /// SubscriptionTerminated.
        /// </summary>
        [EnumMember(Value = "subscription_terminated")]
        SubscriptionTerminated,

        /// <summary>
        /// FeatureRemoved.
        /// </summary>
        [EnumMember(Value = "feature_removed")]
        FeatureRemoved,

        /// <summary>
        /// WalletBehaviorDisabled.
        /// </summary>
        [EnumMember(Value = "wallet_behavior_disabled")]
        WalletBehaviorDisabled,

        /// <summary>
        /// SupersededByReplacement.
        /// </summary>
        [EnumMember(Value = "superseded_by_replacement")]
        SupersededByReplacement,

        /// <summary>
        /// SubscriptionPrepaid.
        /// </summary>
        [EnumMember(Value = "subscription_prepaid")]
        SubscriptionPrepaid,

        /// <summary>
        /// AllowanceNotRepresentable.
        /// </summary>
        [EnumMember(Value = "allowance_not_representable")]
        AllowanceNotRepresentable,

        /// <summary>
        /// BalanceAtCapacity.
        /// </summary>
        [EnumMember(Value = "balance_at_capacity")]
        BalanceAtCapacity
    }
}