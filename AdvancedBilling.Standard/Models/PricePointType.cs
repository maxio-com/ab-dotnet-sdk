// <copyright file="PricePointType.cs" company="APIMatic">
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
    /// PricePointType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PricePointType
    {
        /// <summary>
        /// Catalog.
        /// </summary>
        [EnumMember(Value = "catalog")]
        Catalog,

        /// <summary>
        /// Default.
        /// </summary>
        [EnumMember(Value = "default")]
        Default,

        /// <summary>
        /// Custom.
        /// </summary>
        [EnumMember(Value = "custom")]
        Custom
    }
}