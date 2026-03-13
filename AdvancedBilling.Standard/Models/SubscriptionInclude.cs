// <copyright file="SubscriptionInclude.cs" company="APIMatic">
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
    /// SubscriptionInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum SubscriptionInclude
    {
        /// <summary>
        /// Coupons.
        /// </summary>
        [EnumMember(Value = "coupons")]
        Coupons,

        /// <summary>
        /// SelfServicePageToken.
        /// </summary>
        [EnumMember(Value = "self_service_page_token")]
        SelfServicePageToken
    }
}