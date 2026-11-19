// <copyright file="WalletProductActiveWallet.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductActiveWallet.
    /// </summary>
    public class WalletProductActiveWallet : BaseModel
    {
        private string purchaseMechanism;
        private string pricePointName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "purchase_mechanism", false },
            { "price_point_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductActiveWallet"/> class.
        /// </summary>
        public WalletProductActiveWallet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductActiveWallet"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="companyName">company_name.</param>
        /// <param name="purchaseMechanism">purchase_mechanism.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="currency">currency.</param>
        /// <param name="active">active.</param>
        public WalletProductActiveWallet(
            int? id = null,
            int? subscriptionId = null,
            string companyName = null,
            string purchaseMechanism = null,
            string pricePointName = null,
            string currency = null,
            bool? active = null)
        {
            this.Id = id;
            this.SubscriptionId = subscriptionId;
            this.CompanyName = companyName;

            if (purchaseMechanism != null)
            {
                this.PurchaseMechanism = purchaseMechanism;
            }

            if (pricePointName != null)
            {
                this.PricePointName = pricePointName;
            }
            this.Currency = currency;
            this.Active = active;
        }

        /// <summary>
        /// The Advanced Billing id of the wallet.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// <![CDATA[
        /// The owning customer's organization name, falling back to their full name, then to `"Customer #<id>"`. `"Customer"` (with no id) when the wallet's subscription has no customer at all.
        /// ]]>
        /// </summary>
        [JsonProperty("company_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /// <summary>
        /// See the same field on [Wallet Product Usage Template]($m/Wallet%20Product%20Usage%20Template). The same caveats apply.
        /// </summary>
        [JsonProperty("purchase_mechanism")]
        public string PurchaseMechanism
        {
            get
            {
                return this.purchaseMechanism;
            }

            set
            {
                this.shouldSerialize["purchase_mechanism"] = true;
                this.purchaseMechanism = value;
            }
        }

        /// <summary>
        /// Gets or sets PricePointName.
        /// </summary>
        [JsonProperty("price_point_name")]
        public string PricePointName
        {
            get
            {
                return this.pricePointName;
            }

            set
            {
                this.shouldSerialize["price_point_name"] = true;
                this.pricePointName = value;
            }
        }

        /// <summary>
        /// Gets or sets Currency.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// `false` when the wallet's Feature is archived.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductActiveWallet : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPurchaseMechanism()
        {
            this.shouldSerialize["purchase_mechanism"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricePointName()
        {
            this.shouldSerialize["price_point_name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePurchaseMechanism()
        {
            return this.shouldSerialize["purchase_mechanism"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointName()
        {
            return this.shouldSerialize["price_point_name"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductActiveWallet other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.CompanyName == null && other.CompanyName == null ||
                 this.CompanyName?.Equals(other.CompanyName) == true) &&
                (this.PurchaseMechanism == null && other.PurchaseMechanism == null ||
                 this.PurchaseMechanism?.Equals(other.PurchaseMechanism) == true) &&
                (this.PricePointName == null && other.PricePointName == null ||
                 this.PricePointName?.Equals(other.PricePointName) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"CompanyName = {this.CompanyName ?? "null"}");
            toStringOutput.Add($"PurchaseMechanism = {this.PurchaseMechanism ?? "null"}");
            toStringOutput.Add($"PricePointName = {this.PricePointName ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}