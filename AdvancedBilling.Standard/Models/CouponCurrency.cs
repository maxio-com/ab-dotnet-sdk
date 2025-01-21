// <copyright file="CouponCurrency.cs" company="APIMatic">
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
    /// CouponCurrency.
    /// </summary>
    public class CouponCurrency : BaseModel
    {
        private int? id;
        private double? price;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "price", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrency"/> class.
        /// </summary>
        public CouponCurrency()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponCurrency"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="currency">currency.</param>
        /// <param name="price">price.</param>
        /// <param name="couponId">coupon_id.</param>
        public CouponCurrency(
            int? id = null,
            string currency = null,
            double? price = null,
            int? couponId = null)
        {

            if (id != null)
            {
                this.Id = id;
            }
            this.Currency = currency;

            if (price != null)
            {
                this.Price = price;
            }
            this.CouponId = couponId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public int? Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets Price.
        /// </summary>
        [JsonProperty("price")]
        public double? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.shouldSerialize["price"] = true;
                this.price = value;
            }
        }

        /// <summary>
        /// Gets or sets CouponId.
        /// </summary>
        [JsonProperty("coupon_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CouponId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"CouponCurrency : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPrice()
        {
            this.shouldSerialize["price"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePrice()
        {
            return this.shouldSerialize["price"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CouponCurrency other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Price == null && other.Price == null ||
                 this.Price?.Equals(other.Price) == true) &&
                (this.CouponId == null && other.CouponId == null ||
                 this.CouponId?.Equals(other.CouponId) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Price = {(this.Price == null ? "null" : this.Price.ToString())}");
            toStringOutput.Add($"CouponId = {(this.CouponId == null ? "null" : this.CouponId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}