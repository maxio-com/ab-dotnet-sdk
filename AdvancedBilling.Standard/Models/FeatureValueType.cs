// <copyright file="FeatureValueType.cs" company="APIMatic">
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
    /// FeatureValueType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FeatureValueType
    {
        /// <summary>
        /// Text.
        /// </summary>
        [EnumMember(Value = "text")]
        Text,

        /// <summary>
        /// Boolean.
        /// </summary>
        [EnumMember(Value = "boolean")]
        Boolean,

        /// <summary>
        /// Numeric.
        /// </summary>
        [EnumMember(Value = "numeric")]
        Numeric
    }
}