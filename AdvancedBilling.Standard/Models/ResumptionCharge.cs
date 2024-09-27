// <copyright file="ResumptionCharge.cs" company="APIMatic">
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
    /// ResumptionCharge.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResumptionCharge
    {
        /// <summary>
        /// Prorated.
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated,

        /// <summary>
        /// Immediate.
        /// </summary>
        [EnumMember(Value = "immediate")]
        Immediate,

        /// <summary>
        /// Delayed.
        /// </summary>
        [EnumMember(Value = "delayed")]
        Delayed
    }
}