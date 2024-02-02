// <copyright file="InvoiceEventPaymentMethod.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

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