// <copyright file="UpdateSubscriptionNote.cs" company="APIMatic">
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
    /// UpdateSubscriptionNote.
    /// </summary>
    public class UpdateSubscriptionNote
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is UpdateSubscriptionNote other &&                ((this.Body == null && other.Body == null) || (this.Body?.Equals(other.Body) == true)) &&
                this.Sticky.Equals(other.Sticky);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Body = {(this.Body == null ? "null" : this.Body)}");
            toStringOutput.Add($"this.Sticky = {this.Sticky}");
        }
    }
}