// <copyright file="MetafieldInput.cs" company="APIMatic">
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
    /// MetafieldInput.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum MetafieldInput
    {
        /// <summary>
        /// BalanceTracker.
        /// </summary>
        [EnumMember(Value = "balance_tracker")]
        BalanceTracker,

        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Radio.
        /// </summary>
        [EnumMember(Value = "radio")]
        Radio,

        /// <summary>
        /// Dropdown.
        /// </summary>
        [EnumMember(Value = "dropdown")]
        Dropdown
    }
}