// <copyright file="WalletRecurringFundingStatus.cs" company="APIMatic">
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
    /// WalletRecurringFundingStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WalletRecurringFundingStatus
    {
        /// <summary>
        /// Active.
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Erroring.
        /// </summary>
        [EnumMember(Value = "erroring")]
        Erroring,

        /// <summary>
        /// Stopped.
        /// </summary>
        [EnumMember(Value = "stopped")]
        Stopped
    }
}