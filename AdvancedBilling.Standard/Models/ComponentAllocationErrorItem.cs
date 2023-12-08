// <copyright file="ComponentAllocationErrorItem.cs" company="APIMatic">
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
    /// ComponentAllocationErrorItem.
    /// </summary>
    public class ComponentAllocationErrorItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAllocationErrorItem"/> class.
        /// </summary>
        public ComponentAllocationErrorItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentAllocationErrorItem"/> class.
        /// </summary>
        /// <param name="componentId">component_id.</param>
        /// <param name="message">message.</param>
        /// <param name="kind">kind.</param>
        /// <param name="on">on.</param>
        public ComponentAllocationErrorItem(
            int? componentId = null,
            string message = null,
            string kind = null,
            string on = null)
        {
            this.ComponentId = componentId;
            this.Message = message;
            this.Kind = kind;
            this.On = on;
        }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets On.
        /// </summary>
        [JsonProperty("on", NullValueHandling = NullValueHandling.Ignore)]
        public string On { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentAllocationErrorItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComponentAllocationErrorItem other &&                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.On == null && other.On == null) || (this.On?.Equals(other.On) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind)}");
            toStringOutput.Add($"this.On = {(this.On == null ? "null" : this.On)}");
        }
    }
}