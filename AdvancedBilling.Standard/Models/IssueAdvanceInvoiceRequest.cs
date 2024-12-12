// <copyright file="IssueAdvanceInvoiceRequest.cs" company="APIMatic">
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
    /// IssueAdvanceInvoiceRequest.
    /// </summary>
    public class IssueAdvanceInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAdvanceInvoiceRequest"/> class.
        /// </summary>
        public IssueAdvanceInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssueAdvanceInvoiceRequest"/> class.
        /// </summary>
        /// <param name="force">force.</param>
        public IssueAdvanceInvoiceRequest(
            bool? force = null)
        {
            this.Force = force;
        }

        /// <summary>
        /// Gets or sets Force.
        /// </summary>
        [JsonProperty("force", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"IssueAdvanceInvoiceRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is IssueAdvanceInvoiceRequest other &&
                (this.Force == null && other.Force == null ||
                 this.Force?.Equals(other.Force) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Force = {(this.Force == null ? "null" : this.Force.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}