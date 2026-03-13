// <copyright file="CreditType.cs" company="APIMatic">
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
    /// CreditType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditType
    {
        /// <summary>
        /// Full.
        /// </summary>
        [EnumMember(Value = "full")]
        Full,

        /// <summary>
        /// Prorated.
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}