// <copyright file="BankAccountVault.cs" company="APIMatic">
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
    /// BankAccountVault.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountVault
    {
        /// <summary>
        /// Bogus.
        /// </summary>
        [EnumMember(Value = "bogus")]
        Bogus,

        /// <summary>
        /// Authorizenet.
        /// </summary>
        [EnumMember(Value = "authorizenet")]
        Authorizenet,

        /// <summary>
        /// StripeConnect.
        /// </summary>
        [EnumMember(Value = "stripe_connect")]
        StripeConnect,

        /// <summary>
        /// BraintreeBlue.
        /// </summary>
        [EnumMember(Value = "braintree_blue")]
        BraintreeBlue,

        /// <summary>
        /// Gocardless.
        /// </summary>
        [EnumMember(Value = "gocardless")]
        Gocardless
    }
}