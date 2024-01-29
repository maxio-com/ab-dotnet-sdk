// <copyright file="SubscriptionGroupSignupSuccessData.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionGroupSignupSuccessData.
    /// </summary>
    public class SubscriptionGroupSignupSuccessData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupSuccessData"/> class.
        /// </summary>
        public SubscriptionGroupSignupSuccessData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupSuccessData"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        /// <param name="subscriptionIds">subscription_ids.</param>
        /// <param name="primarySubscriptionId">primary_subscription_id.</param>
        /// <param name="nextAssessmentAt">next_assessment_at.</param>
        /// <param name="state">state.</param>
        /// <param name="cancelAtEndOfPeriod">cancel_at_end_of_period.</param>
        public SubscriptionGroupSignupSuccessData(
            string uid,
            int scheme,
            int customerId,
            int paymentProfileId,
            List<int> subscriptionIds,
            int primarySubscriptionId,
            string nextAssessmentAt,
            string state,
            bool cancelAtEndOfPeriod)
        {
            this.Uid = uid;
            this.Scheme = scheme;
            this.CustomerId = customerId;
            this.PaymentProfileId = paymentProfileId;
            this.SubscriptionIds = subscriptionIds;
            this.PrimarySubscriptionId = primarySubscriptionId;
            this.NextAssessmentAt = nextAssessmentAt;
            this.State = state;
            this.CancelAtEndOfPeriod = cancelAtEndOfPeriod;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Scheme.
        /// </summary>
        [JsonProperty("scheme")]
        public int Scheme { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileId.
        /// </summary>
        [JsonProperty("payment_profile_id")]
        public int PaymentProfileId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionIds.
        /// </summary>
        [JsonProperty("subscription_ids")]
        public List<int> SubscriptionIds { get; set; }

        /// <summary>
        /// Gets or sets PrimarySubscriptionId.
        /// </summary>
        [JsonProperty("primary_subscription_id")]
        public int PrimarySubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets NextAssessmentAt.
        /// </summary>
        [JsonProperty("next_assessment_at")]
        public string NextAssessmentAt { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets CancelAtEndOfPeriod.
        /// </summary>
        [JsonProperty("cancel_at_end_of_period")]
        public bool CancelAtEndOfPeriod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupSuccessData : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupSuccessData other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                this.Scheme.Equals(other.Scheme) &&
                this.CustomerId.Equals(other.CustomerId) &&
                this.PaymentProfileId.Equals(other.PaymentProfileId) &&
                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true)) &&
                this.PrimarySubscriptionId.Equals(other.PrimarySubscriptionId) &&
                ((this.NextAssessmentAt == null && other.NextAssessmentAt == null) || (this.NextAssessmentAt?.Equals(other.NextAssessmentAt) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                this.CancelAtEndOfPeriod.Equals(other.CancelAtEndOfPeriod);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Scheme = {this.Scheme}");
            toStringOutput.Add($"this.CustomerId = {this.CustomerId}");
            toStringOutput.Add($"this.PaymentProfileId = {this.PaymentProfileId}");
            toStringOutput.Add($"this.SubscriptionIds = {(this.SubscriptionIds == null ? "null" : $"[{string.Join(", ", this.SubscriptionIds)} ]")}");
            toStringOutput.Add($"this.PrimarySubscriptionId = {this.PrimarySubscriptionId}");
            toStringOutput.Add($"this.NextAssessmentAt = {(this.NextAssessmentAt == null ? "null" : this.NextAssessmentAt)}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.CancelAtEndOfPeriod = {this.CancelAtEndOfPeriod}");
        }
    }
}