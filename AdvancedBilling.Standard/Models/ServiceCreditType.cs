// <copyright file="ServiceCreditType.cs" company="APIMatic">
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
    /// ServiceCreditType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceCreditType
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "Credit")]
        Credit,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "Debit")]
        Debit
    }
}