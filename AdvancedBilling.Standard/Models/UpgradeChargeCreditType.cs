// <copyright file="UpgradeChargeCreditType.cs" company="APIMatic">
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
    /// UpgradeChargeCreditType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UpgradeChargeCreditType
    {
        /// <summary>
        /// Full.
        /// </summary>
        [EnumMember(Value = "full")]
        Full,

        /// <summary>
        /// Prorated.
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}