// <copyright file="BankAccountType.cs" company="APIMatic">
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
    /// BankAccountType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountType
    {
        /// <summary>
        /// Checking.
        /// </summary>
        [EnumMember(Value = "checking")]
        Checking,

        /// <summary>
        /// Savings.
        /// </summary>
        [EnumMember(Value = "savings")]
        Savings
    }
}