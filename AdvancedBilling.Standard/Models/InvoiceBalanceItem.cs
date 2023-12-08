// <copyright file="InvoiceBalanceItem.cs" company="APIMatic">
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
    /// InvoiceBalanceItem.
    /// </summary>
    public class InvoiceBalanceItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceBalanceItem"/> class.
        /// </summary>
        public InvoiceBalanceItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceBalanceItem"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="number">number.</param>
        /// <param name="outstandingAmount">outstanding_amount.</param>
        public InvoiceBalanceItem(
            string uid = null,
            string number = null,
            string outstandingAmount = null)
        {
            this.Uid = uid;
            this.Number = number;
            this.OutstandingAmount = outstandingAmount;
        }

        /// <summary>
        /// Gets or sets Uid.
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets Number.
        /// </summary>
        [JsonProperty("number", NullValueHandling = NullValueHandling.Ignore)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets OutstandingAmount.
        /// </summary>
        [JsonProperty("outstanding_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OutstandingAmount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceBalanceItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is InvoiceBalanceItem other &&                ((this.Uid == null && other.Uid == null) || (this.Uid?.Equals(other.Uid) == true)) &&
                ((this.Number == null && other.Number == null) || (this.Number?.Equals(other.Number) == true)) &&
                ((this.OutstandingAmount == null && other.OutstandingAmount == null) || (this.OutstandingAmount?.Equals(other.OutstandingAmount) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Uid = {(this.Uid == null ? "null" : this.Uid)}");
            toStringOutput.Add($"this.Number = {(this.Number == null ? "null" : this.Number)}");
            toStringOutput.Add($"this.OutstandingAmount = {(this.OutstandingAmount == null ? "null" : this.OutstandingAmount)}");
        }
    }
}