// <copyright file="InvoiceDiscountType.cs" company="APIMatic">
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
    /// InvoiceDiscountType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceDiscountType
    {
        /// <summary>
        /// Percentage.
        /// </summary>
        [EnumMember(Value = "percentage")]
        Percentage,

        /// <summary>
        /// FlatAmount.
        /// </summary>
        [EnumMember(Value = "flat_amount")]
        FlatAmount,

        /// <summary>
        /// Rollover.
        /// </summary>
        [EnumMember(Value = "rollover")]
        Rollover
    }
}