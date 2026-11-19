// <copyright file="WalletProductUsageTemplate.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// WalletProductUsageTemplate.
    /// </summary>
    public class WalletProductUsageTemplate : BaseModel
    {
        private string planName;
        private string walletTemplateName;
        private string purchaseMechanism;
        private string pricePointName;
        private int? featureTemplateId;
        private string featureTemplateName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "plan_name", false },
            { "wallet_template_name", false },
            { "purchase_mechanism", false },
            { "price_point_name", false },
            { "feature_template_id", false },
            { "feature_template_name", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageTemplate"/> class.
        /// </summary>
        public WalletProductUsageTemplate()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletProductUsageTemplate"/> class.
        /// </summary>
        /// <param name="planName">plan_name.</param>
        /// <param name="walletTemplateName">wallet_template_name.</param>
        /// <param name="unitName">unit_name.</param>
        /// <param name="purchaseMechanism">purchase_mechanism.</param>
        /// <param name="pricePointName">price_point_name.</param>
        /// <param name="currency">currency.</param>
        /// <param name="active">active.</param>
        /// <param name="featureTemplateId">feature_template_id.</param>
        /// <param name="featureTemplateName">feature_template_name.</param>
        /// <param name="pricePointOverride">price_point_override.</param>
        public WalletProductUsageTemplate(
            string planName = null,
            string walletTemplateName = null,
            string unitName = null,
            string purchaseMechanism = null,
            string pricePointName = null,
            string currency = null,
            bool? active = null,
            int? featureTemplateId = null,
            string featureTemplateName = null,
            bool? pricePointOverride = null)
        {

            if (planName != null)
            {
                this.PlanName = planName;
            }

            if (walletTemplateName != null)
            {
                this.WalletTemplateName = walletTemplateName;
            }
            this.UnitName = unitName;

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

            if (featureTemplateId != null)
            {
                this.FeatureTemplateId = featureTemplateId;
            }

            if (featureTemplateName != null)
            {
                this.FeatureTemplateName = featureTemplateName;
            }
            this.PricePointOverride = pricePointOverride;
        }

        /// <summary>
        /// The name of the product or component the Feature is assigned to. `null` when the wallet template has no assigning Feature.
        /// </summary>
        [JsonProperty("plan_name")]
        public string PlanName
        {
            get
            {
                return this.planName;
            }

            set
            {
                this.shouldSerialize["plan_name"] = true;
                this.planName = value;
            }
        }

        /// <summary>
        /// The label set in `wallet_behavior.name` on the Feature, or the standalone wallet's own `name`.
        /// </summary>
        [JsonProperty("wallet_template_name")]
        public string WalletTemplateName
        {
            get
            {
                return this.walletTemplateName;
            }

            set
            {
                this.shouldSerialize["wallet_template_name"] = true;
                this.walletTemplateName = value;
            }
        }

        /// <summary>
        /// Gets or sets UnitName.
        /// </summary>
        [JsonProperty("unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitName { get; set; }

        /// <summary>
        /// A best-effort label for how this wallet is expected to be replenished. Currently reports `"Overage"` when the wallet template allows a negative balance, and `null` otherwise; there's no persisted field yet distinguishing, for example, an intended "Auto top-up" from "Purchase more" setup. Treat this as informational, not a stable enum.
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
        /// `false` when the assigning Feature is archived.
        /// </summary>
        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets FeatureTemplateId.
        /// </summary>
        [JsonProperty("feature_template_id")]
        public int? FeatureTemplateId
        {
            get
            {
                return this.featureTemplateId;
            }

            set
            {
                this.shouldSerialize["feature_template_id"] = true;
                this.featureTemplateId = value;
            }
        }

        /// <summary>
        /// Gets or sets FeatureTemplateName.
        /// </summary>
        [JsonProperty("feature_template_name")]
        public string FeatureTemplateName
        {
            get
            {
                return this.featureTemplateName;
            }

            set
            {
                this.shouldSerialize["feature_template_name"] = true;
                this.featureTemplateName = value;
            }
        }

        /// <summary>
        /// `true` when this wallet template is priced at a price point other than the Wallet Product's default.
        /// </summary>
        [JsonProperty("price_point_override", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PricePointOverride { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WalletProductUsageTemplate : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPlanName()
        {
            this.shouldSerialize["plan_name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetWalletTemplateName()
        {
            this.shouldSerialize["wallet_template_name"] = false;
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
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeatureTemplateId()
        {
            this.shouldSerialize["feature_template_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeatureTemplateName()
        {
            this.shouldSerialize["feature_template_name"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePlanName()
        {
            return this.shouldSerialize["plan_name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWalletTemplateName()
        {
            return this.shouldSerialize["wallet_template_name"];
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeatureTemplateId()
        {
            return this.shouldSerialize["feature_template_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeatureTemplateName()
        {
            return this.shouldSerialize["feature_template_name"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WalletProductUsageTemplate other &&
                (this.PlanName == null && other.PlanName == null ||
                 this.PlanName?.Equals(other.PlanName) == true) &&
                (this.WalletTemplateName == null && other.WalletTemplateName == null ||
                 this.WalletTemplateName?.Equals(other.WalletTemplateName) == true) &&
                (this.UnitName == null && other.UnitName == null ||
                 this.UnitName?.Equals(other.UnitName) == true) &&
                (this.PurchaseMechanism == null && other.PurchaseMechanism == null ||
                 this.PurchaseMechanism?.Equals(other.PurchaseMechanism) == true) &&
                (this.PricePointName == null && other.PricePointName == null ||
                 this.PricePointName?.Equals(other.PricePointName) == true) &&
                (this.Currency == null && other.Currency == null ||
                 this.Currency?.Equals(other.Currency) == true) &&
                (this.Active == null && other.Active == null ||
                 this.Active?.Equals(other.Active) == true) &&
                (this.FeatureTemplateId == null && other.FeatureTemplateId == null ||
                 this.FeatureTemplateId?.Equals(other.FeatureTemplateId) == true) &&
                (this.FeatureTemplateName == null && other.FeatureTemplateName == null ||
                 this.FeatureTemplateName?.Equals(other.FeatureTemplateName) == true) &&
                (this.PricePointOverride == null && other.PricePointOverride == null ||
                 this.PricePointOverride?.Equals(other.PricePointOverride) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"PlanName = {this.PlanName ?? "null"}");
            toStringOutput.Add($"WalletTemplateName = {this.WalletTemplateName ?? "null"}");
            toStringOutput.Add($"UnitName = {this.UnitName ?? "null"}");
            toStringOutput.Add($"PurchaseMechanism = {this.PurchaseMechanism ?? "null"}");
            toStringOutput.Add($"PricePointName = {this.PricePointName ?? "null"}");
            toStringOutput.Add($"Currency = {this.Currency ?? "null"}");
            toStringOutput.Add($"Active = {(this.Active == null ? "null" : this.Active.ToString())}");
            toStringOutput.Add($"FeatureTemplateId = {(this.FeatureTemplateId == null ? "null" : this.FeatureTemplateId.ToString())}");
            toStringOutput.Add($"FeatureTemplateName = {this.FeatureTemplateName ?? "null"}");
            toStringOutput.Add($"PricePointOverride = {(this.PricePointOverride == null ? "null" : this.PricePointOverride.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}