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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionGroupSubscriptionError.
    /// </summary>
    public class SubscriptionGroupSubscriptionError : BaseModel
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
        /// <param name="mBase">base.</param>
        /// <param name="paymentProfileExpirationMonth">payment_profile.expiration_month.</param>
        /// <param name="paymentProfileExpirationYear">payment_profile.expiration_year.</param>
        /// <param name="paymentProfileFullNumber">payment_profile.full_number.</param>
        public SubscriptionGroupSubscriptionError(
            List<string> product = null,
            List<string> productPricePointId = null,
            List<string> paymentProfile = null,
            List<string> paymentProfileChargifyToken = null,
            List<string> mBase = null,
            List<string> paymentProfileExpirationMonth = null,
            List<string> paymentProfileExpirationYear = null,
            List<string> paymentProfileFullNumber = null)
        {
            this.Product = product;
            this.ProductPricePointId = productPricePointId;
            this.PaymentProfile = paymentProfile;
            this.PaymentProfileChargifyToken = paymentProfileChargifyToken;
            this.MBase = mBase;
            this.PaymentProfileExpirationMonth = paymentProfileExpirationMonth;
            this.PaymentProfileExpirationYear = paymentProfileExpirationYear;
            this.PaymentProfileFullNumber = paymentProfileFullNumber;
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

        /// <summary>
        /// Gets or sets MBase.
        /// </summary>
        [JsonProperty("base", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> MBase { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileExpirationMonth.
        /// </summary>
        [JsonProperty("payment_profile.expiration_month", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PaymentProfileExpirationMonth { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileExpirationYear.
        /// </summary>
        [JsonProperty("payment_profile.expiration_year", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PaymentProfileExpirationYear { get; set; }

        /// <summary>
        /// Gets or sets PaymentProfileFullNumber.
        /// </summary>
        [JsonProperty("payment_profile.full_number", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> PaymentProfileFullNumber { get; set; }

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
                ((this.PaymentProfileChargifyToken == null && other.PaymentProfileChargifyToken == null) || (this.PaymentProfileChargifyToken?.Equals(other.PaymentProfileChargifyToken) == true)) &&
                ((this.MBase == null && other.MBase == null) || (this.MBase?.Equals(other.MBase) == true)) &&
                ((this.PaymentProfileExpirationMonth == null && other.PaymentProfileExpirationMonth == null) || (this.PaymentProfileExpirationMonth?.Equals(other.PaymentProfileExpirationMonth) == true)) &&
                ((this.PaymentProfileExpirationYear == null && other.PaymentProfileExpirationYear == null) || (this.PaymentProfileExpirationYear?.Equals(other.PaymentProfileExpirationYear) == true)) &&
                ((this.PaymentProfileFullNumber == null && other.PaymentProfileFullNumber == null) || (this.PaymentProfileFullNumber?.Equals(other.PaymentProfileFullNumber) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Product = {(this.Product == null ? "null" : $"[{string.Join(", ", this.Product)} ]")}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : $"[{string.Join(", ", this.ProductPricePointId)} ]")}");
            toStringOutput.Add($"this.PaymentProfile = {(this.PaymentProfile == null ? "null" : $"[{string.Join(", ", this.PaymentProfile)} ]")}");
            toStringOutput.Add($"this.PaymentProfileChargifyToken = {(this.PaymentProfileChargifyToken == null ? "null" : $"[{string.Join(", ", this.PaymentProfileChargifyToken)} ]")}");
            toStringOutput.Add($"this.MBase = {(this.MBase == null ? "null" : $"[{string.Join(", ", this.MBase)} ]")}");
            toStringOutput.Add($"this.PaymentProfileExpirationMonth = {(this.PaymentProfileExpirationMonth == null ? "null" : $"[{string.Join(", ", this.PaymentProfileExpirationMonth)} ]")}");
            toStringOutput.Add($"this.PaymentProfileExpirationYear = {(this.PaymentProfileExpirationYear == null ? "null" : $"[{string.Join(", ", this.PaymentProfileExpirationYear)} ]")}");
            toStringOutput.Add($"this.PaymentProfileFullNumber = {(this.PaymentProfileFullNumber == null ? "null" : $"[{string.Join(", ", this.PaymentProfileFullNumber)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}