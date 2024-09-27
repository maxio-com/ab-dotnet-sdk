// <copyright file="MovementLineItem.cs" company="APIMatic">
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
    /// MovementLineItem.
    /// </summary>
    public class MovementLineItem : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MovementLineItem"/> class.
        /// </summary>
        public MovementLineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovementLineItem"/> class.
        /// </summary>
        /// <param name="productId">product_id.</param>
        /// <param name="componentId">component_id.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="name">name.</param>
        /// <param name="mrr">mrr.</param>
        /// <param name="mrrMovements">mrr_movements.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="prevQuantity">prev_quantity.</param>
        /// <param name="recurring">recurring.</param>
        public MovementLineItem(
            int? productId = null,
            int? componentId = null,
            int? pricePointId = null,
            string name = null,
            int? mrr = null,
            List<Models.MRRMovement> mrrMovements = null,
            int? quantity = null,
            int? prevQuantity = null,
            bool? recurring = null)
        {
            this.ProductId = productId;
            this.ComponentId = componentId;
            this.PricePointId = pricePointId;
            this.Name = name;
            this.Mrr = mrr;
            this.MrrMovements = mrrMovements;
            this.Quantity = quantity;
            this.PrevQuantity = prevQuantity;
            this.Recurring = recurring;
        }

        /// <summary>
        /// Gets or sets ProductId.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// For Product (or "baseline") line items, this field will have a value of `0`.
        /// </summary>
        [JsonProperty("component_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ComponentId { get; set; }

        /// <summary>
        /// Gets or sets PricePointId.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Mrr.
        /// </summary>
        [JsonProperty("mrr", NullValueHandling = NullValueHandling.Ignore)]
        public int? Mrr { get; set; }

        /// <summary>
        /// Gets or sets MrrMovements.
        /// </summary>
        [JsonProperty("mrr_movements", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.MRRMovement> MrrMovements { get; set; }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets PrevQuantity.
        /// </summary>
        [JsonProperty("prev_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? PrevQuantity { get; set; }

        /// <summary>
        /// When `true`, the line item's MRR value will contribute to the `plan` breakout. When `false`, the line item contributes to the `usage` breakout.
        /// </summary>
        [JsonProperty("recurring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurring { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"MovementLineItem : ({string.Join(", ", toStringOutput)})";
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
            return obj is MovementLineItem other &&                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ComponentId == null && other.ComponentId == null) || (this.ComponentId?.Equals(other.ComponentId) == true)) &&
                ((this.PricePointId == null && other.PricePointId == null) || (this.PricePointId?.Equals(other.PricePointId) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Mrr == null && other.Mrr == null) || (this.Mrr?.Equals(other.Mrr) == true)) &&
                ((this.MrrMovements == null && other.MrrMovements == null) || (this.MrrMovements?.Equals(other.MrrMovements) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.PrevQuantity == null && other.PrevQuantity == null) || (this.PrevQuantity?.Equals(other.PrevQuantity) == true)) &&
                ((this.Recurring == null && other.Recurring == null) || (this.Recurring?.Equals(other.Recurring) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ComponentId = {(this.ComponentId == null ? "null" : this.ComponentId.ToString())}");
            toStringOutput.Add($"this.PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Mrr = {(this.Mrr == null ? "null" : this.Mrr.ToString())}");
            toStringOutput.Add($"this.MrrMovements = {(this.MrrMovements == null ? "null" : $"[{string.Join(", ", this.MrrMovements)} ]")}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.PrevQuantity = {(this.PrevQuantity == null ? "null" : this.PrevQuantity.ToString())}");
            toStringOutput.Add($"this.Recurring = {(this.Recurring == null ? "null" : this.Recurring.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}