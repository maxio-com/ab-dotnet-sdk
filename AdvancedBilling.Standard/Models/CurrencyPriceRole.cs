// <copyright file="CurrencyPriceRole.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// CurrencyPriceRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyPriceRole
    {
        /// <summary>
        /// Baseline.
        /// </summary>
        [EnumMember(Value = "baseline")]
        Baseline,

        /// <summary>
        /// Trial.
        /// </summary>
        [EnumMember(Value = "trial")]
        Trial,

        /// <summary>
        /// Initial.
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial
    }
}