// <copyright file="PrepaymentMethod.cs" company="APIMatic">
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
    /// PrepaymentMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PrepaymentMethod
    {
        /// <summary>
        /// Check.
        /// </summary>
        [EnumMember(Value = "check")]
        Check,

        /// <summary>
        /// Cash.
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash,

        /// <summary>
        /// MoneyOrder.
        /// </summary>
        [EnumMember(Value = "money_order")]
        MoneyOrder,

        /// <summary>
        /// Ach.
        /// </summary>
        [EnumMember(Value = "ach")]
        Ach,

        /// <summary>
        /// PaypalAccount.
        /// </summary>
        [EnumMember(Value = "paypal_account")]
        PaypalAccount,

        /// <summary>
        /// CreditCard.
        /// </summary>
        [EnumMember(Value = "credit_card")]
        CreditCard,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}