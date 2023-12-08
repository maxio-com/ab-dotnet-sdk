// <copyright file="BulkComponentSPricePointAssignment.cs" company="APIMatic">
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
    /// BulkComponentSPricePointAssignment.
    /// </summary>
    public class BulkComponentSPricePointAssignment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkComponentSPricePointAssignment"/> class.
        /// </summary>
        public BulkComponentSPricePointAssignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkComponentSPricePointAssignment"/> class.
        /// </summary>
        /// <param name="components">components.</param>
        public BulkComponentSPricePointAssignment(
            List<Models.ComponentSPricePointAssignment> components = null)
        {
            this.Components = components;
        }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentSPricePointAssignment> Components { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BulkComponentSPricePointAssignment : ({string.Join(", ", toStringOutput)})";
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
            return obj is BulkComponentSPricePointAssignment other &&                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true));
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