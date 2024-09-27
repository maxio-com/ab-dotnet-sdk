// <copyright file="CreditScheme.cs" company="APIMatic">
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
    /// CreditScheme.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditScheme
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// Refund.
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund
    }
}