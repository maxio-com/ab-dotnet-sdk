// <copyright file="WebhookStatus.cs" company="APIMatic">
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
    /// WebhookStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookStatus
    {
        /// <summary>
        /// Successful.
        /// </summary>
        [EnumMember(Value = "successful")]
        Successful,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Paused.
        /// </summary>
        [EnumMember(Value = "paused")]
        Paused
    }
}