// <copyright file="SaleRepSubscription.cs" company="APIMatic">
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
    /// SaleRepSubscription.
    /// </summary>
    public class SaleRepSubscription : BaseModel
    {
        private string churnDate;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "churn_date", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepSubscription"/> class.
        /// </summary>
        public SaleRepSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRepSubscription"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="siteName">site_name.</param>
        /// <param name="subscriptionUrl">subscription_url.</param>
        /// <param name="customerName">customer_name.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="mrr">mrr.</param>
        /// <param name="usage">usage.</param>
        /// <param name="recurring">recurring.</param>
        /// <param name="lastPayment">last_payment.</param>
        /// <param name="churnDate">churn_date.</param>
        public SaleRepSubscription(
            int? id = null,
            string siteName = null,
            string subscriptionUrl = null,
            string customerName = null,
            string createdAt = null,
            string mrr = null,
            string usage = null,
            string recurring = null,
            string lastPayment = null,
            string churnDate = null)
        {
            this.Id = id;
            this.SiteName = siteName;
            this.SubscriptionUrl = subscriptionUrl;
            this.CustomerName = customerName;
            this.CreatedAt = createdAt;
            this.Mrr = mrr;
            this.Usage = usage;
            this.Recurring = recurring;
            this.LastPayment = lastPayment;

            if (churnDate != null)
            {
                this.ChurnDate = churnDate;
            }
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SiteName.
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionUrl.
        /// </summary>
        [JsonProperty("subscription_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SubscriptionUrl { get; set; }

        /// <summary>
        /// Gets or sets CustomerName.
        /// </summary>
        [JsonProperty("customer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets Mrr.
        /// </summary>
        [JsonProperty("mrr", NullValueHandling = NullValueHandling.Ignore)]
        public string Mrr { get; set; }

        /// <summary>
        /// Gets or sets Usage.
        /// </summary>
        [JsonProperty("usage", NullValueHandling = NullValueHandling.Ignore)]
        public string Usage { get; set; }

        /// <summary>
        /// Gets or sets Recurring.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public string Recurring { get; set; }

        /// <summary>
        /// Gets or sets LastPayment.
        /// </summary>
        [JsonProperty("last_payment", NullValueHandling = NullValueHandling.Ignore)]
        public string LastPayment { get; set; }

        /// <summary>
        /// Gets or sets ChurnDate.
        /// </summary>
        [JsonProperty("churn_date")]
        public string ChurnDate
        {
            get
            {
                return this.churnDate;
            }

            set
            {
                this.shouldSerialize["churn_date"] = true;
                this.churnDate = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SaleRepSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetChurnDate()
        {
            this.shouldSerialize["churn_date"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeChurnDate()
        {
            return this.shouldSerialize["churn_date"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SaleRepSubscription other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SiteName == null && other.SiteName == null ||
                 this.SiteName?.Equals(other.SiteName) == true) &&
                (this.SubscriptionUrl == null && other.SubscriptionUrl == null ||
                 this.SubscriptionUrl?.Equals(other.SubscriptionUrl) == true) &&
                (this.CustomerName == null && other.CustomerName == null ||
                 this.CustomerName?.Equals(other.CustomerName) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.Mrr == null && other.Mrr == null ||
                 this.Mrr?.Equals(other.Mrr) == true) &&
                (this.Usage == null && other.Usage == null ||
                 this.Usage?.Equals(other.Usage) == true) &&
                (this.Recurring == null && other.Recurring == null ||
                 this.Recurring?.Equals(other.Recurring) == true) &&
                (this.LastPayment == null && other.LastPayment == null ||
                 this.LastPayment?.Equals(other.LastPayment) == true) &&
                (this.ChurnDate == null && other.ChurnDate == null ||
                 this.ChurnDate?.Equals(other.ChurnDate) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"SiteName = {this.SiteName ?? "null"}");
            toStringOutput.Add($"SubscriptionUrl = {this.SubscriptionUrl ?? "null"}");
            toStringOutput.Add($"CustomerName = {this.CustomerName ?? "null"}");
            toStringOutput.Add($"CreatedAt = {this.CreatedAt ?? "null"}");
            toStringOutput.Add($"Mrr = {this.Mrr ?? "null"}");
            toStringOutput.Add($"Usage = {this.Usage ?? "null"}");
            toStringOutput.Add($"Recurring = {this.Recurring ?? "null"}");
            toStringOutput.Add($"LastPayment = {this.LastPayment ?? "null"}");
            toStringOutput.Add($"ChurnDate = {this.ChurnDate ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}