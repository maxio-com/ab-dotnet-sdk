// <copyright file="SubscriptionGroupSubscriptionError.cs" company="APIMatic">
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
    /// SubscriptionGroupSubscriptionError.
    /// </summary>
    public class SubscriptionGroupSubscriptionError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubscriptionError"/> class.
        /// </summary>
        public SubscriptionGroupSubscriptionError()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupSubscriptionError"/> class.
        /// </summary>
        /// <param name="product">product.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="paymentProfile">payment_profile.</param>
        /// <param name="paymentProfileChargifyToken">payment_profile.chargify_token.</param>
        public SubscriptionGroupSubscriptionError(
            List<string> product = null,
            List<string> productPricePointId = null,
            List<string> paymentProfile = null,
            List<string> paymentProfileChargifyToken = null)
        {
            this.Product = product;
            this.ProductPricePointId = productPricePointId;
            this.PaymentProfile = paymentProfile;
            this.PaymentProfileChargifyToken = paymentProfileChargifyToken;
        }

        /// <summary>
        /// Gets or sets Product.
        /// </summary>
        [JsonProperty("product", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Product { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfile.
        /// </summary>
        [JsonProperty("payment_profile", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PaymentProfile { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileChargifyToken.
        /// </summary>
        [JsonProperty("payment_profile.chargify_token", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PaymentProfileChargifyToken { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionGroupSubscriptionError : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionGroupSubscriptionError other &&                ((this.Product == null && other.Product == null) || (this.Product?.Equals(other.Product) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.PaymentProfile == null && other.PaymentProfile == null) || (this.PaymentProfile?.Equals(other.PaymentProfile) == true)) &&
                ((this.PaymentProfileChargifyToken == null && other.PaymentProfileChargifyToken == null) || (this.PaymentProfileChargifyToken?.Equals(other.PaymentProfileChargifyToken) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : $"[{string.Join(", ", this.Product)} ]")}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : $"[{string.Join(", ", this.ProductPricePointId)} ]")}");
            toStringOutput.Add($"this.PaymentProfile = {(this.PaymentProfile == null ? "null" : $"[{string.Join(", ", this.PaymentProfile)} ]")}");
            toStringOutput.Add($"this.PaymentProfileChargifyToken = {(this.PaymentProfileChargifyToken == null ? "null" : $"[{string.Join(", ", this.PaymentProfileChargifyToken)} ]")}");
        }
    }
}