// <copyright file="RestrictionType.cs" company="APIMatic">
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
    /// RestrictionType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RestrictionType
    {
        /// <summary>
        /// Component.
        /// </summary>
        [EnumMember(Value = "Component")]
        Component,

        /// <summary>
        /// Product.
        /// </summary>
        [EnumMember(Value = "Product")]
        Product
    }
}