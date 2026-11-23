// <copyright file="Wallet.cs" company="APIMatic">
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
    /// Wallet.
    /// </summary>
    public class Wallet : BaseModel
    {
        private string name;
        private int? pricePointId;
        private Models.Meter meter;
        private DateTimeOffset? meteredThroughAt;
        private int? meteredRecheckAfterSeconds;
        private bool? meteredStale;
        private string featureKey;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "name", false },
            { "price_point_id", false },
            { "meter", false },
            { "metered_through_at", false },
            { "metered_recheck_after_seconds", false },
            { "metered_stale", false },
            { "feature_key", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet"/> class.
        /// </summary>
        public Wallet()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wallet"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="ownerType">owner_type.</param>
        /// <param name="ownerId">owner_id.</param>
        /// <param name="name">name.</param>
        /// <param name="walletProductId">wallet_product_id.</param>
        /// <param name="walletProductName">wallet_product_name.</param>
        /// <param name="unit">unit.</param>
        /// <param name="pricePointId">price_point_id.</param>
        /// <param name="balance">balance.</param>
        /// <param name="postedBalance">posted_balance.</param>
        /// <param name="meter">meter.</param>
        /// <param name="meteredThroughAt">metered_through_at.</param>
        /// <param name="meteredRecheckAfterSeconds">metered_recheck_after_seconds.</param>
        /// <param name="meteredStale">metered_stale.</param>
        /// <param name="status">status.</param>
        /// <param name="depletionPolicy">depletion_policy.</param>
        /// <param name="hardStopOverflow">hard_stop_overflow.</param>
        /// <param name="origin">origin.</param>
        /// <param name="featureKey">feature_key.</param>
        /// <param name="grants">grants.</param>
        /// <param name="recurringFunding">recurring_funding.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        public Wallet(
            int? id = null,
            Models.OwnerType? ownerType = null,
            int? ownerId = null,
            string name = null,
            int? walletProductId = null,
            string walletProductName = null,
            string unit = null,
            int? pricePointId = null,
            string balance = null,
            string postedBalance = null,
            Models.Meter meter = null,
            DateTimeOffset? meteredThroughAt = null,
            int? meteredRecheckAfterSeconds = null,
            bool? meteredStale = null,
            Models.WalletStatus? status = null,
            string depletionPolicy = null,
            Models.WalletHardStopOverflow? hardStopOverflow = null,
            Models.WalletOrigin? origin = null,
            string featureKey = null,
            List<Models.WalletGrant> grants = null,
            List<Models.WalletRecurringFunding> recurringFunding = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null)
        {
            this.Id = id;
            this.OwnerType = ownerType;
            this.OwnerId = ownerId;

            if (name != null)
            {
                this.Name = name;
            }
            this.WalletProductId = walletProductId;
            this.WalletProductName = walletProductName;
            this.Unit = unit;

            if (pricePointId != null)
            {
                this.PricePointId = pricePointId;
            }
            this.Balance = balance;
            this.PostedBalance = postedBalance;

            if (meter != null)
            {
                this.Meter = meter;
            }

            if (meteredThroughAt != null)
            {
                this.MeteredThroughAt = meteredThroughAt;
            }

            if (meteredRecheckAfterSeconds != null)
            {
                this.MeteredRecheckAfterSeconds = meteredRecheckAfterSeconds;
            }

            if (meteredStale != null)
            {
                this.MeteredStale = meteredStale;
            }
            this.Status = status;
            this.DepletionPolicy = depletionPolicy;
            this.HardStopOverflow = hardStopOverflow;
            this.Origin = origin;

            if (featureKey != null)
            {
                this.FeatureKey = featureKey;
            }
            this.Grants = grants;
            this.RecurringFunding = recurringFunding;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// The Advanced Billing id of the wallet.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The polymorphic owner type. `subscription` is the only value currently supported.
        /// </summary>
        [JsonProperty("owner_type", NullValueHandling = NullValueHandling.Ignore)]
        public Models.OwnerType? OwnerType { get; set; }

        /// <summary>
        /// The id of the owning subscription.
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// (Optional) A merchant-facing label for the wallet, set on create and changeable with [Update Wallet]($e/Wallets/updateWallet). Surrounding spaces are stripped; a blank value is stored as `null`.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.shouldSerialize["name"] = true;
                this.name = value;
            }
        }

        /// <summary>
        /// The id of the [Wallet Product]($e/Wallet%20Products/createWalletProduct) that denominates the wallet. Immutable for the life of the wallet.
        /// </summary>
        [JsonProperty("wallet_product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? WalletProductId { get; set; }

        /// <summary>
        /// The name of the Wallet Product that denominates the wallet.
        /// </summary>
        [JsonProperty("wallet_product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WalletProductName { get; set; }

        /// <summary>
        /// The billing product's unit name, immutable for the life of the wallet.
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// The price point that priced this wallet's [purchases]($e/Wallet%20Purchases/createWalletPurchase), set on create and immutable afterward. Defaults to the Wallet Product's default price point; `null` if the Wallet Product has none and none was given on create.
        /// </summary>
        [JsonProperty("price_point_id")]
        public int? PricePointId
        {
            get
            {
                return this.pricePointId;
            }

            set
            {
                this.shouldSerialize["price_point_id"] = true;
                this.pricePointId = value;
            }
        }

        /// <summary>
        /// What the wallet can spend now, encoded as a decimal string to avoid floating-point precision loss. This is the number to enforce against. For a metered wallet, it includes usage not yet posted to the ledger, through `metered_through_at`, but only in the response from [Read Wallet]($e/Wallets/readWallet); every other response (list, create, update, archive) reports the balance as of the last ledger write, equal to `posted_balance`, even for a metered wallet. The grants' `remaining` follow this figure, so they add up to it whenever it is zero or more.
        /// </summary>
        [JsonProperty("balance", NullValueHandling = NullValueHandling.Ignore)]
        public string Balance { get; set; }

        /// <summary>
        /// The balance from written ledger entries alone: grants funded, minus debits written to the ledger, as a decimal string. Always present, also for a wallet with no meter. It equals `balance` wherever no live metered balance is computed: list, create, update, and archive responses, an unlinked or archived wallet, and a read where `metered_stale` is `true`. Only an active, metered wallet read through [Read Wallet]($e/Wallets/readWallet), with `metered_stale` not `true`, can have a `balance` below its `posted_balance`. It stays exact when `metered_stale` is `true`. Reconcile the transactions list (`balance_after`) against this figure, not against `balance`.
        /// </summary>
        [JsonProperty("posted_balance", NullValueHandling = NullValueHandling.Ignore)]
        public string PostedBalance { get; set; }

        /// <summary>
        /// The metering meter this wallet is paired with, or `null` for a wallet with no meter. Set on create and immutable afterward.
        /// </summary>
        [JsonProperty("meter")]
        public Models.Meter Meter
        {
            get
            {
                return this.meter;
            }

            set
            {
                this.shouldSerialize["meter"] = true;
                this.meter = value;
            }
        }

        /// <summary>
        /// The point up to which live meter usage has been factored into `balance`. Populated only in the response from [Read Wallet]($e/Wallets/readWallet), for an active, metered wallet on a site with metered consumption enabled; `null` everywhere else, including list, create, update, and archive responses for the same wallet.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("metered_through_at")]
        public DateTimeOffset? MeteredThroughAt
        {
            get
            {
                return this.meteredThroughAt;
            }

            set
            {
                this.shouldSerialize["metered_through_at"] = true;
                this.meteredThroughAt = value;
            }
        }

        /// <summary>
        /// How many seconds to wait before re-reading `balance` to see usage past `metered_through_at`. Same availability as `metered_through_at`.
        /// </summary>
        [JsonProperty("metered_recheck_after_seconds")]
        public int? MeteredRecheckAfterSeconds
        {
            get
            {
                return this.meteredRecheckAfterSeconds;
            }

            set
            {
                this.shouldSerialize["metered_recheck_after_seconds"] = true;
                this.meteredRecheckAfterSeconds = value;
            }
        }

        /// <summary>
        /// `true` when live usage could not be read fresh and `balance` reflects an earlier snapshot. Same availability as `metered_through_at`.
        /// </summary>
        [JsonProperty("metered_stale")]
        public bool? MeteredStale
        {
            get
            {
                return this.meteredStale;
            }

            set
            {
                this.shouldSerialize["metered_stale"] = true;
                this.meteredStale = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletStatus? Status { get; set; }

        /// <summary>
        /// What happens when a debit would take the wallet below zero. Known values: `hard_stop` (the only value you can set today). More values are expected over time, so treat this as an open string and don't fail on one you don't recognize. At the zero boundary, `hard_stop` behaves as set by `hard_stop_overflow`.
        /// </summary>
        [JsonProperty("depletion_policy", NullValueHandling = NullValueHandling.Ignore)]
        public string DepletionPolicy { get; set; }

        /// <summary>
        /// Behavior at the hard-stop boundary. `discard` drains the wallet to zero and rejects the excess (the default). `allow_negative` deducts the full amount, letting the balance go negative. The excess past the wallet's grants is booked as an overdraft ledger row with `grant_id` set to `null`.
        /// </summary>
        [JsonProperty("hard_stop_overflow", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletHardStopOverflow? HardStopOverflow { get; set; }

        /// <summary>
        /// How the wallet came to exist. `manual` for a wallet created directly with [Create Wallet]($e/Wallets/createWallet). `feature` for a wallet auto-provisioned because a subscription resolved a usage-limit entitlement whose Feature has `wallet_behavior` configured.
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletOrigin? Origin { get; set; }

        /// <summary>
        /// The key of the Feature this wallet was provisioned for, when `origin` is `feature`. `null` for a `manual` wallet.
        /// </summary>
        [JsonProperty("feature_key")]
        public string FeatureKey
        {
            get
            {
                return this.featureKey;
            }

            set
            {
                this.shouldSerialize["feature_key"] = true;
                this.featureKey = value;
            }
        }

        /// <summary>
        /// Every grant on the wallet, including ones already spent or expired, in drain order (the order debits would consume the still-open ones in): the soonest-expiring grant first, evergreen grants last.
        /// </summary>
        [JsonProperty("grants", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WalletGrant> Grants { get; set; }

        /// <summary>
        /// The wallet's automatic funding schedules, if any. Empty for a `manual` wallet with no funding entitlement. A wallet funds automatically when it's provisioned from a Feature with `wallet_behavior` configured; see [the Wallets concept guide](page:introduction/basic-concepts/wallets#provisioning-a-wallet-from-a-feature).
        /// </summary>
        [JsonProperty("recurring_funding", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.WalletRecurringFunding> RecurringFunding { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Gets or sets UpdatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Wallet : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetName()
        {
            this.shouldSerialize["name"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetPricePointId()
        {
            this.shouldSerialize["price_point_id"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeter()
        {
            this.shouldSerialize["meter"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeteredThroughAt()
        {
            this.shouldSerialize["metered_through_at"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeteredRecheckAfterSeconds()
        {
            this.shouldSerialize["metered_recheck_after_seconds"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetMeteredStale()
        {
            this.shouldSerialize["metered_stale"] = false;
        }
        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetFeatureKey()
        {
            this.shouldSerialize["feature_key"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeName()
        {
            return this.shouldSerialize["name"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePricePointId()
        {
            return this.shouldSerialize["price_point_id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeter()
        {
            return this.shouldSerialize["meter"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeteredThroughAt()
        {
            return this.shouldSerialize["metered_through_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeteredRecheckAfterSeconds()
        {
            return this.shouldSerialize["metered_recheck_after_seconds"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMeteredStale()
        {
            return this.shouldSerialize["metered_stale"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFeatureKey()
        {
            return this.shouldSerialize["feature_key"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Wallet other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.OwnerType == null && other.OwnerType == null ||
                 this.OwnerType?.Equals(other.OwnerType) == true) &&
                (this.OwnerId == null && other.OwnerId == null ||
                 this.OwnerId?.Equals(other.OwnerId) == true) &&
                (this.Name == null && other.Name == null ||
                 this.Name?.Equals(other.Name) == true) &&
                (this.WalletProductId == null && other.WalletProductId == null ||
                 this.WalletProductId?.Equals(other.WalletProductId) == true) &&
                (this.WalletProductName == null && other.WalletProductName == null ||
                 this.WalletProductName?.Equals(other.WalletProductName) == true) &&
                (this.Unit == null && other.Unit == null ||
                 this.Unit?.Equals(other.Unit) == true) &&
                (this.PricePointId == null && other.PricePointId == null ||
                 this.PricePointId?.Equals(other.PricePointId) == true) &&
                (this.Balance == null && other.Balance == null ||
                 this.Balance?.Equals(other.Balance) == true) &&
                (this.PostedBalance == null && other.PostedBalance == null ||
                 this.PostedBalance?.Equals(other.PostedBalance) == true) &&
                (this.Meter == null && other.Meter == null ||
                 this.Meter?.Equals(other.Meter) == true) &&
                (this.MeteredThroughAt == null && other.MeteredThroughAt == null ||
                 this.MeteredThroughAt?.Equals(other.MeteredThroughAt) == true) &&
                (this.MeteredRecheckAfterSeconds == null && other.MeteredRecheckAfterSeconds == null ||
                 this.MeteredRecheckAfterSeconds?.Equals(other.MeteredRecheckAfterSeconds) == true) &&
                (this.MeteredStale == null && other.MeteredStale == null ||
                 this.MeteredStale?.Equals(other.MeteredStale) == true) &&
                (this.Status == null && other.Status == null ||
                 this.Status?.Equals(other.Status) == true) &&
                (this.DepletionPolicy == null && other.DepletionPolicy == null ||
                 this.DepletionPolicy?.Equals(other.DepletionPolicy) == true) &&
                (this.HardStopOverflow == null && other.HardStopOverflow == null ||
                 this.HardStopOverflow?.Equals(other.HardStopOverflow) == true) &&
                (this.Origin == null && other.Origin == null ||
                 this.Origin?.Equals(other.Origin) == true) &&
                (this.FeatureKey == null && other.FeatureKey == null ||
                 this.FeatureKey?.Equals(other.FeatureKey) == true) &&
                (this.Grants == null && other.Grants == null ||
                 this.Grants?.Equals(other.Grants) == true) &&
                (this.RecurringFunding == null && other.RecurringFunding == null ||
                 this.RecurringFunding?.Equals(other.RecurringFunding) == true) &&
                (this.CreatedAt == null && other.CreatedAt == null ||
                 this.CreatedAt?.Equals(other.CreatedAt) == true) &&
                (this.UpdatedAt == null && other.UpdatedAt == null ||
                 this.UpdatedAt?.Equals(other.UpdatedAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"OwnerType = {(this.OwnerType == null ? "null" : this.OwnerType.ToString())}");
            toStringOutput.Add($"OwnerId = {(this.OwnerId == null ? "null" : this.OwnerId.ToString())}");
            toStringOutput.Add($"Name = {this.Name ?? "null"}");
            toStringOutput.Add($"WalletProductId = {(this.WalletProductId == null ? "null" : this.WalletProductId.ToString())}");
            toStringOutput.Add($"WalletProductName = {this.WalletProductName ?? "null"}");
            toStringOutput.Add($"Unit = {this.Unit ?? "null"}");
            toStringOutput.Add($"PricePointId = {(this.PricePointId == null ? "null" : this.PricePointId.ToString())}");
            toStringOutput.Add($"Balance = {this.Balance ?? "null"}");
            toStringOutput.Add($"PostedBalance = {this.PostedBalance ?? "null"}");
            toStringOutput.Add($"Meter = {(this.Meter == null ? "null" : this.Meter.ToString())}");
            toStringOutput.Add($"MeteredThroughAt = {(this.MeteredThroughAt == null ? "null" : this.MeteredThroughAt.ToString())}");
            toStringOutput.Add($"MeteredRecheckAfterSeconds = {(this.MeteredRecheckAfterSeconds == null ? "null" : this.MeteredRecheckAfterSeconds.ToString())}");
            toStringOutput.Add($"MeteredStale = {(this.MeteredStale == null ? "null" : this.MeteredStale.ToString())}");
            toStringOutput.Add($"Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"DepletionPolicy = {this.DepletionPolicy ?? "null"}");
            toStringOutput.Add($"HardStopOverflow = {(this.HardStopOverflow == null ? "null" : this.HardStopOverflow.ToString())}");
            toStringOutput.Add($"Origin = {(this.Origin == null ? "null" : this.Origin.ToString())}");
            toStringOutput.Add($"FeatureKey = {this.FeatureKey ?? "null"}");
            toStringOutput.Add($"Grants = {(this.Grants == null ? "null" : $"[{string.Join(", ", this.Grants)} ]")}");
            toStringOutput.Add($"RecurringFunding = {(this.RecurringFunding == null ? "null" : $"[{string.Join(", ", this.RecurringFunding)} ]")}");
            toStringOutput.Add($"CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}