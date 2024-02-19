// <copyright file="CreatePrepaymentMethod.cs" company="APIMatic">
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
    /// CreatePrepaymentMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreatePrepaymentMethod
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
        /// CreditCardOnFile.
        /// </summary>
        [EnumMember(Value = "credit_card_on_file")]
        CreditCardOnFile,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
}