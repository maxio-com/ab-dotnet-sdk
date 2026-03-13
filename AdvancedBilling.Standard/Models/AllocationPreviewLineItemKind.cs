// <copyright file="AllocationPreviewLineItemKind.cs" company="APIMatic">
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
    /// AllocationPreviewLineItemKind.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllocationPreviewLineItemKind
    {
        /// <summary>
        /// QuantityBasedComponent.
        /// </summary>
        [EnumMember(Value = "quantity_based_component")]
        QuantityBasedComponent,

        /// <summary>
        /// OnOffComponent.
        /// </summary>
        [EnumMember(Value = "on_off_component")]
        OnOffComponent,

        /// <summary>
        /// Coupon.
        /// </summary>
        [EnumMember(Value = "coupon")]
        Coupon,

        /// <summary>
        /// Tax.
        /// </summary>
        [EnumMember(Value = "tax")]
        Tax
    }
}