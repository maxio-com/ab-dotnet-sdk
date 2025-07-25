// <copyright file="SaleRepItemMrr.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// SaleRepItemMrr.
    /// </summary>
    public class SaleRepItemMrr : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepItemMrr"/> class.
        /// </summary>
        public SaleRepItemMrr()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepItemMrr"/> class.
        /// </summary>
        /// <param name="mrr">mrr.</param>
        /// <param name="usage">usage.</param>
        /// <param name="recurring">recurring.</param>
        public SaleRepItemMrr(
            string mrr = null,
            string usage = null,
            string recurring = null)
        {
            this.Mrr = mrr;
            this.Usage = usage;
            this.Recurring = recurring;
        }

        /// <summary>
        /// Gets or sets Mrr.
        /// </summary>
        [JsonProperty("mrr", NullValueHandling = NullValueHandling.Ignore)]
        public string Mrr { get; set; }

        /// <summary>
        /// Gets or sets Usage.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public string Recurring { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SaleRepItemMrr : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SaleRepItemMrr other &&
                (this.Mrr == null && other.Mrr == null ||
                 this.Mrr?.Equals(other.Mrr) == true) &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true) &&
                (this.Recurring == null && other.Recurring == null ||
                 this.Recurring?.Equals(other.Recurring) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Mrr = {this.Mrr ?? "null"}");
            toStringOutput.Add($"Usage = {this.Usage ?? "null"}");
            toStringOutput.Add($"Recurring = {this.Recurring ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}