// <copyright file="SubscriptionPurgeType.cs" company="APIMatic">
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
    /// SubscriptionPurgeType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionPurgeType
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "customer")]
        Customer,

        /// <summary>
        /// PaymentProfile.
        /// </summary>
        [EnumMember(Value = "payment_profile")]
        PaymentProfile
    }
}