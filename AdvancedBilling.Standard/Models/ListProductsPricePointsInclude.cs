// <copyright file="ListProductsPricePointsInclude.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListProductsPricePointsInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ListProductsPricePointsInclude
    {
        /// <summary>
        /// CurrencyPrices.
        /// </summary>
        [EnumMember(Value = "currency_prices")]
        CurrencyPrices
    }
}