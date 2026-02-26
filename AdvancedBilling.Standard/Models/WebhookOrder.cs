// <copyright file="WebhookOrder.cs" company="APIMatic">
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
    /// WebhookOrder.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookOrder
    {
        /// <summary>
        /// NewestFirst.
        /// </summary>
        [EnumMember(Value = "newest_first")]
        NewestFirst,

        /// <summary>
        /// OldestFirst.
        /// </summary>
        [EnumMember(Value = "oldest_first")]
        OldestFirst
    }
}