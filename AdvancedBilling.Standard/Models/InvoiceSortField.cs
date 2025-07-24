// <copyright file="InvoiceSortField.cs" company="APIMatic">
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
    /// InvoiceSortField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceSortField
    {
        /// <summary>
        /// Status.
        /// </summary>
        [EnumMember(Value = "status")]
        Status,

        /// <summary>
        /// TotalAmount.
        /// </summary>
        [EnumMember(Value = "total_amount")]
        TotalAmount,

        /// <summary>
        /// DueAmount.
        /// </summary>
        [EnumMember(Value = "due_amount")]
        DueAmount,

        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt,

        /// <summary>
        /// IssueDate.
        /// </summary>
        [EnumMember(Value = "issue_date")]
        IssueDate,

        /// <summary>
        /// DueDate.
        /// </summary>
        [EnumMember(Value = "due_date")]
        DueDate,

        /// <summary>
        /// Number.
        /// </summary>
        [EnumMember(Value = "number")]
        Number
    }
}