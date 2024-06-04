// <copyright file="InvoiceSeller.cs" company="APIMatic">
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
    /// InvoiceSeller.
    /// </summary>
    public class InvoiceSeller : BaseModel
    {
        private string logoUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "logo_url", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSeller"/> class.
        /// </summary>
        public InvoiceSeller()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSeller"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="address">address.</param>
        /// <param name="phone">phone.</param>
        /// <param name="logoUrl">logo_url.</param>
        public InvoiceSeller(
            string name = null,
            Models.InvoiceAddress address = null,
            string phone = null,
            string logoUrl = null)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
            if (logoUrl != null)
            {
                this.LogoUrl = logoUrl;
            }

        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Address.
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Models.InvoiceAddress Address { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        [JsonProperty("phone", NullValueHandling = NullValueHandling.Ignore)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets LogoUrl.
        /// </summary>
        [JsonProperty("logo_url")]
        public string LogoUrl
        {
            get
            {
                return this.logoUrl;
            }

            set
            {
                this.shouldSerialize["logo_url"] = true;
                this.logoUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"InvoiceSeller : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLogoUrl()
        {
            this.shouldSerialize["logo_url"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLogoUrl()
        {
            return this.shouldSerialize["logo_url"];
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
            return obj is InvoiceSeller other &&                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Address == null && other.Address == null) || (this.Address?.Equals(other.Address) == true)) &&
                ((this.Phone == null && other.Phone == null) || (this.Phone?.Equals(other.Phone) == true)) &&
                ((this.LogoUrl == null && other.LogoUrl == null) || (this.LogoUrl?.Equals(other.LogoUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Address = {(this.Address == null ? "null" : this.Address.ToString())}");
            toStringOutput.Add($"this.Phone = {(this.Phone == null ? "null" : this.Phone)}");
            toStringOutput.Add($"this.LogoUrl = {(this.LogoUrl == null ? "null" : this.LogoUrl)}");

            base.ToString(toStringOutput);
        }
    }
}