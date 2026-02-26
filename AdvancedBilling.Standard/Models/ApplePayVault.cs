// <copyright file="ApplePayVault.cs" company="APIMatic">
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
    /// ApplePayVault.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ApplePayVault
    {
        /// <summary>
        /// BraintreeBlue.
        /// </summary>
        [EnumMember(Value = "braintree_blue")]
        BraintreeBlue
    }
}