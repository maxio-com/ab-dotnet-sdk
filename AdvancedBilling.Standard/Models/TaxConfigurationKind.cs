// <copyright file="TaxConfigurationKind.cs" company="APIMatic">
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
    /// TaxConfigurationKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TaxConfigurationKind
    {
        /// <summary>
        /// Custom.
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom,

        /// <summary>
        /// EnumManagedAvalara.
        /// </summary>
        [EnumMember(Value = "managed avalara")]
        EnumManagedAvalara,

        /// <summary>
        /// EnumLinkedAvalara.
        /// </summary>
        [EnumMember(Value = "linked avalara")]
        EnumLinkedAvalara,

        /// <summary>
        /// EnumDigitalRiver.
        /// </summary>
        [EnumMember(Value = "digital river")]
        EnumDigitalRiver
    }
}