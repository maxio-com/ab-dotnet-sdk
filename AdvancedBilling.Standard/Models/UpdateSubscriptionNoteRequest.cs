// <copyright file="UpdateSubscriptionNoteRequest.cs" company="APIMatic">
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
    /// UpdateSubscriptionNoteRequest.
    /// </summary>
    public class UpdateSubscriptionNoteRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionNoteRequest"/> class.
        /// </summary>
        public UpdateSubscriptionNoteRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSubscriptionNoteRequest"/> class.
        /// </summary>
        /// <param name="note">note.</param>
        public UpdateSubscriptionNoteRequest(
            Models.UpdateSubscriptionNote note)
        {
            this.Note = note;
        }

        /// <summary>
        /// Updatable fields for Subscription Note
        /// </summary>
        [JsonProperty("note")]
        public Models.UpdateSubscriptionNote Note { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateSubscriptionNoteRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateSubscriptionNoteRequest other &&
                (this.Note == null && other.Note == null ||
                 this.Note?.Equals(other.Note) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Note = {(this.Note == null ? "null" : this.Note.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}