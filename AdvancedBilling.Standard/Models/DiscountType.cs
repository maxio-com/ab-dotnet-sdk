// <copyright file="DiscountType.cs" company="APIMatic">
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
    /// DiscountType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiscountType
    {
        /// <summary>
        /// Amount.
        /// </summary>
        [EnumMember(Value = "amount")]
        Amount,

        /// <summary>
        /// Percent.
        /// </summary>
        [EnumMember(Value = "percent")]
        Percent
    }
}