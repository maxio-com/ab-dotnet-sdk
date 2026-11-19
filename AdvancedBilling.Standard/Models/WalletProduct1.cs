// <copyright file="WalletProduct1.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProduct1.
    /// </summary>
    public class WalletProduct1 : BaseModel
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
        /// Initializes a new instance of the <see cref="WalletProduct1"/> class.
        /// </summary>
        public WalletProduct1()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProduct1"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="itemCategory">item_category.</param>
        public WalletProduct1(
            string name = null,
            string description = null,
            bool? taxable = null,
            string taxCode = null,
            string accountingCode = null,
            Models.ItemCategory? itemCategory = null)
        {
            this.Name = name;

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
        }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProduct1 : ({string.Join(", ", toStringOutput)})";
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

            return obj is WalletProduct1 other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
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
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"Description = {this.Description ?? "null"}");
            toStringOutput.Add($"Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"TaxCode = {this.TaxCode ?? "null"}");
            toStringOutput.Add($"AccountingCode = {this.AccountingCode ?? "null"}");
            toStringOutput.Add($"ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}