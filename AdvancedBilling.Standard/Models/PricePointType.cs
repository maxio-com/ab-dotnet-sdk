// <copyright file="PricePointType.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
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