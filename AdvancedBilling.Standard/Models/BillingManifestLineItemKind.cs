// <copyright file="BillingManifestLineItemKind.cs" company="APIMatic">
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
    /// BillingManifestLineItemKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BillingManifestLineItemKind
    {
        /// <summary>
        /// Baseline.
        /// </summary>
        [EnumMember(Value = "baseline")]
        Baseline,

        /// <summary>
        /// Initial.
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial,

        /// <summary>
        /// Trial.
        /// </summary>
        [EnumMember(Value = "trial")]
        Trial,

        /// <summary>
        /// Coupon.
        /// </summary>
        [EnumMember(Value = "coupon")]
        Coupon,

        /// <summary>
        /// Component.
        /// </summary>
        [EnumMember(Value = "component")]
        Component,

        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax
    }
}