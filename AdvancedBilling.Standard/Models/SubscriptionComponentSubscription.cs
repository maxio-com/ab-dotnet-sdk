// <copyright file="SubscriptionComponentSubscription.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionComponentSubscription.
    /// </summary>
    public class SubscriptionComponentSubscription : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentSubscription"/> class.
        /// </summary>
        public SubscriptionComponentSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentSubscription"/> class.
        /// </summary>
        /// <param name="state">state.</param>
        /// <param name="updatedAt">updated_at.</param>
        public SubscriptionComponentSubscription(
            Models.SubscriptionState? state = null,
            DateTimeOffset? updatedAt = null)
        {
            this.State = state;
            this.UpdatedAt = updatedAt;
        }

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
        ///     * `unpaid` - Indicates an unpaid subscription. A subscription is marked unpaid if the retry period expires and you have configured your [Dunning](https://maxio.zendesk.com/hc/en-us/articles/24287076583565-Dunning-Overview) settings to have a Final Action of `mark the subscription unpaid`.
        /// * **End of Life States**
        ///     * `canceled` - Indicates a canceled subscription. This may happen at your request (via the API or the web interface) or due to the expiration of the [Dunning](https://maxio.zendesk.com/hc/en-us/articles/24287076583565-Dunning-Overview) process without payment. See the [Reactivation](https://maxio.zendesk.com/hc/en-us/articles/24252109503629-Reactivating-and-Resuming) documentation for info on how to restart a canceled subscription.
        ///     While a subscription is canceled, its period will not advance, it will not accrue any new charges, and Advanced Billing will not attempt to collect the overdue balance.
        ///     * `expired` - Indicates a subscription that has expired due to running its normal life cycle. Some products may be configured to have an expiration period. An expired subscription then is one that stayed active until it fulfilled its full period.
        ///     * `failed_to_create` - Indicates that signup has failed. (You may see this state in a signup_failure webhook.)
        ///     * `on_hold` - Indicates that a subscription’s billing has been temporarily stopped. While it is expected that the subscription will resume and return to active status, this is still treated as an “End of Life” state because the customer is not paying for services during this time.
        ///     * `suspended` - Indicates that a prepaid subscription has used up all their prepayment balance. If a prepayment is applied, it will return to an active state.
        ///     * `trial_ended` - A subscription in a trial_ended state is a subscription that completed a no-obligation trial and did not have a card on file at the expiration of the trial period. See [Product Pricing – No Obligation Trials](https://maxio.zendesk.com/hc/en-us/articles/24261076617869-Product-Editing) for more details.
        /// See [Subscription States](https://maxio.zendesk.com/hc/en-us/articles/24252119027853-Subscription-States) for more info about subscription states and state transitions.
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionState? State { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionComponentSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionComponentSubscription other &&
                (this.State == null && other.State == null ||
                 this.State?.Equals(other.State) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"State = {(this.State == null ? "null" : this.State.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}