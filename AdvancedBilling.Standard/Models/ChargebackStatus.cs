// <copyright file="ChargebackStatus.cs" company="APIMatic">
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
    /// ChargebackStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargebackStatus
    {
        /// <summary>
        /// Open.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Lost.
        /// </summary>
        [EnumMember(Value = "lost")]
        Lost,

        /// <summary>
        /// Won.
        /// </summary>
        [EnumMember(Value = "won")]
        Won,

        /// <summary>
        /// Closed.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed
    }
}