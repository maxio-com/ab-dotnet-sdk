// <copyright file="ProformaInvoiceDiscountSourceType.cs" company="APIMatic">
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
    /// ProformaInvoiceDiscountSourceType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProformaInvoiceDiscountSourceType
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
        Referral
    }
}