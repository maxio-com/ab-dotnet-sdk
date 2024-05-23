// <copyright file="ComponentCostData1.cs" company="APIMatic">
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
    /// ComponentCostData1.
    /// </summary>
    public class ComponentCostData1 : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostData1"/> class.
        /// </summary>
        public ComponentCostData1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComponentCostData1"/> class.
        /// </summary>
        /// <param name="rates">rates.</param>
        public ComponentCostData1(
            List<Models.ComponentCostData> rates = null)
        {
            this.Rates = rates;
        }

        /// <summary>
        /// Gets or sets Rates.
        /// </summary>
        [JsonProperty("rates", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentCostData> Rates { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ComponentCostData1 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ComponentCostData1 other &&                ((this.Rates == null && other.Rates == null) || (this.Rates?.Equals(other.Rates) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Rates = {(this.Rates == null ? "null" : $"[{string.Join(", ", this.Rates)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}