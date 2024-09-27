// <copyright file="InvoiceStatus.cs" company="APIMatic">
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
    /// InvoiceStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceStatus
    {
        /// <summary>
        /// Draft.
        /// </summary>
        [EnumMember(Value = "draft")]
        Draft,

        /// <summary>
        /// Open.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Paid.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Voided.
        /// </summary>
        [EnumMember(Value = "voided")]
        Voided,

        /// <summary>
        /// Canceled.
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled
    }
}