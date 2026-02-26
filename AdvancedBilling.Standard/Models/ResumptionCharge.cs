// <copyright file="ResumptionCharge.cs" company="APIMatic">
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
    /// ResumptionCharge.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResumptionCharge
    {
        /// <summary>
        /// Prorated.
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated,

        /// <summary>
        /// Immediate.
        /// </summary>
        [EnumMember(Value = "immediate")]
        Immediate,

        /// <summary>
        /// Delayed.
        /// </summary>
        [EnumMember(Value = "delayed")]
        Delayed
    }
}