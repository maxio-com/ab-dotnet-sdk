// <copyright file="CreditNoteStatus.cs" company="APIMatic">
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
    /// CreditNoteStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditNoteStatus
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
        Applied
    }
}