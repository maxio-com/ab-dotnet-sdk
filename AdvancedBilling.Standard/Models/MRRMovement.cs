// <copyright file="MRRMovement.cs" company="APIMatic">
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is MRRMovement other &&                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.Category == null && other.Category == null) || (this.Category?.Equals(other.Category) == true)) &&
                ((this.SubscriberDelta == null && other.SubscriberDelta == null) || (this.SubscriberDelta?.Equals(other.SubscriberDelta) == true)) &&
                ((this.LeadDelta == null && other.LeadDelta == null) || (this.LeadDelta?.Equals(other.LeadDelta) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.Category = {(this.Category == null ? "null" : this.Category)}");
            toStringOutput.Add($"this.SubscriberDelta = {(this.SubscriberDelta == null ? "null" : this.SubscriberDelta.ToString())}");
            toStringOutput.Add($"this.LeadDelta = {(this.LeadDelta == null ? "null" : this.LeadDelta.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}