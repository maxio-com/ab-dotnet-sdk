// <copyright file="UpdateComponent.cs" company="APIMatic">
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
    /// UpdateComponent.
    /// </summary>
    public class UpdateComponent : BaseModel
    {
        private string description;
        private string accountingCode;
        private string taxCode;
        private Models.ItemCategory? itemCategory;
        private Models.CreditType? upgradeCharge;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "description", false },
            { "accounting_code", false },
            { "tax_code", false },
            { "item_category", false },
            { "upgrade_charge", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponent"/> class.
        /// </summary>
        public UpdateComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateComponent"/> class.
        /// </summary>
        /// <param name="handle">handle.</param>
        /// <param name="name">name.</param>
        /// <param name="description">description.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="itemCategory">item_category.</param>
        /// <param name="displayOnHostedPage">display_on_hosted_page.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        public UpdateComponent(
            string handle = null,
            string name = null,
            string description = null,
            string accountingCode = null,
            bool? taxable = null,
            string taxCode = null,
            Models.ItemCategory? itemCategory = null,
            bool? displayOnHostedPage = null,
            Models.CreditType? upgradeCharge = null)
        {
            this.Handle = handle;
            this.Name = name;

            if (description != null)
            {
                this.Description = description;
            }

            if (accountingCode != null)
            {
                this.AccountingCode = accountingCode;
            }
            this.Taxable = taxable;

            if (taxCode != null)
            {
                this.TaxCode = taxCode;
            }

            if (itemCategory != null)
            {
                this.ItemCategory = itemCategory;
            }
            this.DisplayOnHostedPage = displayOnHostedPage;

            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }
        }

        /// <summary>
        /// Gets or sets Handle.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// The name of the Component, suitable for display on statements. i.e. Text Messages.
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the component.
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
        /// Boolean flag describing whether a component is taxable or not.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// A string representing the tax code related to the component type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
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
        /// Gets or sets DisplayOnHostedPage.
        /// </summary>
        [JsonProperty("display_on_hosted_page", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayOnHostedPage { get; set; }

        /// <summary>
        /// The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.
        /// Available values: `full`, `prorated`, `none`.
        /// </summary>
        [JsonProperty("upgrade_charge")]
        public Models.CreditType? UpgradeCharge
        {
            get
            {
                return this.upgradeCharge;
            }

            set
            {
                this.shouldSerialize["upgrade_charge"] = true;
                this.upgradeCharge = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"UpdateComponent : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAccountingCode()
        {
            this.shouldSerialize["accounting_code"] = false;
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
        public void UnsetItemCategory()
        {
            this.shouldSerialize["item_category"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpgradeCharge()
        {
            this.shouldSerialize["upgrade_charge"] = false;
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
        public bool ShouldSerializeAccountingCode()
        {
            return this.shouldSerialize["accounting_code"];
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
        public bool ShouldSerializeItemCategory()
        {
            return this.shouldSerialize["item_category"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpgradeCharge()
        {
            return this.shouldSerialize["upgrade_charge"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is UpdateComponent other &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.AccountingCode == null && other.AccountingCode == null ||
                 this.AccountingCode?.Equals(other.AccountingCode) == true) &&
                (this.Taxable == null && other.Taxable == null ||
                 this.Taxable?.Equals(other.Taxable) == true) &&
                (this.TaxCode == null && other.TaxCode == null ||
                 this.TaxCode?.Equals(other.TaxCode) == true) &&
                (this.ItemCategory == null && other.ItemCategory == null ||
                 this.ItemCategory?.Equals(other.ItemCategory) == true) &&
                (this.DisplayOnHostedPage == null && other.DisplayOnHostedPage == null ||
                 this.DisplayOnHostedPage?.Equals(other.DisplayOnHostedPage) == true) &&
                (this.UpgradeCharge == null && other.UpgradeCharge == null ||
                 this.UpgradeCharge?.Equals(other.UpgradeCharge) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"this.Name = {this.Name ?? "null"}");
            toStringOutput.Add($"this.Description = {this.Description ?? "null"}");
            toStringOutput.Add($"this.AccountingCode = {this.AccountingCode ?? "null"}");
            toStringOutput.Add($"this.Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"this.TaxCode = {this.TaxCode ?? "null"}");
            toStringOutput.Add($"this.ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory.ToString())}");
            toStringOutput.Add($"this.DisplayOnHostedPage = {(this.DisplayOnHostedPage == null ? "null" : this.DisplayOnHostedPage.ToString())}");
            toStringOutput.Add($"this.UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}