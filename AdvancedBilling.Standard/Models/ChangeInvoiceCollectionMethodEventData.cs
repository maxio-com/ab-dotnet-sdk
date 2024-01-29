// <copyright file="ChangeInvoiceCollectionMethodEventData.cs" company="APIMatic">
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
    /// ChangeInvoiceCollectionMethodEventData.
    /// </summary>
    public class ChangeInvoiceCollectionMethodEventData
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
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("from_collection_method")]
        [JsonRequired]
        public string FromCollectionMethod { get; set; }

        /// <summary>
        /// The new collection method of the invoice.
        /// </summary>
        [JsonConverter(typeof(JsonStringConverter), true)]
        [JsonProperty("to_collection_method")]
        [JsonRequired]
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
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ChangeInvoiceCollectionMethodEventData other &&                ((this.FromCollectionMethod == null && other.FromCollectionMethod == null) || (this.FromCollectionMethod?.Equals(other.FromCollectionMethod) == true)) &&
                ((this.ToCollectionMethod == null && other.ToCollectionMethod == null) || (this.ToCollectionMethod?.Equals(other.ToCollectionMethod) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FromCollectionMethod = {(this.FromCollectionMethod == null ? "null" : this.FromCollectionMethod)}");
            toStringOutput.Add($"this.ToCollectionMethod = {(this.ToCollectionMethod == null ? "null" : this.ToCollectionMethod)}");
        }
    }
}