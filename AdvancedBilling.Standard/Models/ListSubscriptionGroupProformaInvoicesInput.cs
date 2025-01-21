// <copyright file="ListSubscriptionGroupProformaInvoicesInput.cs" company="APIMatic">
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
    /// ListSubscriptionGroupProformaInvoicesInput.
    /// </summary>
    public class ListSubscriptionGroupProformaInvoicesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupProformaInvoicesInput"/> class.
        /// </summary>
        public ListSubscriptionGroupProformaInvoicesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupProformaInvoicesInput"/> class.
        /// </summary>
        /// <param name="uid">uid.</param>
        /// <param name="lineItems">line_items.</param>
        /// <param name="discounts">discounts.</param>
        /// <param name="taxes">taxes.</param>
        /// <param name="credits">credits.</param>
        /// <param name="payments">payments.</param>
        /// <param name="customFields">custom_fields.</param>
        public ListSubscriptionGroupProformaInvoicesInput(
            string uid,
            bool? lineItems = false,
            bool? discounts = false,
            bool? taxes = false,
            bool? credits = false,
            bool? payments = false,
            bool? customFields = false)
        {
            this.Uid = uid;
            this.LineItems = lineItems;
            this.Discounts = discounts;
            this.Taxes = taxes;
            this.Credits = credits;
            this.Payments = payments;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// The uid of the subscription group
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Include line items data
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public bool? LineItems { get; set; }

        /// <summary>
        /// Include discounts data
        /// </summary>
        [JsonProperty("discounts", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Discounts { get; set; }

        /// <summary>
        /// Include taxes data
        /// </summary>
        [JsonProperty("taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxes { get; set; }

        /// <summary>
        /// Include credits data
        /// </summary>
        [JsonProperty("credits", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Credits { get; set; }

        /// <summary>
        /// Include payments data
        /// </summary>
        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Payments { get; set; }

        /// <summary>
        /// Include custom fields data
        /// </summary>
        [JsonProperty("custom_fields", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomFields { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSubscriptionGroupProformaInvoicesInput : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionGroupProformaInvoicesInput other &&
                (this.Uid == null && other.Uid == null ||
                 this.Uid?.Equals(other.Uid) == true) &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.Discounts == null && other.Discounts == null ||
                 this.Discounts?.Equals(other.Discounts) == true) &&
                (this.Taxes == null && other.Taxes == null ||
                 this.Taxes?.Equals(other.Taxes) == true) &&
                (this.Credits == null && other.Credits == null ||
                 this.Credits?.Equals(other.Credits) == true) &&
                (this.Payments == null && other.Payments == null ||
                 this.Payments?.Equals(other.Payments) == true) &&
                (this.CustomFields == null && other.CustomFields == null ||
                 this.CustomFields?.Equals(other.CustomFields) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Uid = {this.Uid ?? "null"}");
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : this.LineItems.ToString())}");
            toStringOutput.Add($"Discounts = {(this.Discounts == null ? "null" : this.Discounts.ToString())}");
            toStringOutput.Add($"Taxes = {(this.Taxes == null ? "null" : this.Taxes.ToString())}");
            toStringOutput.Add($"Credits = {(this.Credits == null ? "null" : this.Credits.ToString())}");
            toStringOutput.Add($"Payments = {(this.Payments == null ? "null" : this.Payments.ToString())}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}