// <copyright file="InvoiceEventPaymentMethod.cs" company="APIMatic">
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
    /// InvoiceEventPaymentMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceEventPaymentMethod
    {
        /// <summary>
        /// ApplePay.
        /// </summary>
        [EnumMember(Value = "apple_pay")]
        ApplePay,

        /// <summary>
        /// BankAccount.
        /// </summary>
        [EnumMember(Value = "bank_account")]
        BankAccount,

        /// <summary>
        /// CreditCard.
        /// </summary>
        [EnumMember(Value = "credit_card")]
        CreditCard,

        /// <summary>
        /// External.
        /// </summary>
        [EnumMember(Value = "external")]
        External,

        /// <summary>
        /// PaypalAccount.
        /// </summary>
        [EnumMember(Value = "paypal_account")]
        PaypalAccount
    }
}