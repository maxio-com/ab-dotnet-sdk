// <copyright file="GroupSettings.cs" company="APIMatic">
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
    /// GroupSettings.
    /// </summary>
    public class GroupSettings : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSettings"/> class.
        /// </summary>
        public GroupSettings()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupSettings"/> class.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="billing">billing.</param>
        public GroupSettings(
            Models.GroupTarget target,
            Models.GroupBilling billing = null)
        {
            this.Target = target;
            this.Billing = billing;
        }

        /// <summary>
        /// Attributes of the target customer who will be the responsible payer of the created subscription. Required.
        /// </summary>
        [JsonProperty("target")]
        public Models.GroupTarget Target { get; set; }

        /// <summary>
        /// Optional attributes related to billing date and accrual. Note: Only applicable for new subscriptions.
        /// </summary>
        [JsonProperty("billing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupBilling Billing { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"GroupSettings : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is GroupSettings other &&
                (this.Target == null && other.Target == null ||
                 this.Target?.Equals(other.Target) == true) &&
                (this.Billing == null && other.Billing == null ||
                 this.Billing?.Equals(other.Billing) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Target = {(this.Target == null ? "null" : this.Target.ToString())}");
            toStringOutput.Add($"Billing = {(this.Billing == null ? "null" : this.Billing.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}