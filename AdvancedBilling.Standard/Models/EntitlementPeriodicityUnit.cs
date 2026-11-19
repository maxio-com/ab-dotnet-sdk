// <copyright file="EntitlementPeriodicityUnit.cs" company="APIMatic">
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
    /// EntitlementPeriodicityUnit.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EntitlementPeriodicityUnit
    {
        /// <summary>
        /// Hour.
        /// </summary>
        [EnumMember(Value = "hour")]
        Hour,

        /// <summary>
        /// Day.
        /// </summary>
        [EnumMember(Value = "day")]
        Day,

        /// <summary>
        /// Week.
        /// </summary>
        [EnumMember(Value = "week")]
        Week,

        /// <summary>
        /// Month.
        /// </summary>
        [EnumMember(Value = "month")]
        Month,

        /// <summary>
        /// Year.
        /// </summary>
        [EnumMember(Value = "year")]
        Year
    }
}