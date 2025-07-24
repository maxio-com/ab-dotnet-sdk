// <copyright file="InvoicePaymentType.cs" company="APIMatic">
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