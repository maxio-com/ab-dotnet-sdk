// <copyright file="UpdateSubscriptionNoteRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

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