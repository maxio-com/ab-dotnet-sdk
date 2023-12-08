// <copyright file="PricingScheme.cs" company="APIMatic">
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
    /// PricingScheme.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricingScheme
    {
        /// <summary>
        /// Stairstep.
        /// </summary>
        [EnumMember(Value = "stairstep")]
        Stairstep,

        /// <summary>
        /// Volume.
        /// </summary>
        [EnumMember(Value = "volume")]
        Volume,

        /// <summary>
        /// PerUnit.
        /// </summary>
        [EnumMember(Value = "per_unit")]
        PerUnit,

        /// <summary>
        /// Tiered.
        /// </summary>
        [EnumMember(Value = "tiered")]
        Tiered
    }
}