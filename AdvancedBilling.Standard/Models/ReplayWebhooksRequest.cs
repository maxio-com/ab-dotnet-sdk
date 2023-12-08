// <copyright file="ReplayWebhooksRequest.cs" company="APIMatic">
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
    /// ReplayWebhooksRequest.
    /// </summary>
    public class ReplayWebhooksRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhooksRequest"/> class.
        /// </summary>
        public ReplayWebhooksRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayWebhooksRequest"/> class.
        /// </summary>
        /// <param name="ids">ids.</param>
        public ReplayWebhooksRequest(
            List<int> ids)
        {
            this.Ids = ids;
        }

        /// <summary>
        /// Gets or sets Ids.
        /// </summary>
        [JsonProperty("ids")]
        public List<int> Ids { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ReplayWebhooksRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is ReplayWebhooksRequest other &&                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
        }
    }
}