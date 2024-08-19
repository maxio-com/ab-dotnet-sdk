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
        /// Authorizenet.
        /// </summary>
        [EnumMember(Value = "authorizenet")]
        Authorizenet,

        /// <summary>
        /// BlueSnap.
        /// </summary>
        [EnumMember(Value = "blue_snap")]
        BlueSnap,

        /// <summary>
        /// Bogus.
        /// </summary>
        [EnumMember(Value = "bogus")]
        Bogus,

        /// <summary>
        /// Forte.
        /// </summary>
        [EnumMember(Value = "forte")]
        Forte,

        /// <summary>
        /// Gocardless.
        /// </summary>
        [EnumMember(Value = "gocardless")]
        Gocardless,

        /// <summary>
        /// MaxioPayments.
        /// </summary>
        [EnumMember(Value = "maxio_payments")]
        MaxioPayments,

        /// <summary>
        /// Maxp.
        /// </summary>
        [EnumMember(Value = "maxp")]
        Maxp,

        /// <summary>
        /// StripeConnect.
        /// </summary>
        [EnumMember(Value = "stripe_connect")]
        StripeConnect
    }
}