// <copyright file="TaxConfiguration.cs" company="APIMatic">
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
    /// TaxConfiguration.
    /// </summary>
    public class TaxConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxConfiguration"/> class.
        /// </summary>
        public TaxConfiguration()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaxConfiguration"/> class.
        /// </summary>
        /// <param name="kind">kind.</param>
        /// <param name="destinationAddress">destination_address.</param>
        /// <param name="fullyConfigured">fully_configured.</param>
        public TaxConfiguration(
            Models.TaxConfigurationKind? kind = Models.TaxConfigurationKind.Custom,
            Models.TaxDestinationAddress? destinationAddress = null,
            bool? fullyConfigured = false)
        {
            this.Kind = kind;
            this.DestinationAddress = destinationAddress;
            this.FullyConfigured = fullyConfigured;
        }

        /// <summary>
        /// Gets or sets Kind.
        /// </summary>
        [JsonProperty("kind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxConfigurationKind? Kind { get; set; }

        /// <summary>
        /// Gets or sets DestinationAddress.
        /// </summary>
        [JsonProperty("destination_address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.TaxDestinationAddress? DestinationAddress { get; set; }

        /// <summary>
        /// Returns `true` when Chargify has been properly configured to charge tax using the specified tax system. More details about taxes: https://maxio-chargify.zendesk.com/hc/en-us/articles/5405488905869-Taxes-Introduction
        /// </summary>
        [JsonProperty("fully_configured", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FullyConfigured { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TaxConfiguration : ({string.Join(", ", toStringOutput)})";
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
            return obj is TaxConfiguration other &&                ((this.Kind == null && other.Kind == null) || (this.Kind?.Equals(other.Kind) == true)) &&
                ((this.DestinationAddress == null && other.DestinationAddress == null) || (this.DestinationAddress?.Equals(other.DestinationAddress) == true)) &&
                ((this.FullyConfigured == null && other.FullyConfigured == null) || (this.FullyConfigured?.Equals(other.FullyConfigured) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Kind = {(this.Kind == null ? "null" : this.Kind.ToString())}");
            toStringOutput.Add($"this.DestinationAddress = {(this.DestinationAddress == null ? "null" : this.DestinationAddress.ToString())}");
            toStringOutput.Add($"this.FullyConfigured = {(this.FullyConfigured == null ? "null" : this.FullyConfigured.ToString())}");
        }
    }
}