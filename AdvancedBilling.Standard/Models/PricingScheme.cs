// <copyright file="PricingScheme.cs" company="APIMatic">
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
    /// PricingScheme.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricingScheme
    {
        /// <summary>
        /// Stairstep.
        /// </summary>
        [EnumMember(Value = "stairstep")]
        Stairstep,

        /// <summary>
        /// Volume.
        /// </summary>
        [EnumMember(Value = "volume")]
        Volume,

        /// <summary>
        /// PerUnit.
        /// </summary>
        [EnumMember(Value = "per_unit")]
        PerUnit,

        /// <summary>
        /// Tiered.
        /// </summary>
        [EnumMember(Value = "tiered")]
        Tiered
    }
}