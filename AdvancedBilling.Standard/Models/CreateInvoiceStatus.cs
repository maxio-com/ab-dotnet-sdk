// <copyright file="CreateInvoiceStatus.cs" company="APIMatic">
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
    /// CreateInvoiceStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateInvoiceStatus
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
        Open
    }
}