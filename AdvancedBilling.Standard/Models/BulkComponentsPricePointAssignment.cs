// <copyright file="BulkComponentsPricePointAssignment.cs" company="APIMatic">
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
    /// BulkComponentsPricePointAssignment.
    /// </summary>
    public class BulkComponentsPricePointAssignment : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkComponentsPricePointAssignment"/> class.
        /// </summary>
        public BulkComponentsPricePointAssignment()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkComponentsPricePointAssignment"/> class.
        /// </summary>
        /// <param name="components">components.</param>
        public BulkComponentsPricePointAssignment(
            List<Models.ComponentPricePointAssignment> components = null)
        {
            this.Components = components;
        }

        /// <summary>
        /// Gets or sets Components.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePointAssignment> Components { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BulkComponentsPricePointAssignment : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BulkComponentsPricePointAssignment other &&
                (this.Components == null && other.Components == null ||
                 this.Components?.Equals(other.Components) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}