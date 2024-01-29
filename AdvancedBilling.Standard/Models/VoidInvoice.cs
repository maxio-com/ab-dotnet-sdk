// <copyright file="VoidInvoice.cs" company="APIMatic">
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
    /// VoidInvoice.
    /// </summary>
    public class VoidInvoice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoice"/> class.
        /// </summary>
        public VoidInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoice"/> class.
        /// </summary>
        /// <param name="reason">reason.</param>
        public VoidInvoice(
            string reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or sets Reason.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VoidInvoice : ({string.Join(", ", toStringOutput)})";
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
            return obj is VoidInvoice other &&                ((this.Reason == null && other.Reason == null) || (this.Reason?.Equals(other.Reason) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Reason = {(this.Reason == null ? "null" : this.Reason)}");
        }
    }
}