// <copyright file="WalletHardStopOverflow.cs" company="APIMatic">
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
    /// WalletHardStopOverflow.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WalletHardStopOverflow
    {
        /// <summary>
        /// Discard.
        /// </summary>
        [EnumMember(Value = "discard")]
        Discard,

        /// <summary>
        /// AllowNegative.
        /// </summary>
        [EnumMember(Value = "allow_negative")]
        AllowNegative
    }
}