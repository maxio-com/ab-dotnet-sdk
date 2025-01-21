// <copyright file="PaymentForAllocation.cs" company="APIMatic">
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
    /// PaymentForAllocation.
    /// </summary>
    public class PaymentForAllocation : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentForAllocation"/> class.
        /// </summary>
        public PaymentForAllocation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentForAllocation"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="amountInCents">amount_in_cents.</param>
        /// <param name="success">success.</param>
        /// <param name="memo">memo.</param>
        public PaymentForAllocation(
            int? id = null,
            long? amountInCents = null,
            bool? success = null,
            string memo = null)
        {
            this.Id = id;
            this.AmountInCents = amountInCents;
            this.Success = success;
            this.Memo = memo;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets AmountInCents.
        /// </summary>
        [JsonProperty("amount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? AmountInCents { get; set; }

        /// <summary>
        /// Gets or sets Success.
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo", NullValueHandling = NullValueHandling.Ignore)]
        public string Memo { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PaymentForAllocation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PaymentForAllocation other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.AmountInCents == null && other.AmountInCents == null ||
                 this.AmountInCents?.Equals(other.AmountInCents) == true) &&
                (this.Success == null && other.Success == null ||
                 this.Success?.Equals(other.Success) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"AmountInCents = {(this.AmountInCents == null ? "null" : this.AmountInCents.ToString())}");
            toStringOutput.Add($"Success = {(this.Success == null ? "null" : this.Success.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}