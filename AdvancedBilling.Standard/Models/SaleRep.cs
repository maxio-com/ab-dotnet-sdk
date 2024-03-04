// <copyright file="SaleRep.cs" company="APIMatic">
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
    /// SaleRep.
    /// </summary>
    public class SaleRep : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRep"/> class.
        /// </summary>
        public SaleRep()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SaleRep"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="fullName">full_name.</param>
        /// <param name="subscriptionsCount">subscriptions_count.</param>
        /// <param name="testMode">test_mode.</param>
        /// <param name="subscriptions">subscriptions.</param>
        public SaleRep(
            int? id = null,
            string fullName = null,
            int? subscriptionsCount = null,
            bool? testMode = null,
            List<Models.SaleRepSubscription> subscriptions = null)
        {
            this.Id = id;
            this.FullName = fullName;
            this.SubscriptionsCount = subscriptionsCount;
            this.TestMode = testMode;
            this.Subscriptions = subscriptions;
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
        /// Gets or sets TestMode.
        /// </summary>
        [JsonProperty("test_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Gets or sets Subscriptions.
        /// </summary>
        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SaleRepSubscription> Subscriptions { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SaleRep : ({string.Join(", ", toStringOutput)})";
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
            return obj is SaleRep other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.FullName == null && other.FullName == null) || (this.FullName?.Equals(other.FullName) == true)) &&
                ((this.SubscriptionsCount == null && other.SubscriptionsCount == null) || (this.SubscriptionsCount?.Equals(other.SubscriptionsCount) == true)) &&
                ((this.TestMode == null && other.TestMode == null) || (this.TestMode?.Equals(other.TestMode) == true)) &&
                ((this.Subscriptions == null && other.Subscriptions == null) || (this.Subscriptions?.Equals(other.Subscriptions) == true));
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
            toStringOutput.Add($"this.TestMode = {(this.TestMode == null ? "null" : this.TestMode.ToString())}");
            toStringOutput.Add($"this.Subscriptions = {(this.Subscriptions == null ? "null" : $"[{string.Join(", ", this.Subscriptions)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}