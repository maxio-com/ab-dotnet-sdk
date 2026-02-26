// <copyright file="CustomFieldOwner.cs" company="APIMatic">
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
    /// CustomFieldOwner.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomFieldOwner
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer,

        /// <summary>
        /// Subscription.
        /// </summary>
        [EnumMember(Value = "Subscription")]
        Subscription
    }
}