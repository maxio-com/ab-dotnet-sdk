// <copyright file="InvoiceDiscountSourceType.cs" company="APIMatic">
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
    /// InvoiceDiscountSourceType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceDiscountSourceType
    {
        /// <summary>
        /// Coupon.
        /// </summary>
        [EnumMember(Value = "Coupon")]
        Coupon,

        /// <summary>
        /// Referral.
        /// </summary>
        [EnumMember(Value = "Referral")]
        Referral,

        /// <summary>
        /// EnumAdHocCoupon.
        /// </summary>
        [EnumMember(Value = "Ad Hoc Coupon")]
        EnumAdHocCoupon
    }
}