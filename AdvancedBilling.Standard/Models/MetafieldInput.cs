// <copyright file="MetafieldInput.cs" company="APIMatic">
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