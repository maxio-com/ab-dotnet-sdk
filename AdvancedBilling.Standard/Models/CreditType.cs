// <copyright file="CreditType.cs" company="APIMatic">
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
    /// CreditType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditType
    {
        /// <summary>
        /// Full.
        /// </summary>
        [EnumMember(Value = "full")]
        Full,

        /// <summary>
        /// Prorated.
        /// </summary>
        [EnumMember(Value = "prorated")]
        Prorated,

        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
}