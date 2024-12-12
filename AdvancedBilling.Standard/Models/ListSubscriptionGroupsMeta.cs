// <copyright file="ListSubscriptionGroupsMeta.cs" company="APIMatic">
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
    /// ListSubscriptionGroupsMeta.
    /// </summary>
    public class ListSubscriptionGroupsMeta : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsMeta"/> class.
        /// </summary>
        public ListSubscriptionGroupsMeta()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListSubscriptionGroupsMeta"/> class.
        /// </summary>
        /// <param name="currentPage">current_page.</param>
        /// <param name="totalCount">total_count.</param>
        public ListSubscriptionGroupsMeta(
            int? currentPage = null,
            int? totalCount = null)
        {
            this.CurrentPage = currentPage;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or sets CurrentPage.
        /// </summary>
        [JsonProperty("current_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Gets or sets TotalCount.
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListSubscriptionGroupsMeta : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListSubscriptionGroupsMeta other &&
                (this.CurrentPage == null && other.CurrentPage == null ||
                 this.CurrentPage?.Equals(other.CurrentPage) == true) &&
                (this.TotalCount == null && other.TotalCount == null ||
                 this.TotalCount?.Equals(other.TotalCount) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CurrentPage = {(this.CurrentPage == null ? "null" : this.CurrentPage.ToString())}");
            toStringOutput.Add($"this.TotalCount = {(this.TotalCount == null ? "null" : this.TotalCount.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}