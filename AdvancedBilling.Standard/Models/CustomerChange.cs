// <copyright file="CustomerChange.cs" company="APIMatic">
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
    using AdvancedBilling.Standard.Models.Containers;
    using AdvancedBilling.Standard.Utilities;
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// CustomerChange.
    /// </summary>
    public class CustomerChange
    {
        private CustomerChangePayer payer;
        private CustomerChangeShippingAddress shippingAddress;
        private CustomerChangeBillingAddress billingAddress;
        private CustomerChangeCustomFields customFields;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "payer", false },
            { "shipping_address", false },
            { "billing_address", false },
            { "custom_fields", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerChange"/> class.
        /// </summary>
        public CustomerChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerChange"/> class.
        /// </summary>
        /// <param name="payer">payer.</param>
        /// <param name="shippingAddress">shipping_address.</param>
        /// <param name="billingAddress">billing_address.</param>
        /// <param name="customFields">custom_fields.</param>
        public CustomerChange(
            CustomerChangePayer payer = null,
            CustomerChangeShippingAddress shippingAddress = null,
            CustomerChangeBillingAddress billingAddress = null,
            CustomerChangeCustomFields customFields = null)
        {
            if (payer != null)
            {
                this.Payer = payer;
            }

            if (shippingAddress != null)
            {
                this.ShippingAddress = shippingAddress;
            }

            if (billingAddress != null)
            {
                this.BillingAddress = billingAddress;
            }

            if (customFields != null)
            {
                this.CustomFields = customFields;
            }

        }

        /// <summary>
        /// Gets or sets Payer.
        /// </summary>
        [JsonProperty("payer")]
        public CustomerChangePayer Payer
        {
            get
            {
                return this.payer;
            }

            set
            {
                this.shouldSerialize["payer"] = true;
                this.payer = value;
            }
        }

        /// <summary>
        /// Gets or sets ShippingAddress.
        /// </summary>
        [JsonProperty("shipping_address")]
        public CustomerChangeShippingAddress ShippingAddress
        {
            get
            {
                return this.shippingAddress;
            }

            set
            {
                this.shouldSerialize["shipping_address"] = true;
                this.shippingAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billing_address")]
        public CustomerChangeBillingAddress BillingAddress
        {
            get
            {
                return this.billingAddress;
            }

            set
            {
                this.shouldSerialize["billing_address"] = true;
                this.billingAddress = value;
            }
        }

        /// <summary>
        /// Gets or sets CustomFields.
        /// </summary>
        [JsonProperty("custom_fields")]
        public CustomerChangeCustomFields CustomFields
        {
            get
            {
                return this.customFields;
            }

            set
            {
                this.shouldSerialize["custom_fields"] = true;
                this.customFields = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPayer()
        {
            this.shouldSerialize["payer"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetShippingAddress()
        {
            this.shouldSerialize["shipping_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetBillingAddress()
        {
            this.shouldSerialize["billing_address"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomFields()
        {
            this.shouldSerialize["custom_fields"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePayer()
        {
            return this.shouldSerialize["payer"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShippingAddress()
        {
            return this.shouldSerialize["shipping_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeBillingAddress()
        {
            return this.shouldSerialize["billing_address"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomFields()
        {
            return this.shouldSerialize["custom_fields"];
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
            return obj is CustomerChange other &&                ((this.Payer == null && other.Payer == null) || (this.Payer?.Equals(other.Payer) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.CustomFields == null && other.CustomFields == null) || (this.CustomFields?.Equals(other.CustomFields) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Payer = {(this.Payer == null ? "null" : this.Payer.ToString())}");
            toStringOutput.Add($"ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"CustomFields = {(this.CustomFields == null ? "null" : this.CustomFields.ToString())}");
        }
    }
}