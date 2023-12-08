// <copyright file="CompoundingStrategy.cs" company="APIMatic">
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
    /// CompoundingStrategy.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CompoundingStrategy
    {
        /// <summary>
        /// Compound.
        /// </summary>
        [EnumMember(Value = "compound")]
        Compound,

        /// <summary>
        /// Fullprice.
        /// </summary>
        [EnumMember(Value = "full-price")]
        Fullprice
    }
}