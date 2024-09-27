// <copyright file="ListSaleRepItem.cs" company="APIMatic">
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
    /// ListSaleRepItem.
    /// </summary>
    public class ListSaleRepItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSaleRepItem"/> class.
        /// </summary>
        public ListSaleRepItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSaleRepItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fullName">full_name.</param>
        /// <param name="subscriptionsCount">subscriptions_count.</param>
        /// <param name="mrrData">mrr_data.</param>
        /// <param name="testMode">test_mode.</param>
        public ListSaleRepItem(
            int? id = null,
            string fullName = null,
            int? subscriptionsCount = null,
            Dictionary<string, Models.SaleRepItemMrr> mrrData = null,
            bool? testMode = null)
        {
            this.Id = id;
            this.FullName = fullName;
            this.SubscriptionsCount = subscriptionsCount;
            this.MrrData = mrrData;
            this.TestMode = testMode;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets FullName.
        /// </summary>
        [JsonProperty("full_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionsCount.
        /// </summary>
        [JsonProperty("subscriptions_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionsCount { get; set; }

        /// <summary>
        /// Gets or sets MrrData.
        /// </summary>
        [JsonProperty("mrr_data", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Models.SaleRepItemMrr> MrrData { get; set; }

        /// <summary>
        /// Gets or sets TestMode.
        /// </summary>
        [JsonProperty("test_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestMode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListSaleRepItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListSaleRepItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.SubscriptionsCount == null && other.SubscriptionsCount == null) || (this.SubscriptionsCount?.Equals(other.SubscriptionsCount) == true)) &&
                ((this.MrrData == null && other.MrrData == null) || (this.MrrData?.Equals(other.MrrData) == true)) &&
                ((this.TestMode == null && other.TestMode == null) || (this.TestMode?.Equals(other.TestMode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.FullName = {(this.FullName == null ? "null" : this.FullName)}");
            toStringOutput.Add($"this.SubscriptionsCount = {(this.SubscriptionsCount == null ? "null" : this.SubscriptionsCount.ToString())}");
            toStringOutput.Add($"MrrData = {(this.MrrData == null ? "null" : this.MrrData.ToString())}");
            toStringOutput.Add($"this.TestMode = {(this.TestMode == null ? "null" : this.TestMode.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}