// <copyright file="ReferralCode.cs" company="APIMatic">
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
    /// ReferralCode.
    /// </summary>
    public class ReferralCode : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralCode"/> class.
        /// </summary>
        public ReferralCode()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferralCode"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="siteId">site_id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="code">code.</param>
        public ReferralCode(
            int? id = null,
            int? siteId = null,
            int? subscriptionId = null,
            string code = null)
        {
            this.Id = id;
            this.SiteId = siteId;
            this.SubscriptionId = subscriptionId;
            this.Code = code;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SiteId.
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets Code.
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReferralCode : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReferralCode other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SiteId == null && other.SiteId == null ||
                 this.SiteId?.Equals(other.SiteId) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.Code == null && other.Code == null ||
                 this.Code?.Equals(other.Code) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.SiteId = {(this.SiteId == null ? "null" : this.SiteId.ToString())}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.Code = {this.Code ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}