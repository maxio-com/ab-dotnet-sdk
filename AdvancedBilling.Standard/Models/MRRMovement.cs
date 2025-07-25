// <copyright file="MRRMovement.cs" company="APIMatic">
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
    /// MRRMovement.
    /// </summary>
    public class MRRMovement : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MRRMovement"/> class.
        /// </summary>
        public MRRMovement()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MRRMovement"/> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="category">category.</param>
        /// <param name="subscriberDelta">subscriber_delta.</param>
        /// <param name="leadDelta">lead_delta.</param>
        public MRRMovement(
            int? amount = null,
            string category = null,
            int? subscriberDelta = null,
            int? leadDelta = null)
        {
            this.Amount = amount;
            this.Category = category;
            this.SubscriberDelta = subscriberDelta;
            this.LeadDelta = leadDelta;
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? Amount { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        [JsonProperty("category", NullValueHandling = NullValueHandling.Ignore)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets SubscriberDelta.
        /// </summary>
        [JsonProperty("subscriber_delta", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriberDelta { get; set; }

        /// <summary>
        /// Gets or sets LeadDelta.
        /// </summary>
        [JsonProperty("lead_delta", NullValueHandling = NullValueHandling.Ignore)]
        public int? LeadDelta { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MRRMovement : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MRRMovement other &&
                (this.Amount == null && other.Amount == null ||
                 this.Amount?.Equals(other.Amount) == true) &&
                (this.Category == null && other.Category == null ||
                 this.Category?.Equals(other.Category) == true) &&
                (this.SubscriberDelta == null && other.SubscriberDelta == null ||
                 this.SubscriberDelta?.Equals(other.SubscriberDelta) == true) &&
                (this.LeadDelta == null && other.LeadDelta == null ||
                 this.LeadDelta?.Equals(other.LeadDelta) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"Category = {this.Category ?? "null"}");
            toStringOutput.Add($"SubscriberDelta = {(this.SubscriberDelta == null ? "null" : this.SubscriberDelta.ToString())}");
            toStringOutput.Add($"LeadDelta = {(this.LeadDelta == null ? "null" : this.LeadDelta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}