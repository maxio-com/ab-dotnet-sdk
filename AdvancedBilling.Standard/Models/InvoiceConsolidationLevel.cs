// <copyright file="InvoiceConsolidationLevel.cs" company="APIMatic">
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
    /// InvoiceConsolidationLevel.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceConsolidationLevel
    {
        /// <summary>
        /// None.
        /// </summary>
        [EnumMember(Value = "none")]
        None,

        /// <summary>
        /// Child.
        /// </summary>
        [EnumMember(Value = "child")]
        Child,

        /// <summary>
        /// Parent.
        /// </summary>
        [EnumMember(Value = "parent")]
        Parent
    }
}