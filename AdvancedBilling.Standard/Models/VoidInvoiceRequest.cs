// <copyright file="VoidInvoiceRequest.cs" company="APIMatic">
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
    /// VoidInvoiceRequest.
    /// </summary>
    public class VoidInvoiceRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceRequest"/> class.
        /// </summary>
        public VoidInvoiceRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoidInvoiceRequest"/> class.
        /// </summary>
        /// <param name="mVoid">void.</param>
        public VoidInvoiceRequest(
            Models.VoidInvoice mVoid)
        {
            this.MVoid = mVoid;
        }

        /// <summary>
        /// Gets or sets MVoid.
        /// </summary>
        [JsonProperty("void")]
        public Models.VoidInvoice MVoid { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"VoidInvoiceRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is VoidInvoiceRequest other &&                ((this.MVoid == null && other.MVoid == null) || (this.MVoid?.Equals(other.MVoid) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MVoid = {(this.MVoid == null ? "null" : this.MVoid.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}