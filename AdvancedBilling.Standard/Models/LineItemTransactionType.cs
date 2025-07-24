// <copyright file="LineItemTransactionType.cs" company="APIMatic">
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
    /// LineItemTransactionType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum LineItemTransactionType
    {
        /// <summary>
        /// Charge.
        /// </summary>
        [EnumMember(Value = "charge")]
        Charge,

        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "credit")]
        Credit,

        /// <summary>
        /// Adjustment.
        /// </summary>
        [EnumMember(Value = "adjustment")]
        Adjustment,

        /// <summary>
        /// Payment.
        /// </summary>
        [EnumMember(Value = "payment")]
        Payment,

        /// <summary>
        /// Refund.
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund,

        /// <summary>
        /// InfoTransaction.
        /// </summary>
        [EnumMember(Value = "info_transaction")]
        InfoTransaction,

        /// <summary>
        /// PaymentAuthorization.
        /// </summary>
        [EnumMember(Value = "payment_authorization")]
        PaymentAuthorization
    }
}