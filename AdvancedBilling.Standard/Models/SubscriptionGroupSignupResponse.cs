// <copyright file="SubscriptionGroupSignupResponse.cs" company="APIMatic">
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
    /// SubscriptionGroupSignupResponse.
    /// </summary>
    public class SubscriptionGroupSignupResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupResponse"/> class.
        /// </summary>
        public SubscriptionGroupSignupResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupResponse"/> class.
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
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        public SubscriptionGroupSignupResponse(
            string uid = null,
            int? scheme = null,
            int? customerId = null,
            int? paymentProfileId = null,
            List<int> subscriptionIds = null,
            int? primarySubscriptionId = null,
            DateTimeOffset? nextAssessmentAt = null,
            Models.SubscriptionState? state = null,
            bool? cancelAtEndOfPeriod = null,
            List<Models.SubscriptionGroupItem> subscriptions = null,
            Models.CollectionMethod? paymentCollectionMethod = Models.CollectionMethod.Automatic)
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
            this.Subscriptions = subscriptions;
            this.PaymentCollectionMethod = paymentCollectionMethod;
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
        /// The state of a subscription.
        /// * **Live States**
        ///     * `active` - A normal, active subscription. It is not in a trial and is paid and up to date.
        ///     * `assessing` - An internal (transient) state that indicates a subscription is in the middle of periodic assessment. Do not base any access decisions in your app on this state, as it may not always be exposed.
        ///     * `pending` - An internal (transient) state that indicates a subscription is in the creation process. Do not base any access decisions in your app on this state, as it may not always be exposed.
        ///     * `trialing` - A subscription in trialing state has a valid trial subscription. This type of subscription may transition to active once payment is received when the trial has ended. Otherwise, it may go to a Problem or End of Life state.
        ///     * `paused` - An internal state that indicates that your account with Advanced Billing is in arrears.
        /// * **Problem States**
        ///     * `past_due` - Indicates that the most recent payment has failed, and payment is past due for this subscription. If you have enabled our automated dunning, this subscription will be in the dunning process (additional status and callbacks from the dunning process will be available in the future). If you are handling dunning and payment updates yourself, you will want to use this state to initiate a payment update from your customers.
        ///     * `soft_failure` - Indicates that normal assessment/processing of the subscription has failed for a reason that cannot be fixed by the Customer. For example, a Soft Fail may result from a timeout at the gateway or incorrect credentials on your part. The subscriptions should be retried automatically. An interface is being built for you to review problems resulting from these events to take manual action when needed.
        ///     * `unpaid` - Indicates an unpaid subscription. A subscription is marked unpaid if the retry period expires and you have configured your [Dunning](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405505141005) settings to have a Final Action of `mark the subscription unpaid`.
        /// * **End of Life States**
        ///     * `canceled` - Indicates a canceled subscription. This may happen at your request (via the API or the web interface) or due to the expiration of the [Dunning](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405505141005) process without payment. See the [Reactivation](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404559291021) documentation for info on how to restart a canceled subscription.
        ///     While a subscription is canceled, its period will not advance, it will not accrue any new charges, and Advanced Billing will not attempt to collect the overdue balance.
        ///     * `expired` - Indicates a subscription that has expired due to running its normal life cycle. Some products may be configured to have an expiration period. An expired subscription then is one that stayed active until it fulfilled its full period.
        ///     * `failed_to_create` - Indicates that signup has failed. (You may see this state in a signup_failure webhook.)
        ///     * `on_hold` - Indicates that a subscription’s billing has been temporarily stopped. While it is expected that the subscription will resume and return to active status, this is still treated as an “End of Life” state because the customer is not paying for services during this time.
        ///     * `suspended` - Indicates that a prepaid subscription has used up all their prepayment balance. If a prepayment is applied, it will return to an active state.
        ///     * `trial_ended` - A subscription in a trial_ended state is a subscription that completed a no-obligation trial and did not have a card on file at the expiration of the trial period. See [Product Pricing – No Obligation Trials](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405246782221) for more details.
        /// See [Subscription States](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404222005773) for more info about subscription states and state transitions.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionState? State { get; set; }

        /// <summary>
        /// Gets or sets CancelAtEndOfPeriod.
        /// </summary>
        [JsonProperty("cancel_at_end_of_period", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CancelAtEndOfPeriod { get; set; }

        /// <summary>
        /// Gets or sets Subscriptions.
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionGroupItem> Subscriptions { get; set; }

        /// <summary>
        /// The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`.
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CollectionMethod? PaymentCollectionMethod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupResponse other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Scheme == null && other.Scheme == null) || (this.Scheme?.Equals(other.Scheme) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true)) &&
                ((this.SubscriptionIds == null && other.SubscriptionIds == null) || (this.SubscriptionIds?.Equals(other.SubscriptionIds) == true)) &&
                ((this.PrimarySubscriptionId == null && other.PrimarySubscriptionId == null) || (this.PrimarySubscriptionId?.Equals(other.PrimarySubscriptionId) == true)) &&
                ((this.NextAssessmentAt == null && other.NextAssessmentAt == null) || (this.NextAssessmentAt?.Equals(other.NextAssessmentAt) == true)) &&
                ((this.State == null && other.State == null) || (this.State?.Equals(other.State) == true)) &&
                ((this.CancelAtEndOfPeriod == null && other.CancelAtEndOfPeriod == null) || (this.CancelAtEndOfPeriod?.Equals(other.CancelAtEndOfPeriod) == true)) &&
                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true));
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
            toStringOutput.Add($"this.State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"this.CancelAtEndOfPeriod = {(this.CancelAtEndOfPeriod == null ? "null" : this.CancelAtEndOfPeriod.ToString())}");
            toStringOutput.Add($"this.Subscriptions = {(this.Subscriptions == null ? "null" : $"[{string.Join(", ", this.Subscriptions)} ]")}");
            toStringOutput.Add($"this.PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}