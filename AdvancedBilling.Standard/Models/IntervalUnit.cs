// <copyright file="IntervalUnit.cs" company="APIMatic">
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
    /// IntervalUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IntervalUnit
    {
        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Month.
        /// </summary>
        [EnumMember(Value = "month")]
        Month
    }
}