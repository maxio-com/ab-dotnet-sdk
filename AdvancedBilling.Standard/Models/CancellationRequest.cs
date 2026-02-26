// <copyright file="CancellationRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CancellationRequest.
    /// </summary>
    public class CancellationRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationRequest"/> class.
        /// </summary>
        public CancellationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationRequest"/> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        public CancellationRequest(
            Models.CancellationOptions subscription)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or sets Subscription.
        /// </summary>
        [JsonProperty("subscription")]
        public Models.CancellationOptions Subscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CancellationRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CancellationRequest other &&
                (this.Subscription == null && other.Subscription == null ||
                 this.Subscription?.Equals(other.Subscription) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}