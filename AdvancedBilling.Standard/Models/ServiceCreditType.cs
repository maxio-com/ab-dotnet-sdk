// <copyright file="ServiceCreditType.cs" company="APIMatic">
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
    /// ServiceCreditType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceCreditType
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "Credit")]
        Credit,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "Debit")]
        Debit
    }
}