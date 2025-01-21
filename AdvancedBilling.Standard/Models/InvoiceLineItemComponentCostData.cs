// <copyright file="InvoiceLineItemComponentCostData.cs" company="APIMatic">
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
    /// InvoiceLineItemComponentCostData.
    /// </summary>
    public class InvoiceLineItemComponentCostData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemComponentCostData"/> class.
        /// </summary>
        public InvoiceLineItemComponentCostData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemComponentCostData"/> class.
        /// </summary>
        /// <param name="rates">rates.</param>
        public InvoiceLineItemComponentCostData(
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
            return $"InvoiceLineItemComponentCostData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceLineItemComponentCostData other &&
                (this.Rates == null && other.Rates == null ||
                 this.Rates?.Equals(other.Rates) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Rates = {(this.Rates == null ? "null" : $"[{string.Join(", ", this.Rates)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}