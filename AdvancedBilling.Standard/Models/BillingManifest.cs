// <copyright file="BillingManifest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// BillingManifest.
    /// </summary>
    public class BillingManifest : BaseModel
    {
        private DateTimeOffset? startDate;
        private DateTimeOffset? endDate;
        private string periodType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "start_date", false },
            { "end_date", false },
            { "period_type", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingManifest"/> class.
        /// </summary>
        public BillingManifest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingManifest"/> class.
        /// </summary>
        /// <param name="lineItems">line_items.</param>
        /// <param name="totalInCents">total_in_cents.</param>
        /// <param name="totalDiscountInCents">total_discount_in_cents.</param>
        /// <param name="totalTaxInCents">total_tax_in_cents.</param>
        /// <param name="subtotalInCents">subtotal_in_cents.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="periodType">period_type.</param>
        /// <param name="existingBalanceInCents">existing_balance_in_cents.</param>
        public BillingManifest(
            List<Models.BillingManifestItem> lineItems = null,
            long? totalInCents = null,
            long? totalDiscountInCents = null,
            long? totalTaxInCents = null,
            long? subtotalInCents = null,
            DateTimeOffset? startDate = null,
            DateTimeOffset? endDate = null,
            string periodType = null,
            long? existingBalanceInCents = null)
        {
            this.LineItems = lineItems;
            this.TotalInCents = totalInCents;
            this.TotalDiscountInCents = totalDiscountInCents;
            this.TotalTaxInCents = totalTaxInCents;
            this.SubtotalInCents = subtotalInCents;

            if (startDate != null)
            {
                this.StartDate = startDate;
            }

            if (endDate != null)
            {
                this.EndDate = endDate;
            }

            if (periodType != null)
            {
                this.PeriodType = periodType;
            }
            this.ExistingBalanceInCents = existingBalanceInCents;
        }

        /// <summary>
        /// Gets or sets LineItems.
        /// </summary>
        [JsonProperty("line_items", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.BillingManifestItem> LineItems { get; set; }

        /// <summary>
        /// Gets or sets TotalInCents.
        /// </summary>
        [JsonProperty("total_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalDiscountInCents.
        /// </summary>
        [JsonProperty("total_discount_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalDiscountInCents { get; set; }

        /// <summary>
        /// Gets or sets TotalTaxInCents.
        /// </summary>
        [JsonProperty("total_tax_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalTaxInCents { get; set; }

        /// <summary>
        /// Gets or sets SubtotalInCents.
        /// </summary>
        [JsonProperty("subtotal_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubtotalInCents { get; set; }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_date")]
        public DateTimeOffset? StartDate
        {
            get
            {
                return this.startDate;
            }

            set
            {
                this.shouldSerialize["start_date"] = true;
                this.startDate = value;
            }
        }

        /// <summary>
        /// Gets or sets EndDate.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_date")]
        public DateTimeOffset? EndDate
        {
            get
            {
                return this.endDate;
            }

            set
            {
                this.shouldSerialize["end_date"] = true;
                this.endDate = value;
            }
        }

        /// <summary>
        /// Gets or sets PeriodType.
        /// </summary>
        [JsonProperty("period_type")]
        public string PeriodType
        {
            get
            {
                return this.periodType;
            }

            set
            {
                this.shouldSerialize["period_type"] = true;
                this.periodType = value;
            }
        }

        /// <summary>
        /// Gets or sets ExistingBalanceInCents.
        /// </summary>
        [JsonProperty("existing_balance_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? ExistingBalanceInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillingManifest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetStartDate()
        {
            this.shouldSerialize["start_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEndDate()
        {
            this.shouldSerialize["end_date"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPeriodType()
        {
            this.shouldSerialize["period_type"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStartDate()
        {
            return this.shouldSerialize["start_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEndDate()
        {
            return this.shouldSerialize["end_date"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePeriodType()
        {
            return this.shouldSerialize["period_type"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillingManifest other &&
                (this.LineItems == null && other.LineItems == null ||
                 this.LineItems?.Equals(other.LineItems) == true) &&
                (this.TotalInCents == null && other.TotalInCents == null ||
                 this.TotalInCents?.Equals(other.TotalInCents) == true) &&
                (this.TotalDiscountInCents == null && other.TotalDiscountInCents == null ||
                 this.TotalDiscountInCents?.Equals(other.TotalDiscountInCents) == true) &&
                (this.TotalTaxInCents == null && other.TotalTaxInCents == null ||
                 this.TotalTaxInCents?.Equals(other.TotalTaxInCents) == true) &&
                (this.SubtotalInCents == null && other.SubtotalInCents == null ||
                 this.SubtotalInCents?.Equals(other.SubtotalInCents) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.PeriodType == null && other.PeriodType == null ||
                 this.PeriodType?.Equals(other.PeriodType) == true) &&
                (this.ExistingBalanceInCents == null && other.ExistingBalanceInCents == null ||
                 this.ExistingBalanceInCents?.Equals(other.ExistingBalanceInCents) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");
            toStringOutput.Add($"TotalInCents = {(this.TotalInCents == null ? "null" : this.TotalInCents.ToString())}");
            toStringOutput.Add($"TotalDiscountInCents = {(this.TotalDiscountInCents == null ? "null" : this.TotalDiscountInCents.ToString())}");
            toStringOutput.Add($"TotalTaxInCents = {(this.TotalTaxInCents == null ? "null" : this.TotalTaxInCents.ToString())}");
            toStringOutput.Add($"SubtotalInCents = {(this.SubtotalInCents == null ? "null" : this.SubtotalInCents.ToString())}");
            toStringOutput.Add($"StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"PeriodType = {this.PeriodType ?? "null"}");
            toStringOutput.Add($"ExistingBalanceInCents = {(this.ExistingBalanceInCents == null ? "null" : this.ExistingBalanceInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}