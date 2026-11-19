// <copyright file="Purchase.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Purchase.
    /// </summary>
    public class Purchase : BaseModel
    {
        private string memo;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "memo", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        public Purchase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchase"/> class.
        /// </summary>
        /// <param name="quantity">quantity.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="memo">memo.</param>
        public Purchase(
            PurchaseQuantity quantity,
            int? pricePointId = null,
            string memo = null)
        {
            this.Quantity = quantity;
            this.PricePointId = pricePointId;

            if (memo != null)
            {
                this.Memo = memo;
            }
        }

        /// <summary>
        /// The number of wallet units to purchase, as a decimal string with at most 8 fractional digits. Send fractional values as strings: a JSON number with a decimal point is rejected with `422`, because a double-precision float may already have lost precision before the request arrives.
        /// </summary>
        [JsonProperty("quantity")]
        public PurchaseQuantity Quantity { get; set; }

        /// <summary>
        /// The price point to purchase at. Must belong to the wallet's billing product. Defaults to the `price_point_id` set on the wallet.
        /// </summary>
        [JsonProperty("price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PricePointId { get; set; }

        /// <summary>
        /// (Optional) A note recorded on the resulting grant's ledger row.
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Purchase : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
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
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Purchase other &&
                (this.Quantity == null && other.Quantity == null ||
                 this.Quantity?.Equals(other.Quantity) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.Memo == null && other.Memo == null ||
                 this.Memo?.Equals(other.Memo) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"Memo = {this.Memo ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}