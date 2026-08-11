// <copyright file="QScope.cs" company="APIMatic">
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
    /// QScope.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum QScope
    {
        /// <summary>
        /// FullName.
        /// </summary>
        [EnumMember(Value = "full_name")]
        FullName,

        /// <summary>
        /// FirstName.
        /// </summary>
        [EnumMember(Value = "first_name")]
        FirstName,

        /// <summary>
        /// LastName.
        /// </summary>
        [EnumMember(Value = "last_name")]
        LastName,

        /// <summary>
        /// Organization.
        /// </summary>
        [EnumMember(Value = "organization")]
        Organization,

        /// <summary>
        /// CustomerReference.
        /// </summary>
        [EnumMember(Value = "customer_reference")]
        CustomerReference,

        /// <summary>
        /// SubscriptionReference.
        /// </summary>
        [EnumMember(Value = "subscription_reference")]
        SubscriptionReference,

        /// <summary>
        /// LastFour.
        /// </summary>
        [EnumMember(Value = "last_four")]
        LastFour
    }
}