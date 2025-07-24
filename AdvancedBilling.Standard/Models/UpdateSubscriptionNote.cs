// <copyright file="UpdateSubscriptionNote.cs" company="APIMatic">
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
    /// UpdateSubscriptionNote.
    /// </summary>
    public class UpdateSubscriptionNote : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionNote"/> class.
        /// </summary>
        public UpdateSubscriptionNote()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionNote"/> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="sticky">sticky.</param>
        public UpdateSubscriptionNote(
            string body,
            bool sticky)
        {
            this.Body = body;
            this.Sticky = sticky;
        }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        [JsonProperty("body")]
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets Sticky.
        /// </summary>
        [JsonProperty("sticky")]
        public bool Sticky { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionNote : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionNote other &&
                (this.Body == null && other.Body == null ||
                 this.Body?.Equals(other.Body) == true) &&
                (this.Sticky.Equals(other.Sticky)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Body = {this.Body ?? "null"}");
            toStringOutput.Add($"Sticky = {this.Sticky}");

            base.ToString(toStringOutput);
        }
    }
}