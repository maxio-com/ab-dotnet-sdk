// <copyright file="WalletStatus.cs" company="APIMatic">
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
    /// WalletStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WalletStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Archived.
        /// </summary>
        [EnumMember(Value = "archived")]
        Archived
    }
}