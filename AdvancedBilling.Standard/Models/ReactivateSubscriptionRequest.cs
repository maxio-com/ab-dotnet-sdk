// <copyright file="ReactivateSubscriptionRequest.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ReactivateSubscriptionRequest.
    /// </summary>
    public class ReactivateSubscriptionRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionRequest"/> class.
        /// </summary>
        public ReactivateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="calendarBilling">calendar_billing.</param>
        /// <param name="includeTrial">include_trial.</param>
        /// <param name="preserveBalance">preserve_balance.</param>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="useCreditsAndPrepayments">use_credits_and_prepayments.</param>
        /// <param name="resume">resume.</param>
        public ReactivateSubscriptionRequest(
            Models.ReactivationBilling calendarBilling = null,
            bool? includeTrial = null,
            bool? preserveBalance = null,
            string couponCode = null,
            bool? useCreditsAndPrepayments = null,
            ReactivateSubscriptionRequestResume resume = null)
        {
            this.CalendarBilling = calendarBilling;
            this.IncludeTrial = includeTrial;
            this.PreserveBalance = preserveBalance;
            this.CouponCode = couponCode;
            this.UseCreditsAndPrepayments = useCreditsAndPrepayments;
            this.Resume = resume;
        }

        /// <summary>
        /// These values are only applicable to subscriptions using calendar billing
        /// </summary>
        [JsonProperty("calendar_billing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ReactivationBilling CalendarBilling { get; set; }

        /// <summary>
        /// If `true` is sent, the reactivated Subscription will include a trial if one is available. If `false` is sent, the trial period will be ignored.
        /// </summary>
        [JsonProperty("include_trial", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeTrial { get; set; }

        /// <summary>
        /// If `true` is passed, the existing subscription balance will NOT be cleared/reset before adding the additional reactivation charges.
        /// </summary>
        [JsonProperty("preserve_balance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreserveBalance { get; set; }

        /// <summary>
        /// The coupon code to be applied during reactivation.
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// If true is sent, Chargify will use service credits and prepayments upon reactivation. If false is sent, the service credits and prepayments will be ignored.
        /// </summary>
        [JsonProperty("use_credits_and_prepayments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCreditsAndPrepayments { get; set; }

        /// <summary>
        /// If `true`, Chargify will attempt to resume the subscription's billing period. if not resumable, the subscription will be reactivated with a new billing period. If `false`: Chargify will only attempt to reactivate the subscription.
        /// </summary>
        [JsonProperty("resume", NullValueHandling = NullValueHandling.Ignore)]
        public ReactivateSubscriptionRequestResume Resume { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReactivateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ReactivateSubscriptionRequest other &&                ((this.CalendarBilling == null && other.CalendarBilling == null) || (this.CalendarBilling?.Equals(other.CalendarBilling) == true)) &&
                ((this.IncludeTrial == null && other.IncludeTrial == null) || (this.IncludeTrial?.Equals(other.IncludeTrial) == true)) &&
                ((this.PreserveBalance == null && other.PreserveBalance == null) || (this.PreserveBalance?.Equals(other.PreserveBalance) == true)) &&
                ((this.CouponCode == null && other.CouponCode == null) || (this.CouponCode?.Equals(other.CouponCode) == true)) &&
                ((this.UseCreditsAndPrepayments == null && other.UseCreditsAndPrepayments == null) || (this.UseCreditsAndPrepayments?.Equals(other.UseCreditsAndPrepayments) == true)) &&
                ((this.Resume == null && other.Resume == null) || (this.Resume?.Equals(other.Resume) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CalendarBilling = {(this.CalendarBilling == null ? "null" : this.CalendarBilling.ToString())}");
            toStringOutput.Add($"this.IncludeTrial = {(this.IncludeTrial == null ? "null" : this.IncludeTrial.ToString())}");
            toStringOutput.Add($"this.PreserveBalance = {(this.PreserveBalance == null ? "null" : this.PreserveBalance.ToString())}");
            toStringOutput.Add($"this.CouponCode = {(this.CouponCode == null ? "null" : this.CouponCode)}");
            toStringOutput.Add($"this.UseCreditsAndPrepayments = {(this.UseCreditsAndPrepayments == null ? "null" : this.UseCreditsAndPrepayments.ToString())}");
            toStringOutput.Add($"Resume = {(this.Resume == null ? "null" : this.Resume.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}