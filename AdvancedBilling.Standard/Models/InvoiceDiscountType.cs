// <copyright file="InvoiceDiscountType.cs" company="APIMatic">
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