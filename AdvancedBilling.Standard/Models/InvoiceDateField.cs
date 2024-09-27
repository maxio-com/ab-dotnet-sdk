// <copyright file="InvoiceDateField.cs" company="APIMatic">
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
    /// InvoiceDateField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceDateField
    {
        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt,

        /// <summary>
        /// DueDate.
        /// </summary>
        [EnumMember(Value = "due_date")]
        DueDate,

        /// <summary>
        /// IssueDate.
        /// </summary>
        [EnumMember(Value = "issue_date")]
        IssueDate,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt,

        /// <summary>
        /// PaidDate.
        /// </summary>
        [EnumMember(Value = "paid_date")]
        PaidDate
    }
}