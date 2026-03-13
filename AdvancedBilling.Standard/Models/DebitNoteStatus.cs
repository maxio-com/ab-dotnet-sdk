// <copyright file="DebitNoteStatus.cs" company="APIMatic">
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
    /// DebitNoteStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebitNoteStatus
    {
        /// <summary>
        /// Open.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Applied.
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,

        /// <summary>
        /// Banished.
        /// </summary>
        [EnumMember(Value = "banished")]
        Banished,

        /// <summary>
        /// Paid.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid
    }
}