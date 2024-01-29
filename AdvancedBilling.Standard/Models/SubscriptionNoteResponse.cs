// <copyright file="SubscriptionNoteResponse.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionNoteResponse.
    /// </summary>
    public class SubscriptionNoteResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNoteResponse"/> class.
        /// </summary>
        public SubscriptionNoteResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionNoteResponse"/> class.
        /// </summary>
        /// <param name="note">note.</param>
        public SubscriptionNoteResponse(
            Models.SubscriptionNote note)
        {
            this.Note = note;
        }

        /// <summary>
        /// Gets or sets Note.
        /// </summary>
        [JsonProperty("note")]
        public Models.SubscriptionNote Note { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionNoteResponse : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionNoteResponse other &&                ((this.Note == null && other.Note == null) || (this.Note?.Equals(other.Note) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Note = {(this.Note == null ? "null" : this.Note.ToString())}");
        }
    }
}