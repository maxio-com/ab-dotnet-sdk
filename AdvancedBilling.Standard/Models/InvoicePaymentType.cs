// <copyright file="InvoicePaymentType.cs" company="APIMatic">
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
    /// InvoicePaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoicePaymentType
    {
        /// <summary>
        /// External.
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// Prepayment.
        /// </summary>
        [EnumMember(Value = "prepayment")]
        Prepayment,

        /// <summary>
        /// ServiceCredit.
        /// </summary>
        [EnumMember(Value = "service_credit")]
        ServiceCredit,

        /// <summary>
        /// Payment.
        /// </summary>
        [EnumMember(Value = "payment")]
        Payment
    }
}