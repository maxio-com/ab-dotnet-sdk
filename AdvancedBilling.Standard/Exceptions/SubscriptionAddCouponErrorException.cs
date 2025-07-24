// <copyright file="SubscriptionAddCouponErrorException.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionAddCouponErrorException : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            base.ToString(toStringOutput);
            toStringOutput.Add($"Codes = {(this.Codes == null ? "null" : $"[{string.Join(", ", this.Codes)} ]")}");
            toStringOutput.Add($"CouponCode = {(this.CouponCode == null ? "null" : $"[{string.Join(", ", this.CouponCode)} ]")}");
            toStringOutput.Add($"CouponCodes = {(this.CouponCodes == null ? "null" : $"[{string.Join(", ", this.CouponCodes)} ]")}");
            toStringOutput.Add($"Subscription = {(this.Subscription == null ? "null" : $"[{string.Join(", ", this.Subscription)} ]")}");
        }
    }
}