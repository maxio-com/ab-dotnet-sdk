// <copyright file="Usage.cs" company="APIMatic">
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
    /// Usage.
    /// </summary>
    public class Usage : BaseModel
    {
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        public Usage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Usage"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="memo">memo.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="overageQuantity">overage_quantity.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="componentHandle">component_handle.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        public Usage(
            long? id = null,
            string memo = null,
            DateTimeOffset? createdAt = null,
            int? pricePointId = null,
            UsageQuantity quantity = null,
            int? overageQuantity = null,
            int? componentId = null,
            string componentHandle = null,
            int? subscriptionId = null)
        {
            this.Id = id;
            if (memo != null)
            {
                this.Memo = memo;
            }

            this.CreatedAt = createdAt;
            this.PricePointId = pricePointId;
            this.Quantity = quantity;
            this.OverageQuantity = overageQuantity;
            this.ComponentId = componentId;
            this.ComponentHandle = componentHandle;
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Gets or sets Memo.
        /// </summary>
        [JsonProperty("memo")]
        public string Memo
        {
            get
            {
                return this.memo;
            }

            set
            {
                this.shouldSerialize["memo"] = true;
                this.memo = value;
            }
        }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public UsageQuantity Quantity { get; set; }

        /// <summary>
        /// Gets or sets OverageQuantity.
        /// </summary>
        [JsonProperty("overage_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? OverageQuantity { get; set; }

        /// <summary>
        /// Gets or sets ComponentId.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets ComponentHandle.
        /// </summary>
        [JsonProperty("component_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ComponentHandle { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Usage : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMemo()
        {
            this.shouldSerialize["memo"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMemo()
        {
            return this.shouldSerialize["memo"];
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
            return obj is Usage other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Memo == null && other.Memo == null) || (this.Memo?.Equals(other.Memo) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.OverageQuantity == null && other.OverageQuantity == null) || (this.OverageQuantity?.Equals(other.OverageQuantity) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.ComponentHandle == null && other.ComponentHandle == null) || (this.ComponentHandle?.Equals(other.ComponentHandle) == true)) &&
                ((this.SubscriptionId == null && other.SubscriptionId == null) || (this.SubscriptionId?.Equals(other.SubscriptionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Memo = {(this.Memo == null ? "null" : this.Memo)}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.OverageQuantity = {(this.OverageQuantity == null ? "null" : this.OverageQuantity.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.ComponentHandle = {(this.ComponentHandle == null ? "null" : this.ComponentHandle)}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}