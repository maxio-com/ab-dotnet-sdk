// <copyright file="CustomerCustomFieldsChange.cs" company="APIMatic">
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
    /// CustomerCustomFieldsChange.
    /// </summary>
    public class CustomerCustomFieldsChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCustomFieldsChange"/> class.
        /// </summary>
        public CustomerCustomFieldsChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerCustomFieldsChange"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public CustomerCustomFieldsChange(
            List<Models.InvoiceCustomField> before,
            List<Models.InvoiceCustomField> after)
        {
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Gets or sets Before.
        /// </summary>
        [JsonProperty("before")]
        [JsonRequired]
        public List<Models.InvoiceCustomField> Before { get; set; }

        /// <summary>
        /// Gets or sets After.
        /// </summary>
        [JsonProperty("after")]
        [JsonRequired]
        public List<Models.InvoiceCustomField> After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerCustomFieldsChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerCustomFieldsChange other &&                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true)) &&
                ((this.After == null && other.After == null) || (this.After?.Equals(other.After) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Before = {(this.Before == null ? "null" : $"[{string.Join(", ", this.Before)} ]")}");
            toStringOutput.Add($"this.After = {(this.After == null ? "null" : $"[{string.Join(", ", this.After)} ]")}");
        }
    }
}