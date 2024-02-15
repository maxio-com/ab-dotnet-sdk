// <copyright file="PendingCancellationChange.cs" company="APIMatic">
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
    /// PendingCancellationChange.
    /// </summary>
    public class PendingCancellationChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationChange"/> class.
        /// </summary>
        public PendingCancellationChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PendingCancellationChange"/> class.
        /// </summary>
        /// <param name="cancellationState">cancellation_state.</param>
        /// <param name="cancelsAt">cancels_at.</param>
        public PendingCancellationChange(
            string cancellationState,
            DateTimeOffset cancelsAt)
        {
            this.CancellationState = cancellationState;
            this.CancelsAt = cancelsAt;
        }

        /// <summary>
        /// Gets or sets CancellationState.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("cancellation_state")]
        [JsonRequired]
        public string CancellationState { get; set; }

        /// <summary>
        /// Gets or sets CancelsAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("cancels_at")]
        [JsonRequired]
        public DateTimeOffset CancelsAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PendingCancellationChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is PendingCancellationChange other &&                ((this.CancellationState == null && other.CancellationState == null) || (this.CancellationState?.Equals(other.CancellationState) == true)) &&
                this.CancelsAt.Equals(other.CancelsAt);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CancellationState = {(this.CancellationState == null ? "null" : this.CancellationState)}");
            toStringOutput.Add($"this.CancelsAt = {this.CancelsAt}");
        }
    }
}