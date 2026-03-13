// <copyright file="CleanupScope.cs" company="APIMatic">
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
    /// CleanupScope.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CleanupScope
    {
        /// <summary>
        /// All.
        /// </summary>
        [EnumMember(Value = "all")]
        All,

        /// <summary>
        /// Customers.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers
    }
}