// <copyright file="IncludeOption.cs" company="APIMatic">
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
    /// IncludeOption.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeOption
    {
        /// <summary>
        /// Exclude.
        /// </summary>
        [EnumMember(Value = "0")]
        Exclude,

        /// <summary>
        /// Include.
        /// </summary>
        [EnumMember(Value = "1")]
        Include
    }
}