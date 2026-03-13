// <copyright file="LineItemTransactionType.cs" company="APIMatic">
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