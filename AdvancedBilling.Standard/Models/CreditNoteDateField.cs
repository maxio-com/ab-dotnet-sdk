// <copyright file="CreditNoteDateField.cs" company="APIMatic">
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
    /// CreditNoteDateField.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditNoteDateField
    {
        /// <summary>
        /// IssueDate.
        /// </summary>
        [EnumMember(Value = "issue_date")]
        IssueDate,

        /// <summary>
        /// AppliedDate.
        /// </summary>
        [EnumMember(Value = "applied_date")]
        AppliedDate,

        /// <summary>
        /// CreatedAt.
        /// </summary>
        [EnumMember(Value = "created_at")]
        CreatedAt,

        /// <summary>
        /// UpdatedAt.
        /// </summary>
        [EnumMember(Value = "updated_at")]
        UpdatedAt
    }
}