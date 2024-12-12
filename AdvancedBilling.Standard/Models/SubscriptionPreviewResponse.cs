// <copyright file="SubscriptionPreviewResponse.cs" company="APIMatic">
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
    /// SubscriptionPreviewResponse.
    /// </summary>
    public class SubscriptionPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreviewResponse"/> class.
        /// </summary>
        public SubscriptionPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPreviewResponse"/> class.
        /// </summary>
        /// <param name="subscriptionPreview">subscription_preview.</param>
        public SubscriptionPreviewResponse(
            Models.SubscriptionPreview subscriptionPreview)
        {
            this.SubscriptionPreview = subscriptionPreview;
        }

        /// <summary>
        /// Gets or sets SubscriptionPreview.
        /// </summary>
        [JsonProperty("subscription_preview")]
        public Models.SubscriptionPreview SubscriptionPreview { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionPreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionPreviewResponse other &&
                (this.SubscriptionPreview == null && other.SubscriptionPreview == null ||
                 this.SubscriptionPreview?.Equals(other.SubscriptionPreview) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SubscriptionPreview = {(this.SubscriptionPreview == null ? "null" : this.SubscriptionPreview.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}