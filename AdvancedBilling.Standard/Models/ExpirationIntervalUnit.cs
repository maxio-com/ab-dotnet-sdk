// <copyright file="ExpirationIntervalUnit.cs" company="APIMatic">
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
    /// ExpirationIntervalUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExpirationIntervalUnit
    {
        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Month.
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never
    }
}