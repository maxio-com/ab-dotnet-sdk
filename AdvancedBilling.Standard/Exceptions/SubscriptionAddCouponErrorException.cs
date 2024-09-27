// <copyright file="SubscriptionAddCouponErrorException.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Http.Client;
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Exceptions
{
    /// <summary>
    /// SubscriptionAddCouponErrorException.
    /// </summary>
    public class SubscriptionAddCouponErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionAddCouponErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public SubscriptionAddCouponErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Codes.
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Gets or sets CouponCode.
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponCode { get; set; }

        /// <summary>
        /// Gets or sets CouponCodes.
        /// </summary>
        [JsonProperty("coupon_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subscription { get; set; }
    }
}