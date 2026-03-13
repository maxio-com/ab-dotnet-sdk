// <copyright file="AllocationPreviewDirection.cs" company="APIMatic">
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
    /// AllocationPreviewDirection.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllocationPreviewDirection
    {
        /// <summary>
        /// Upgrade.
        /// </summary>
        [EnumMember(Value = "upgrade")]
        Upgrade,

        /// <summary>
        /// Downgrade.
        /// </summary>
        [EnumMember(Value = "downgrade")]
        Downgrade
    }
}