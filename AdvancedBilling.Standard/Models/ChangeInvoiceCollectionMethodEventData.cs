// <copyright file="ChangeInvoiceCollectionMethodEventData.cs" company="APIMatic">
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
    /// ChangeInvoiceCollectionMethodEventData.
    /// </summary>
    public class ChangeInvoiceCollectionMethodEventData : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeInvoiceCollectionMethodEventData"/> class.
        /// </summary>
        public ChangeInvoiceCollectionMethodEventData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeInvoiceCollectionMethodEventData"/> class.
        /// </summary>
        /// <param name="fromCollectionMethod">from_collection_method.</param>
        /// <param name="toCollectionMethod">to_collection_method.</param>
        public ChangeInvoiceCollectionMethodEventData(
            string fromCollectionMethod,
            string toCollectionMethod)
        {
            this.FromCollectionMethod = fromCollectionMethod;
            this.ToCollectionMethod = toCollectionMethod;
        }

        /// <summary>
        /// The previous collection method of the invoice.
        /// </summary>
        [JsonProperty("from_collection_method")]
        public string FromCollectionMethod { get; set; }

        /// <summary>
        /// The new collection method of the invoice.
        /// </summary>
        [JsonProperty("to_collection_method")]
        public string ToCollectionMethod { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ChangeInvoiceCollectionMethodEventData : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ChangeInvoiceCollectionMethodEventData other &&
                (this.FromCollectionMethod == null && other.FromCollectionMethod == null ||
                 this.FromCollectionMethod?.Equals(other.FromCollectionMethod) == true) &&
                (this.ToCollectionMethod == null && other.ToCollectionMethod == null ||
                 this.ToCollectionMethod?.Equals(other.ToCollectionMethod) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FromCollectionMethod = {this.FromCollectionMethod ?? "null"}");
            toStringOutput.Add($"this.ToCollectionMethod = {this.ToCollectionMethod ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}