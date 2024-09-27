// <copyright file="SubscriptionGroupSignupError.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionGroupSignupError.
    /// </summary>
    public class SubscriptionGroupSignupError : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupError"/> class.
        /// </summary>
        public SubscriptionGroupSignupError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSignupError"/> class.
        /// </summary>
        /// <param name="subscriptions">subscriptions.</param>
        /// <param name="payerReference">payer_reference.</param>
        /// <param name="payer">payer.</param>
        /// <param name="subscriptionGroup">subscription_group.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        /// <param name="payerId">payer_id.</param>
        public SubscriptionGroupSignupError(
            Dictionary<string, Models.SubscriptionGroupSubscriptionError> subscriptions = null,
            string payerReference = null,
            Models.PayerError payer = null,
            List<string> subscriptionGroup = null,
            string paymentProfileId = null,
            string payerId = null)
        {
            this.Subscriptions = subscriptions;
            this.PayerReference = payerReference;
            this.Payer = payer;
            this.SubscriptionGroup = subscriptionGroup;
            this.PaymentProfileId = paymentProfileId;
            this.PayerId = payerId;
        }

        /// <summary>
        /// Object that as key have subscription position in request subscriptions array and as value subscription errors object.
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.SubscriptionGroupSubscriptionError> Subscriptions { get; set; }

        /// <summary>
        /// Gets or sets PayerReference.
        /// </summary>
        [JsonProperty("payer_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerReference { get; set; }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayerError Payer { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionGroup.
        /// </summary>
        [JsonProperty("subscription_group", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SubscriptionGroup { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileId.
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentProfileId { get; set; }

        /// <summary>
        /// Gets or sets PayerId.
        /// </summary>
        [JsonProperty("payer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PayerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSignupError : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSignupError other &&                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true)) &&
                ((this.PayerReference == null && other.PayerReference == null) || (this.PayerReference?.Equals(other.PayerReference) == true)) &&
                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.SubscriptionGroup == null && other.SubscriptionGroup == null) || (this.SubscriptionGroup?.Equals(other.SubscriptionGroup) == true)) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true)) &&
                ((this.PayerId == null && other.PayerId == null) || (this.PayerId?.Equals(other.PayerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Subscriptions = {(this.Subscriptions == null ? "null" : this.Subscriptions.ToString())}");
            toStringOutput.Add($"this.PayerReference = {(this.PayerReference == null ? "null" : this.PayerReference)}");
            toStringOutput.Add($"this.Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"this.SubscriptionGroup = {(this.SubscriptionGroup == null ? "null" : $"[{string.Join(", ", this.SubscriptionGroup)} ]")}");
            toStringOutput.Add($"this.PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId)}");
            toStringOutput.Add($"this.PayerId = {(this.PayerId == null ? "null" : this.PayerId)}");

            base.ToString(toStringOutput);
        }
    }
}