// <copyright file="CurrencyPriceRole.cs" company="APIMatic">
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
    /// CurrencyPriceRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyPriceRole
    {
        /// <summary>
        /// Baseline.
        /// </summary>
        [EnumMember(Value = "baseline")]
        Baseline,

        /// <summary>
        /// Trial.
        /// </summary>
        [EnumMember(Value = "trial")]
        Trial,

        /// <summary>
        /// Initial.
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial
    }
}