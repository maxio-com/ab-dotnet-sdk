// <copyright file="OnOffComponent.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// OnOffComponent.
    /// </summary>
    public class OnOffComponent : BaseModel
    {
        private Models.CreditType? upgradeCharge;
        private Models.CreditType? downgradeCredit;
        private Models.IntervalUnit? intervalUnit;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "upgrade_charge", false },
            { "downgrade_credit", false },
            { "interval_unit", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="OnOffComponent"/> class.
        /// </summary>
        public OnOffComponent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OnOffComponent"/> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="unitPrice">unit_price.</param>
        /// <param name="description">description.</param>
        /// <param name="handle">handle.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="upgradeCharge">upgrade_charge.</param>
        /// <param name="downgradeCredit">downgrade_credit.</param>
        /// <param name="pricePoints">price_points.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="hideDateRangeOnInvoice">hide_date_range_on_invoice.</param>
        /// <param name="displayOnHostedPage">display_on_hosted_page.</param>
        /// <param name="allowFractionalQuantities">allow_fractional_quantities.</param>
        /// <param name="publicSignupPageIds">public_signup_page_ids.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        public OnOffComponent(
            string name,
            OnOffComponentUnitPrice unitPrice,
            string description = null,
            string handle = null,
            bool? taxable = null,
            Models.CreditType? upgradeCharge = null,
            Models.CreditType? downgradeCredit = null,
            List<Models.ComponentPricePointItem> pricePoints = null,
            string taxCode = null,
            bool? hideDateRangeOnInvoice = null,
            bool? displayOnHostedPage = null,
            bool? allowFractionalQuantities = null,
            List<int> publicSignupPageIds = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null)
        {
            this.Name = name;
            this.Description = description;
            this.Handle = handle;
            this.Taxable = taxable;

            if (upgradeCharge != null)
            {
                this.UpgradeCharge = upgradeCharge;
            }

            if (downgradeCredit != null)
            {
                this.DowngradeCredit = downgradeCredit;
            }
            this.PricePoints = pricePoints;
            this.UnitPrice = unitPrice;
            this.TaxCode = taxCode;
            this.HideDateRangeOnInvoice = hideDateRangeOnInvoice;
            this.DisplayOnHostedPage = displayOnHostedPage;
            this.AllowFractionalQuantities = allowFractionalQuantities;
            this.PublicSignupPageIds = publicSignupPageIds;
            this.Interval = interval;

            if (intervalUnit != null)
            {
                this.IntervalUnit = intervalUnit;
            }
        }

        /// <summary>
        /// A name for this component that is suitable for showing customers and displaying on billing statements, ie. "Minutes".
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// A description for the component that will be displayed to the user on the hosted signup page.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// A unique identifier for your use that can be used to retrieve this component is subsequent requests.  Must start with a letter or number and may only contain lowercase letters, numbers, or the characters '.', ':', '-', or '_'.
        /// </summary>
        [JsonProperty("handle", NullValueHandling = NullValueHandling.Ignore)]
        public string Handle { get; set; }

        /// <summary>
        /// Boolean flag describing whether a component is taxable or not.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

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

        /// <summary>
        /// The type of credit to be created when upgrading/downgrading. Defaults to the component and then site setting if one is not provided.
        /// Available values: `full`, `prorated`, `none`.
        /// </summary>
        [JsonProperty("downgrade_credit")]
        public Models.CreditType? DowngradeCredit
        {
            get
            {
                return this.downgradeCredit;
            }

            set
            {
                this.shouldSerialize["downgrade_credit"] = true;
                this.downgradeCredit = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePoints.
        /// </summary>
        [JsonProperty("price_points", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.ComponentPricePointItem> PricePoints { get; set; }

        /// <summary>
        /// This is the amount that the customer will be charged when they turn the component on for the subscription. The price can contain up to 8 decimal places. i.e. 1.00 or 0.0012 or 0.00000065
        /// </summary>
        [JsonProperty("unit_price")]
        public OnOffComponentUnitPrice UnitPrice { get; set; }

        /// <summary>
        /// A string representing the tax code related to the component type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
        /// </summary>
        [JsonProperty("tax_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxCode { get; set; }

        /// <summary>
        /// (Only available on Relationship Invoicing sites) Boolean flag describing if the service date range should show for the component on generated invoices.
        /// </summary>
        [JsonProperty("hide_date_range_on_invoice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideDateRangeOnInvoice { get; set; }

        /// <summary>
        /// Gets or sets DisplayOnHostedPage.
        /// </summary>
        [JsonProperty("display_on_hosted_page", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayOnHostedPage { get; set; }

        /// <summary>
        /// Gets or sets AllowFractionalQuantities.
        /// </summary>
        [JsonProperty("allow_fractional_quantities", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowFractionalQuantities { get; set; }

        /// <summary>
        /// Gets or sets PublicSignupPageIds.
        /// </summary>
        [JsonProperty("public_signup_page_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> PublicSignupPageIds { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this component's default price point would renew every 30 days. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this component's default price point, either month or day. This property is only available for sites with Multifrequency enabled.
        /// </summary>
        [JsonProperty("interval_unit")]
        public Models.IntervalUnit? IntervalUnit
        {
            get
            {
                return this.intervalUnit;
            }

            set
            {
                this.shouldSerialize["interval_unit"] = true;
                this.intervalUnit = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OnOffComponent : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetUpgradeCharge()
        {
            this.shouldSerialize["upgrade_charge"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetDowngradeCredit()
        {
            this.shouldSerialize["downgrade_credit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetIntervalUnit()
        {
            this.shouldSerialize["interval_unit"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpgradeCharge()
        {
            return this.shouldSerialize["upgrade_charge"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDowngradeCredit()
        {
            return this.shouldSerialize["downgrade_credit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIntervalUnit()
        {
            return this.shouldSerialize["interval_unit"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OnOffComponent other &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.Description == null && other.Description == null ||
                 this.Description?.Equals(other.Description) == true) &&
                (this.Handle == null && other.Handle == null ||
                 this.Handle?.Equals(other.Handle) == true) &&
                (this.Taxable == null && other.Taxable == null ||
                 this.Taxable?.Equals(other.Taxable) == true) &&
                (this.UpgradeCharge == null && other.UpgradeCharge == null ||
                 this.UpgradeCharge?.Equals(other.UpgradeCharge) == true) &&
                (this.DowngradeCredit == null && other.DowngradeCredit == null ||
                 this.DowngradeCredit?.Equals(other.DowngradeCredit) == true) &&
                (this.PricePoints == null && other.PricePoints == null ||
                 this.PricePoints?.Equals(other.PricePoints) == true) &&
                (this.UnitPrice == null && other.UnitPrice == null ||
                 this.UnitPrice?.Equals(other.UnitPrice) == true) &&
                (this.TaxCode == null && other.TaxCode == null ||
                 this.TaxCode?.Equals(other.TaxCode) == true) &&
                (this.HideDateRangeOnInvoice == null && other.HideDateRangeOnInvoice == null ||
                 this.HideDateRangeOnInvoice?.Equals(other.HideDateRangeOnInvoice) == true) &&
                (this.DisplayOnHostedPage == null && other.DisplayOnHostedPage == null ||
                 this.DisplayOnHostedPage?.Equals(other.DisplayOnHostedPage) == true) &&
                (this.AllowFractionalQuantities == null && other.AllowFractionalQuantities == null ||
                 this.AllowFractionalQuantities?.Equals(other.AllowFractionalQuantities) == true) &&
                (this.PublicSignupPageIds == null && other.PublicSignupPageIds == null ||
                 this.PublicSignupPageIds?.Equals(other.PublicSignupPageIds) == true) &&
                (this.Interval == null && other.Interval == null ||
                 this.Interval?.Equals(other.Interval) == true) &&
                (this.IntervalUnit == null && other.IntervalUnit == null ||
                 this.IntervalUnit?.Equals(other.IntervalUnit) == true) &&
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
            toStringOutput.Add($"Handle = {this.Handle ?? "null"}");
            toStringOutput.Add($"Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"UpgradeCharge = {(this.UpgradeCharge == null ? "null" : this.UpgradeCharge.ToString())}");
            toStringOutput.Add($"DowngradeCredit = {(this.DowngradeCredit == null ? "null" : this.DowngradeCredit.ToString())}");
            toStringOutput.Add($"PricePoints = {(this.PricePoints == null ? "null" : $"[{string.Join(", ", this.PricePoints)} ]")}");
            toStringOutput.Add($"UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"TaxCode = {this.TaxCode ?? "null"}");
            toStringOutput.Add($"HideDateRangeOnInvoice = {(this.HideDateRangeOnInvoice == null ? "null" : this.HideDateRangeOnInvoice.ToString())}");
            toStringOutput.Add($"DisplayOnHostedPage = {(this.DisplayOnHostedPage == null ? "null" : this.DisplayOnHostedPage.ToString())}");
            toStringOutput.Add($"AllowFractionalQuantities = {(this.AllowFractionalQuantities == null ? "null" : this.AllowFractionalQuantities.ToString())}");
            toStringOutput.Add($"PublicSignupPageIds = {(this.PublicSignupPageIds == null ? "null" : $"[{string.Join(", ", this.PublicSignupPageIds)} ]")}");
            toStringOutput.Add($"Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}