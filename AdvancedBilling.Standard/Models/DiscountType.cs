// <copyright file="DiscountType.cs" company="APIMatic">
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
    /// DiscountType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DiscountType
    {
        /// <summary>
        /// Amount.
        /// </summary>
        [EnumMember(Value = "amount")]
        Amount,

        /// <summary>
        /// Percent.
        /// </summary>
        [EnumMember(Value = "percent")]
        Percent
    }
}