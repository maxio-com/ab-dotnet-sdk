// <copyright file="OriginInvoice.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// OriginInvoice.
    /// </summary>
    public class OriginInvoice : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OriginInvoice"/> class.
        /// </summary>
        public OriginInvoice()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OriginInvoice"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="number">number.</param>
        public OriginInvoice(
            string uid = null,
            string number = null)
        {
            this.Uid = uid;
            this.Number = number;
        }

        /// <summary>
        /// The UID of the invoice serving as an origin invoice.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// The number of the invoice serving as an origin invoice.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"OriginInvoice : ({string.Join(", ", toStringOutput)})";
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
            return obj is OriginInvoice other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");

            base.ToString(toStringOutput);
        }
    }
}