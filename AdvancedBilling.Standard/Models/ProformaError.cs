// <copyright file="ProformaError.cs" company="APIMatic">
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
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// ProformaError.
    /// </summary>
    public class ProformaError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaError"/> class.
        /// </summary>
        public ProformaError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProformaError"/> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        public ProformaError(
            Models.BaseStringError subscription = null)
        {
            this.Subscription = subscription;
        }

        /// <summary>
        /// The error is base if it is not directly associated with a single attribute.
        /// </summary>
        [JsonProperty("subscription", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BaseStringError Subscription { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ProformaError : ({string.Join(", ", toStringOutput)})";
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
            return obj is ProformaError other &&                ((this.Subscription == null && other.Subscription == null) || (this.Subscription?.Equals(other.Subscription) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Subscription = {(this.Subscription == null ? "null" : this.Subscription.ToString())}");
        }
    }
}