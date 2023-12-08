// <copyright file="ListProductsInclude.cs" company="APIMatic">
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
    /// ListProductsInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListProductsInclude
    {
        /// <summary>
        /// PrepaidProductPricePoint.
        /// </summary>
        [EnumMember(Value = "prepaid_product_price_point")]
        PrepaidProductPricePoint
    }
}