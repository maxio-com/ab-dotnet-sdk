// <copyright file="AllocationPreviewLineItemKind.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

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