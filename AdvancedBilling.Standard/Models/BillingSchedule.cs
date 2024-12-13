// <copyright file="BillingSchedule.cs" company="APIMatic">
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
    /// BillingSchedule.
    /// </summary>
    public class BillingSchedule : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSchedule"/> class.
        /// </summary>
        public BillingSchedule()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingSchedule"/> class.
        /// </summary>
        /// <param name="initialBillingAt">initial_billing_at.</param>
        public BillingSchedule(
            DateTime? initialBillingAt = null)
        {
            this.InitialBillingAt = initialBillingAt;
        }

        /// <summary>
        /// The initial_billing_at attribute in Maxio allows you to specify a custom starting date for billing cycles associated with components that have their own billing frequency set. Only ISO8601 format is supported.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("initial_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? InitialBillingAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"BillingSchedule : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is BillingSchedule other &&
                (this.InitialBillingAt == null && other.InitialBillingAt == null ||
                 this.InitialBillingAt?.Equals(other.InitialBillingAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.InitialBillingAt = {(this.InitialBillingAt == null ? "null" : this.InitialBillingAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}