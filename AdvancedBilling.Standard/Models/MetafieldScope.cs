// <copyright file="MetafieldScope.cs" company="APIMatic">
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
    /// MetafieldScope.
    /// </summary>
    public class MetafieldScope : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetafieldScope"/> class.
        /// </summary>
        public MetafieldScope()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetafieldScope"/> class.
        /// </summary>
        /// <param name="csv">csv.</param>
        /// <param name="invoices">invoices.</param>
        /// <param name="statements">statements.</param>
        /// <param name="portal">portal.</param>
        /// <param name="publicShow">public_show.</param>
        /// <param name="publicEdit">public_edit.</param>
        /// <param name="hosted">hosted.</param>
        public MetafieldScope(
            Models.IncludeOption? csv = null,
            Models.IncludeOption? invoices = null,
            Models.IncludeOption? statements = null,
            Models.IncludeOption? portal = null,
            Models.IncludeOption? publicShow = null,
            Models.IncludeOption? publicEdit = null,
            List<string> hosted = null)
        {
            this.Csv = csv;
            this.Invoices = invoices;
            this.Statements = statements;
            this.Portal = portal;
            this.PublicShow = publicShow;
            this.PublicEdit = publicEdit;
            this.Hosted = hosted;
        }

        /// <summary>
        /// Include (1) or exclude (0) metafields from the csv export.
        /// </summary>
        [JsonProperty("csv", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? Csv { get; set; }

        /// <summary>
        /// Include (1) or exclude (0) metafields from invoices.
        /// </summary>
        [JsonProperty("invoices", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? Invoices { get; set; }

        /// <summary>
        /// Include (1) or exclude (0) metafields from statements.
        /// </summary>
        [JsonProperty("statements", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? Statements { get; set; }

        /// <summary>
        /// Include (1) or exclude (0) metafields from the portal.
        /// </summary>
        [JsonProperty("portal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? Portal { get; set; }

        /// <summary>
        /// Include (1) or exclude (0) metafields from being viewable by your ecosystem.
        /// </summary>
        [JsonProperty("public_show", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? PublicShow { get; set; }

        /// <summary>
        /// Include (1) or exclude (0) metafields from being edited by your ecosystem.
        /// </summary>
        [JsonProperty("public_edit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeOption? PublicEdit { get; set; }

        /// <summary>
        /// Gets or sets Hosted.
        /// </summary>
        [JsonProperty("hosted", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hosted { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"MetafieldScope : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is MetafieldScope other &&
                (this.Csv == null && other.Csv == null ||
                 this.Csv?.Equals(other.Csv) == true) &&
                (this.Invoices == null && other.Invoices == null ||
                 this.Invoices?.Equals(other.Invoices) == true) &&
                (this.Statements == null && other.Statements == null ||
                 this.Statements?.Equals(other.Statements) == true) &&
                (this.Portal == null && other.Portal == null ||
                 this.Portal?.Equals(other.Portal) == true) &&
                (this.PublicShow == null && other.PublicShow == null ||
                 this.PublicShow?.Equals(other.PublicShow) == true) &&
                (this.PublicEdit == null && other.PublicEdit == null ||
                 this.PublicEdit?.Equals(other.PublicEdit) == true) &&
                (this.Hosted == null && other.Hosted == null ||
                 this.Hosted?.Equals(other.Hosted) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Csv = {(this.Csv == null ? "null" : this.Csv.ToString())}");
            toStringOutput.Add($"Invoices = {(this.Invoices == null ? "null" : this.Invoices.ToString())}");
            toStringOutput.Add($"Statements = {(this.Statements == null ? "null" : this.Statements.ToString())}");
            toStringOutput.Add($"Portal = {(this.Portal == null ? "null" : this.Portal.ToString())}");
            toStringOutput.Add($"PublicShow = {(this.PublicShow == null ? "null" : this.PublicShow.ToString())}");
            toStringOutput.Add($"PublicEdit = {(this.PublicEdit == null ? "null" : this.PublicEdit.ToString())}");
            toStringOutput.Add($"Hosted = {(this.Hosted == null ? "null" : $"[{string.Join(", ", this.Hosted)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}