// <copyright file="AddressChange.cs" company="APIMatic">
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
    /// AddressChange.
    /// </summary>
    public class AddressChange : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressChange"/> class.
        /// </summary>
        public AddressChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressChange"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public AddressChange(
            Models.InvoiceAddress before,
            Models.InvoiceAddress after)
        {
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Gets or sets Before.
        /// </summary>
        [JsonProperty("before")]
        public Models.InvoiceAddress Before { get; set; }

        /// <summary>
        /// Gets or sets After.
        /// </summary>
        [JsonProperty("after")]
        public Models.InvoiceAddress After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AddressChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AddressChange other &&
                (this.Before == null && other.Before == null ||
                 this.Before?.Equals(other.Before) == true) &&
                (this.After == null && other.After == null ||
                 this.After?.Equals(other.After) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Before = {(this.Before == null ? "null" : this.Before.ToString())}");
            toStringOutput.Add($"After = {(this.After == null ? "null" : this.After.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}