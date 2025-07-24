// <copyright file="TaxConfigurationKind.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

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