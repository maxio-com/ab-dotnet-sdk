// <copyright file="ReplayWebhooksResponse.cs" company="APIMatic">
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
    /// ReplayWebhooksResponse.
    /// </summary>
    public class ReplayWebhooksResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhooksResponse"/> class.
        /// </summary>
        public ReplayWebhooksResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhooksResponse"/> class.
        /// </summary>
        /// <param name="status">status.</param>
        public ReplayWebhooksResponse(
            string status = null)
        {
            this.Status = status;
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReplayWebhooksResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReplayWebhooksResponse other &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Status = {this.Status ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}