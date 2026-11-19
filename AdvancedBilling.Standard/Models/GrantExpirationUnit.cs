// <copyright file="GrantExpirationUnit.cs" company="APIMatic">
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
    /// GrantExpirationUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GrantExpirationUnit
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
        /// UntilNextRefill.
        /// </summary>
        [EnumMember(Value = "until_next_refill")]
        UntilNextRefill
    }
}