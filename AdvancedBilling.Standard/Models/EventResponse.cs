// <copyright file="EventResponse.cs" company="APIMatic">
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
            toStringOutput.Add($"this.MEvent = {(this.MEvent == null ? "null" : this.MEvent.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}