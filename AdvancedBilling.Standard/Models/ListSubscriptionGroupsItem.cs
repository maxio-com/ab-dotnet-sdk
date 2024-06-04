// <copyright file="ListSubscriptionGroupsItem.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ListSubscriptionGroupsItem.
    /// </summary>
    public class ListSubscriptionGroupsItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsItem"/> class.
        /// </summary>
        public ListSubscriptionGroupsItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsItem"/> class.
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
        /// <param name="accountBalances">account_balances.</param>
        /// <param name="groupType">group_type.</param>
        public ListSubscriptionGroupsItem(
            string uid = null,
            int? scheme = null,
            int? customerId = null,
            int? paymentProfileId = null,
            List<int> subscriptionIds = null,
            int? primarySubscriptionId = null,
            DateTimeOffset? nextAssessmentAt = null,
            string state = null,
            bool? cancelAtEndOfPeriod = null,
            Models.SubscriptionGroupBalances accountBalances = null,
            Models.GroupType? groupType = null)
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
            this.AccountBalances = accountBalances;
            this.GroupType = groupType;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Scheme.
        /// </summary>
        [JsonProperty("scheme", NullValueHandling = NullValueHandling.Ignore)]
        public int? Scheme { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileId.
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentProfileId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionIds.
        /// </summary>
        [JsonProperty("subscription_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> SubscriptionIds { get; set; }

        /// <summary>
        /// Gets or sets PrimarySubscriptionId.
        /// </summary>
        [JsonProperty("primary_subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrimarySubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets NextAssessmentAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_assessment_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextAssessmentAt { get; set; }

        /// <summary>
        /// Gets or sets State.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets CancelAtEndOfPeriod.
        /// </summary>
        [JsonProperty("cancel_at_end_of_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CancelAtEndOfPeriod { get; set; }

        /// <summary>
        /// Gets or sets AccountBalances.
        /// </summary>
        [JsonProperty("account_balances", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionGroupBalances AccountBalances { get; set; }

        /// <summary>
        /// Gets or sets GroupType.
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupType? GroupType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSubscriptionGroupsItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSubscriptionGroupsItem other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true)) &&
                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true)) &&
                ((this.PrimarySubscriptionId == null && other.PrimarySubscriptionId == null) || (this.PrimarySubscriptionId?.Equals(other.PrimarySubscriptionId) == true)) &&
                ((this.NextAssessmentAt == null && other.NextAssessmentAt == null) || (this.NextAssessmentAt?.Equals(other.NextAssessmentAt) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.CancelAtEndOfPeriod == null && other.CancelAtEndOfPeriod == null) || (this.CancelAtEndOfPeriod?.Equals(other.CancelAtEndOfPeriod) == true)) &&
                ((this.AccountBalances == null && other.AccountBalances == null) || (this.AccountBalances?.Equals(other.AccountBalances) == true)) &&
                ((this.GroupType == null && other.GroupType == null) || (this.GroupType?.Equals(other.GroupType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Scheme = {(this.Scheme == null ? "null" : this.Scheme.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId.ToString())}");
            toStringOutput.Add($"this.SubscriptionIds = {(this.SubscriptionIds == null ? "null" : $"[{string.Join(", ", this.SubscriptionIds)} ]")}");
            toStringOutput.Add($"this.PrimarySubscriptionId = {(this.PrimarySubscriptionId == null ? "null" : this.PrimarySubscriptionId.ToString())}");
            toStringOutput.Add($"this.NextAssessmentAt = {(this.NextAssessmentAt == null ? "null" : this.NextAssessmentAt.ToString())}");
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State)}");
            toStringOutput.Add($"this.CancelAtEndOfPeriod = {(this.CancelAtEndOfPeriod == null ? "null" : this.CancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"this.AccountBalances = {(this.AccountBalances == null ? "null" : this.AccountBalances.ToString())}");
            toStringOutput.Add($"this.GroupType = {(this.GroupType == null ? "null" : this.GroupType.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}