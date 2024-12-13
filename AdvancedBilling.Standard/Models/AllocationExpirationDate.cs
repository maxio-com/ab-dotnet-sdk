// <copyright file="AllocationExpirationDate.cs" company="APIMatic">
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
    /// AllocationExpirationDate.
    /// </summary>
    public class AllocationExpirationDate : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationExpirationDate"/> class.
        /// </summary>
        public AllocationExpirationDate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllocationExpirationDate"/> class.
        /// </summary>
        /// <param name="expiresAt">expires_at.</param>
        public AllocationExpirationDate(
            DateTimeOffset? expiresAt = null)
        {
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or sets ExpiresAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AllocationExpirationDate : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AllocationExpirationDate other &&
                (this.ExpiresAt == null && other.ExpiresAt == null ||
                 this.ExpiresAt?.Equals(other.ExpiresAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}