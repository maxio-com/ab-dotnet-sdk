// <copyright file="FeatureKind.cs" company="APIMatic">
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
    /// FeatureKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureKind
    {
        /// <summary>
        /// AccessRight.
        /// </summary>
        [EnumMember(Value = "access_right")]
        AccessRight,

        /// <summary>
        /// UsageLimit.
        /// </summary>
        [EnumMember(Value = "usage_limit")]
        UsageLimit,

        /// <summary>
        /// ServiceRight.
        /// </summary>
        [EnumMember(Value = "service_right")]
        ServiceRight
    }
}