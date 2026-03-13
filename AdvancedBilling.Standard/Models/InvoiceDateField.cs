// <copyright file="InvoiceDateField.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

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