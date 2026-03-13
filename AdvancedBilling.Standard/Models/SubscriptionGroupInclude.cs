// <copyright file="SubscriptionGroupInclude.cs" company="APIMatic">
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
    /// SubscriptionGroupInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionGroupInclude
    {
        /// <summary>
        /// CurrentBillingAmountInCents.
        /// </summary>
        [EnumMember(Value = "current_billing_amount_in_cents")]
        CurrentBillingAmountInCents
    }
}