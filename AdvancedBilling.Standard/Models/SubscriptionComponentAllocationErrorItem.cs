// <copyright file="SubscriptionComponentAllocationErrorItem.cs" company="APIMatic">
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
    /// SubscriptionComponentAllocationErrorItem.
    /// </summary>
    public class SubscriptionComponentAllocationErrorItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentAllocationErrorItem"/> class.
        /// </summary>
        public SubscriptionComponentAllocationErrorItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionComponentAllocationErrorItem"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="message">message.</param>
        public SubscriptionComponentAllocationErrorItem(
            string kind = null,
            string message = null)
        {
            this.Kind = kind;
            this.Message = message;
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionComponentAllocationErrorItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionComponentAllocationErrorItem other &&
                (this.Kind == null && other.Kind == null ||
                 this.Kind?.Equals(other.Kind) == true) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Kind = {this.Kind ?? "null"}");
            toStringOutput.Add($"Message = {this.Message ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}