// <copyright file="ActivateSubscriptionRequest.cs" company="APIMatic">
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
    /// ActivateSubscriptionRequest.
    /// </summary>
    public class ActivateSubscriptionRequest : BaseModel
    {
        private bool? revertOnFailure;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "revert_on_failure", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateSubscriptionRequest"/> class.
        /// </summary>
        public ActivateSubscriptionRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivateSubscriptionRequest"/> class.
        /// </summary>
        /// <param name="revertOnFailure">revert_on_failure.</param>
        public ActivateSubscriptionRequest(
            bool? revertOnFailure = null)
        {

            if (revertOnFailure != null)
            {
                this.RevertOnFailure = revertOnFailure;
            }
        }

        /// <summary>
        /// You may choose how to handle the activation failure. `true` means do not change the subscription’s state and billing period. `false`  means to continue through with the activation and enter an end of life state. If this parameter is omitted or `null` is passed it will default to value set in the  site settings (default: `true`)
        /// </summary>
        [JsonProperty("revert_on_failure")]
        public bool? RevertOnFailure
        {
            get
            {
                return this.revertOnFailure;
            }

            set
            {
                this.shouldSerialize["revert_on_failure"] = true;
                this.revertOnFailure = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ActivateSubscriptionRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetRevertOnFailure()
        {
            this.shouldSerialize["revert_on_failure"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRevertOnFailure()
        {
            return this.shouldSerialize["revert_on_failure"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ActivateSubscriptionRequest other &&
                (this.RevertOnFailure == null && other.RevertOnFailure == null ||
                 this.RevertOnFailure?.Equals(other.RevertOnFailure) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"RevertOnFailure = {(this.RevertOnFailure == null ? "null" : this.RevertOnFailure.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}