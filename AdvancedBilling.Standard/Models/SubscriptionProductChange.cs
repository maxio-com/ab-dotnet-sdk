// <copyright file="SubscriptionProductChange.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// SubscriptionProductChange.
    /// </summary>
    public class SubscriptionProductChange : BaseModel
    {
        private int? previousProductPricePointId;
        private int? newProductPricePointId;
        private DateTimeOffset? effectiveAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "previous_product_price_point_id", false },
            { "new_product_price_point_id", false },
            { "effective_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductChange"/> class.
        /// </summary>
        public SubscriptionProductChange()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductChange"/> class.
        /// </summary>
        /// <param name="previousProductId">previous_product_id.</param>
        /// <param name="newProductId">new_product_id.</param>
        /// <param name="previousProductPricePointId">previous_product_price_point_id.</param>
        /// <param name="newProductPricePointId">new_product_price_point_id.</param>
        /// <param name="effectiveAt">effective_at.</param>
        public SubscriptionProductChange(
            int previousProductId,
            int newProductId,
            int? previousProductPricePointId = null,
            int? newProductPricePointId = null,
            DateTimeOffset? effectiveAt = null)
        {
            this.PreviousProductId = previousProductId;
            this.NewProductId = newProductId;

            if (previousProductPricePointId != null)
            {
                this.PreviousProductPricePointId = previousProductPricePointId;
            }

            if (newProductPricePointId != null)
            {
                this.NewProductPricePointId = newProductPricePointId;
            }

            if (effectiveAt != null)
            {
                this.EffectiveAt = effectiveAt;
            }
        }

        /// <summary>
        /// Gets or sets PreviousProductId.
        /// </summary>
        [JsonProperty("previous_product_id")]
        [JsonRequired]
        public int PreviousProductId { get; set; }

        /// <summary>
        /// Gets or sets NewProductId.
        /// </summary>
        [JsonProperty("new_product_id")]
        [JsonRequired]
        public int NewProductId { get; set; }

        /// <summary>
        /// Gets or sets PreviousProductPricePointId.
        /// </summary>
        [JsonProperty("previous_product_price_point_id")]
        public int? PreviousProductPricePointId
        {
            get
            {
                return this.previousProductPricePointId;
            }

            set
            {
                this.shouldSerialize["previous_product_price_point_id"] = true;
                this.previousProductPricePointId = value;
            }
        }

        /// <summary>
        /// Gets or sets NewProductPricePointId.
        /// </summary>
        [JsonProperty("new_product_price_point_id")]
        public int? NewProductPricePointId
        {
            get
            {
                return this.newProductPricePointId;
            }

            set
            {
                this.shouldSerialize["new_product_price_point_id"] = true;
                this.newProductPricePointId = value;
            }
        }

        /// <summary>
        /// When the scheduled product change takes effect (the subscription's next renewal). Only sent for `subscription_product_change_scheduled`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("effective_at")]
        public DateTimeOffset? EffectiveAt
        {
            get
            {
                return this.effectiveAt;
            }

            set
            {
                this.shouldSerialize["effective_at"] = true;
                this.effectiveAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionProductChange : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPreviousProductPricePointId()
        {
            this.shouldSerialize["previous_product_price_point_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetNewProductPricePointId()
        {
            this.shouldSerialize["new_product_price_point_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetEffectiveAt()
        {
            this.shouldSerialize["effective_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePreviousProductPricePointId()
        {
            return this.shouldSerialize["previous_product_price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeNewProductPricePointId()
        {
            return this.shouldSerialize["new_product_price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEffectiveAt()
        {
            return this.shouldSerialize["effective_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionProductChange other &&
                (this.PreviousProductId.Equals(other.PreviousProductId)) &&
                (this.NewProductId.Equals(other.NewProductId)) &&
                (this.PreviousProductPricePointId == null && other.PreviousProductPricePointId == null ||
                 this.PreviousProductPricePointId?.Equals(other.PreviousProductPricePointId) == true) &&
                (this.NewProductPricePointId == null && other.NewProductPricePointId == null ||
                 this.NewProductPricePointId?.Equals(other.NewProductPricePointId) == true) &&
                (this.EffectiveAt == null && other.EffectiveAt == null ||
                 this.EffectiveAt?.Equals(other.EffectiveAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PreviousProductId = {this.PreviousProductId}");
            toStringOutput.Add($"NewProductId = {this.NewProductId}");
            toStringOutput.Add($"PreviousProductPricePointId = {(this.PreviousProductPricePointId == null ? "null" : this.PreviousProductPricePointId.ToString())}");
            toStringOutput.Add($"NewProductPricePointId = {(this.NewProductPricePointId == null ? "null" : this.NewProductPricePointId.ToString())}");
            toStringOutput.Add($"EffectiveAt = {(this.EffectiveAt == null ? "null" : this.EffectiveAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}