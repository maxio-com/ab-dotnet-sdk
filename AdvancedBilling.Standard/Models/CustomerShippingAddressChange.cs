// <copyright file="CustomerShippingAddressChange.cs" company="APIMatic">
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
    /// CustomerShippingAddressChange.
    /// </summary>
    public class CustomerShippingAddressChange
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingAddressChange"/> class.
        /// </summary>
        public CustomerShippingAddressChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingAddressChange"/> class.
        /// </summary>
        /// <param name="before">before.</param>
        /// <param name="after">after.</param>
        public CustomerShippingAddressChange(
            object before = null,
            object after = null)
        {
            this.Before = before;
            this.After = after;
        }

        /// <summary>
        /// Gets or sets Before.
        /// </summary>
        [JsonProperty("before", NullValueHandling = NullValueHandling.Ignore)]
        public object Before { get; set; }

        /// <summary>
        /// Gets or sets After.
        /// </summary>
        [JsonProperty("after", NullValueHandling = NullValueHandling.Ignore)]
        public object After { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerShippingAddressChange : ({string.Join(", ", toStringOutput)})";
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
            return obj is CustomerShippingAddressChange other &&                ((this.Before == null && other.Before == null) || (this.Before?.Equals(other.Before) == true)) &&
                ((this.After == null && other.After == null) || (this.After?.Equals(other.After) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Before = {(this.Before == null ? "null" : this.Before.ToString())}");
            toStringOutput.Add($"After = {(this.After == null ? "null" : this.After.ToString())}");
        }
    }
}