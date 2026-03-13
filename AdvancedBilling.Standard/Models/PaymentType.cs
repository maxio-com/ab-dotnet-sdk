// <copyright file="PaymentType.cs" company="APIMatic">
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
    /// PaymentType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentType
    {
        /// <summary>
        /// CreditCard.
        /// </summary>
        [EnumMember(Value = "credit_card")]
        CreditCard,

        /// <summary>
        /// BankAccount.
        /// </summary>
        [EnumMember(Value = "bank_account")]
        BankAccount,

        /// <summary>
        /// PaypalAccount.
        /// </summary>
        [EnumMember(Value = "paypal_account")]
        PaypalAccount,

        /// <summary>
        /// ApplePay.
        /// </summary>
        [EnumMember(Value = "apple_pay")]
        ApplePay
    }
}