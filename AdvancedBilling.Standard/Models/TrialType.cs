// <copyright file="TrialType.cs" company="APIMatic">
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
    /// TrialType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum TrialType
    {
        /// <summary>
        /// NoObligation.
        /// </summary>
        [EnumMember(Value = "no_obligation")]
        NoObligation,

        /// <summary>
        /// PaymentExpected.
        /// </summary>
        [EnumMember(Value = "payment_expected")]
        PaymentExpected
    }
}