// <copyright file="CompoundingStrategy.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace AdvancedBilling.Standard.Models
{
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