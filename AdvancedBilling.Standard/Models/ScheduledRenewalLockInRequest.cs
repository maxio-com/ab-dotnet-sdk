// <copyright file="ScheduledRenewalLockInRequest.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ScheduledRenewalLockInRequest.
    /// </summary>
    public class ScheduledRenewalLockInRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalLockInRequest"/> class.
        /// </summary>
        public ScheduledRenewalLockInRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledRenewalLockInRequest"/> class.
        /// </summary>
        /// <param name="lockInAt">lock_in_at.</param>
        public ScheduledRenewalLockInRequest(
            DateTime lockInAt)
        {
            this.LockInAt = lockInAt;
        }

        /// <summary>
        /// Date to lock in the renewal.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("lock_in_at")]
        public DateTime LockInAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ScheduledRenewalLockInRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ScheduledRenewalLockInRequest other &&
                (this.LockInAt.Equals(other.LockInAt)) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"LockInAt = {this.LockInAt}");

            base.ToString(toStringOutput);
        }
    }
}