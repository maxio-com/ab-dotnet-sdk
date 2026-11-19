// <copyright file="Kind1.cs" company="APIMatic">
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
    /// Kind1.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Kind1
    {
        /// <summary>
        /// Grant.
        /// </summary>
        [EnumMember(Value = "grant")]
        Grant,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "debit")]
        Debit
    }
}