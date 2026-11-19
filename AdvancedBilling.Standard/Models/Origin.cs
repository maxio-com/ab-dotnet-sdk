// <copyright file="Origin.cs" company="APIMatic">
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
    /// Origin.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Origin
    {
        /// <summary>
        /// Recurring.
        /// </summary>
        [EnumMember(Value = "recurring")]
        Recurring,

        /// <summary>
        /// Manual.
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual,

        /// <summary>
        /// InitialBalance.
        /// </summary>
        [EnumMember(Value = "initial_balance")]
        InitialBalance,

        /// <summary>
        /// AllowanceIncrease.
        /// </summary>
        [EnumMember(Value = "allowance_increase")]
        AllowanceIncrease,

        /// <summary>
        /// Purchase.
        /// </summary>
        [EnumMember(Value = "purchase")]
        Purchase
    }
}