// <copyright file="CollectionMethod.cs" company="APIMatic">
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
    /// CollectionMethod.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CollectionMethod
    {
        /// <summary>
        /// Automatic.
        /// </summary>
        [EnumMember(Value = "automatic")]
        Automatic,

        /// <summary>
        /// Remittance.
        /// </summary>
        [EnumMember(Value = "remittance")]
        Remittance,

        /// <summary>
        /// Prepaid.
        /// </summary>
        [EnumMember(Value = "prepaid")]
        Prepaid,

        /// <summary>
        /// Invoice.
        /// </summary>
        [EnumMember(Value = "invoice")]
        Invoice
    }
}