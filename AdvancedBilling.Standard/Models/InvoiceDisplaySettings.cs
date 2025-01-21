// <copyright file="InvoiceDisplaySettings.cs" company="APIMatic">
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
    /// InvoiceDisplaySettings.
    /// </summary>
    public class InvoiceDisplaySettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDisplaySettings"/> class.
        /// </summary>
        public InvoiceDisplaySettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceDisplaySettings"/> class.
        /// </summary>
        /// <param name="hideZeroSubtotalLines">hide_zero_subtotal_lines.</param>
        /// <param name="includeDiscountsOnLines">include_discounts_on_lines.</param>
        public InvoiceDisplaySettings(
            bool? hideZeroSubtotalLines = null,
            bool? includeDiscountsOnLines = null)
        {
            this.HideZeroSubtotalLines = hideZeroSubtotalLines;
            this.IncludeDiscountsOnLines = includeDiscountsOnLines;
        }

        /// <summary>
        /// Gets or sets HideZeroSubtotalLines.
        /// </summary>
        [JsonProperty("hide_zero_subtotal_lines", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideZeroSubtotalLines { get; set; }

        /// <summary>
        /// Gets or sets IncludeDiscountsOnLines.
        /// </summary>
        [JsonProperty("include_discounts_on_lines", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeDiscountsOnLines { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"InvoiceDisplaySettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is InvoiceDisplaySettings other &&
                (this.HideZeroSubtotalLines == null && other.HideZeroSubtotalLines == null ||
                 this.HideZeroSubtotalLines?.Equals(other.HideZeroSubtotalLines) == true) &&
                (this.IncludeDiscountsOnLines == null && other.IncludeDiscountsOnLines == null ||
                 this.IncludeDiscountsOnLines?.Equals(other.IncludeDiscountsOnLines) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"HideZeroSubtotalLines = {(this.HideZeroSubtotalLines == null ? "null" : this.HideZeroSubtotalLines.ToString())}");
            toStringOutput.Add($"IncludeDiscountsOnLines = {(this.IncludeDiscountsOnLines == null ? "null" : this.IncludeDiscountsOnLines.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}