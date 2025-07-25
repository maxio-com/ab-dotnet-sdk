// <copyright file="CustomerChangesPreviewResponse.cs" company="APIMatic">
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
    /// CustomerChangesPreviewResponse.
    /// </summary>
    public class CustomerChangesPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerChangesPreviewResponse"/> class.
        /// </summary>
        public CustomerChangesPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerChangesPreviewResponse"/> class.
        /// </summary>
        /// <param name="changes">changes.</param>
        public CustomerChangesPreviewResponse(
            Models.CustomerChange changes)
        {
            this.Changes = changes;
        }

        /// <summary>
        /// Gets or sets Changes.
        /// </summary>
        [JsonProperty("changes")]
        public Models.CustomerChange Changes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CustomerChangesPreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CustomerChangesPreviewResponse other &&
                (this.Changes == null && other.Changes == null ||
                 this.Changes?.Equals(other.Changes) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Changes = {(this.Changes == null ? "null" : this.Changes.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}