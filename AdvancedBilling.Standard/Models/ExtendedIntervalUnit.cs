// <copyright file="ExtendedIntervalUnit.cs" company="APIMatic">
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
    /// ExtendedIntervalUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExtendedIntervalUnit
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
        Month,

        /// <summary>
        /// Never.
        /// </summary>
        [EnumMember(Value = "never")]
        Never
    }
}