// <copyright file="BankAccountHolderType.cs" company="APIMatic">
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
    /// BankAccountHolderType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum BankAccountHolderType
    {
        /// <summary>
        /// Personal.
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal,

        /// <summary>
        /// Business.
        /// </summary>
        [EnumMember(Value = "business")]
        Business
    }
}