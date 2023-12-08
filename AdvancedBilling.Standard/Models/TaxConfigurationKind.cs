// <copyright file="TaxConfigurationKind.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

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