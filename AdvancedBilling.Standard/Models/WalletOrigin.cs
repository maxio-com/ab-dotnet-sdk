// <copyright file="WalletOrigin.cs" company="APIMatic">
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
    /// WalletOrigin.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WalletOrigin
    {
        /// <summary>
        /// Manual.
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// Feature.
        /// </summary>
        [EnumMember(Value = "feature")]
        Feature
    }
}