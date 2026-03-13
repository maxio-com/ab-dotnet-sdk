// <copyright file="EventResponse.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// EventResponse.
    /// </summary>
    public class EventResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse"/> class.
        /// </summary>
        public EventResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse"/> class.
        /// </summary>
        /// <param name="mEvent">event.</param>
        public EventResponse(
            Models.Event mEvent)
        {
            this.MEvent = mEvent;
        }

        /// <summary>
        /// Gets or sets MEvent.
        /// </summary>
        [JsonProperty("event")]
        public Models.Event MEvent { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"EventResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is EventResponse other &&
                (this.MEvent == null && other.MEvent == null ||
                 this.MEvent?.Equals(other.MEvent) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"MEvent = {(this.MEvent == null ? "null" : this.MEvent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}