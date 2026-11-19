// <copyright file="WalletProduct.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProduct.
    /// </summary>
    public class WalletProduct : BaseModel
    {
        private string description;
        private string taxCode;
        private string accountingCode;
        private Models.ItemCategory? itemCategory;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "tax_code", false },
            { "accounting_code", false },
            { "item_category", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProduct"/> class.
        /// </summary>
        public WalletProduct()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProduct"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="unitName">unit_name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="description">description.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="itemCategory">item_category.</param>
        /// <param name="pricePoint">price_point.</param>
        /// <param name="pricePoints">price_points.</param>
        public WalletProduct(
            string name,
            string unitName,
            string handle = null,
            string description = null,
            bool? taxable = null,
            string taxCode = null,
            string accountingCode = null,
            Models.ItemCategory? itemCategory = null,
            Models.WalletProductPricePointAttributes pricePoint = null,
            List<Models.WalletProductPricePointAttributes> pricePoints = null)
        {
            this.Name = name;
            this.UnitName = unitName;
            this.Handle = handle;

            if (description != null)
            {
                this.Description = description;
            }
            this.Taxable = taxable;

            if (taxCode != null)
            {
                this.TaxCode = taxCode;
            }

            if (accountingCode != null)
            {
                this.AccountingCode = accountingCode;
            }

            if (itemCategory != null)
            {
                this.ItemCategory = itemCategory;
            }
            this.PricePoint = pricePoint;
            this.PricePoints = pricePoints;
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The name of the unit the Wallet Product's usage is measured in, for example `tokens`.
        /// </summary>
        [JsonProperty("unit_name")]
        public string UnitName { get; set; }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets Taxable.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// Gets or sets TaxCode.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode
        {
            get
            {
                return this.taxCode;
            }

            set
            {
                this.shouldSerialize["tax_code"] = true;
                this.taxCode = value;
            }
        }

        /// <summary>
        /// Gets or sets AccountingCode.
        /// </summary>
        [JsonProperty("accounting_code")]
        public string AccountingCode
        {
            get
            {
                return this.accountingCode;
            }

            set
            {
                this.shouldSerialize["accounting_code"] = true;
                this.accountingCode = value;
            }
        }

        /// <summary>
        /// One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other
        /// </summary>
        [JsonProperty("item_category")]
        public Models.ItemCategory? ItemCategory
        {
            get
            {
                return this.itemCategory;
            }

            set
            {
                this.shouldSerialize["item_category"] = true;
                this.itemCategory = value;
            }
        }

        /// <summary>
        /// Creates one price point for the Wallet Product in the same call. Ignored if `price_points` is also sent.
        /// </summary>
        [JsonProperty("price_point", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletProductPricePointAttributes PricePoint { get; set; }

        /// <summary>
        /// Creates several price points for the Wallet Product in the same call, winning over `price_point` if both are sent. The first price point created becomes the Wallet Product's default. The whole call is one transaction: if any price point in the array fails validation, nothing is created, including the Wallet Product itself.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WalletProductPricePointAttributes> PricePoints { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProduct : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetTaxCode()
        {
            this.shouldSerialize["tax_code"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAccountingCode()
        {
            this.shouldSerialize["accounting_code"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetItemCategory()
        {
            this.shouldSerialize["item_category"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTaxCode()
        {
            return this.shouldSerialize["tax_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountingCode()
        {
            return this.shouldSerialize["accounting_code"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeItemCategory()
        {
            return this.shouldSerialize["item_category"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProduct other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.UnitName == null && other.UnitName == null ||
                 this.UnitName?.Equals(other.UnitName) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Taxable == null && other.Taxable == null ||
                 this.Taxable?.Equals(other.Taxable) == true) &&
                (this.TaxCode == null && other.TaxCode == null ||
                 this.TaxCode?.Equals(other.TaxCode) == true) &&
                (this.AccountingCode == null && other.AccountingCode == null ||
                 this.AccountingCode?.Equals(other.AccountingCode) == true) &&
                (this.ItemCategory == null && other.ItemCategory == null ||
                 this.ItemCategory?.Equals(other.ItemCategory) == true) &&
                (this.PricePoint == null && other.PricePoint == null ||
                 this.PricePoint?.Equals(other.PricePoint) == true) &&
                (this.PricePoints == null && other.PricePoints == null ||
                 this.PricePoints?.Equals(other.PricePoints) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"UnitName = {this.UnitName ?? "null"}");
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"TaxCode = {this.TaxCode ?? "null"}");
            toStringOutput.Add($"AccountingCode = {this.AccountingCode ?? "null"}");
            toStringOutput.Add($"ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory.ToString())}");
            toStringOutput.Add($"PricePoint = {(this.PricePoint == null ? "null" : this.PricePoint.ToString())}");
            toStringOutput.Add($"PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}