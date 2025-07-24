// <copyright file="Environment.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Default Advanced Billing environment hosted in US. Valid for the majority of our customers..
        /// </summary>
        [EnumMember(Value = "US")]
        US,

        /// <summary>
        /// Advanced Billing environment hosted in EU. Use only when you requested EU hosting for your AB account..
        /// </summary>
        [EnumMember(Value = "EU")]
        EU,
    }
}
