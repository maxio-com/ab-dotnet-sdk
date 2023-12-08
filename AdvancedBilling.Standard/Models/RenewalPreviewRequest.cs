// <copyright file="RenewalPreviewRequest.cs" company="APIMatic">
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
    /// RenewalPreviewRequest.
    /// </summary>
    public class RenewalPreviewRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewRequest"/> class.
        /// </summary>
        public RenewalPreviewRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RenewalPreviewRequest"/> class.
        /// </summary>
        /// <param name="components">components.</param>
        public RenewalPreviewRequest(
            List<Models.RenewalPreviewComponent> components = null)
        {
            this.Components = components;
        }

        /// <summary>
        /// An optional array of component definitions to preview. Providing any component definitions here will override the actual components on the subscription (and their quantities), and the billing preview will contain only these components (in addition to any product base fees).
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.RenewalPreviewComponent> Components { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"RenewalPreviewRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is RenewalPreviewRequest other &&                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
        }
    }
}