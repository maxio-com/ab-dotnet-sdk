// <copyright file="SubscriptionPreview.cs" company="APIMatic">
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
    /// SubscriptionPreview.
    /// </summary>
    public class SubscriptionPreview
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreview"/> class.
        /// </summary>
        public SubscriptionPreview()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreview"/> class.
        /// </summary>
        /// <param name="currentBillingManifest">current_billing_manifest.</param>
        /// <param name="nextBillingManifest">next_billing_manifest.</param>
        public SubscriptionPreview(
            Models.BillingManifest currentBillingManifest = null,
            Models.BillingManifest nextBillingManifest = null)
        {
            this.CurrentBillingManifest = currentBillingManifest;
            this.NextBillingManifest = nextBillingManifest;
        }

        /// <summary>
        /// Gets or sets CurrentBillingManifest.
        /// </summary>
        [JsonProperty("current_billing_manifest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingManifest CurrentBillingManifest { get; set; }

        /// <summary>
        /// Gets or sets NextBillingManifest.
        /// </summary>
        [JsonProperty("next_billing_manifest", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BillingManifest NextBillingManifest { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionPreview : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionPreview other &&                ((this.CurrentBillingManifest == null && other.CurrentBillingManifest == null) || (this.CurrentBillingManifest?.Equals(other.CurrentBillingManifest) == true)) &&
                ((this.NextBillingManifest == null && other.NextBillingManifest == null) || (this.NextBillingManifest?.Equals(other.NextBillingManifest) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrentBillingManifest = {(this.CurrentBillingManifest == null ? "null" : this.CurrentBillingManifest.ToString())}");
            toStringOutput.Add($"this.NextBillingManifest = {(this.NextBillingManifest == null ? "null" : this.NextBillingManifest.ToString())}");
        }
    }
}