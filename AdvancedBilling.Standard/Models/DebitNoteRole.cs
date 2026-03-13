// <copyright file="DebitNoteRole.cs" company="APIMatic">
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
    /// DebitNoteRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebitNoteRole
    {
        /// <summary>
        /// Chargeback.
        /// </summary>
        [EnumMember(Value = "chargeback")]
        Chargeback,

        /// <summary>
        /// Refund.
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund
    }
}