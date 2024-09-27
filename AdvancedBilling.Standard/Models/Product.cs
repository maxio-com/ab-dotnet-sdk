// <copyright file="Product.cs" company="APIMatic">
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
    /// Product.
    /// </summary>
    public class Product : BaseModel
    {
        private string handle;
        private string description;
        private string accountingCode;
        private int? expirationInterval;
        private Models.ExpirationIntervalUnit? expirationIntervalUnit;
        private long? initialChargeInCents;
        private long? trialPriceInCents;
        private int? trialInterval;
        private Models.IntervalUnit? trialIntervalUnit;
        private DateTimeOffset? archivedAt;
        private string returnParams;
        private string updateReturnUrl;
        private bool? initialChargeAfterTrial;
        private string updateReturnParams;
        private string taxCode;
        private bool? useSiteExchangeRate;
        private string itemCategory;
        private string productPricePointHandle;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "handle", false },
            { "description", false },
            { "accounting_code", false },
            { "expiration_interval", false },
            { "expiration_interval_unit", false },
            { "initial_charge_in_cents", false },
            { "trial_price_in_cents", false },
            { "trial_interval", false },
            { "trial_interval_unit", false },
            { "archived_at", false },
            { "return_params", false },
            { "update_return_url", false },
            { "initial_charge_after_trial", false },
            { "update_return_params", false },
            { "tax_code", false },
            { "use_site_exchange_rate", false },
            { "item_category", false },
            { "product_price_point_handle", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        public Product()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="handle">handle.</param>
        /// <param name="description">description.</param>
        /// <param name="accountingCode">accounting_code.</param>
        /// <param name="requestCreditCard">request_credit_card.</param>
        /// <param name="expirationInterval">expiration_interval.</param>
        /// <param name="expirationIntervalUnit">expiration_interval_unit.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="updatedAt">updated_at.</param>
        /// <param name="priceInCents">price_in_cents.</param>
        /// <param name="interval">interval.</param>
        /// <param name="intervalUnit">interval_unit.</param>
        /// <param name="initialChargeInCents">initial_charge_in_cents.</param>
        /// <param name="trialPriceInCents">trial_price_in_cents.</param>
        /// <param name="trialInterval">trial_interval.</param>
        /// <param name="trialIntervalUnit">trial_interval_unit.</param>
        /// <param name="archivedAt">archived_at.</param>
        /// <param name="requireCreditCard">require_credit_card.</param>
        /// <param name="returnParams">return_params.</param>
        /// <param name="taxable">taxable.</param>
        /// <param name="updateReturnUrl">update_return_url.</param>
        /// <param name="initialChargeAfterTrial">initial_charge_after_trial.</param>
        /// <param name="versionNumber">version_number.</param>
        /// <param name="updateReturnParams">update_return_params.</param>
        /// <param name="productFamily">product_family.</param>
        /// <param name="publicSignupPages">public_signup_pages.</param>
        /// <param name="productPricePointName">product_price_point_name.</param>
        /// <param name="requestBillingAddress">request_billing_address.</param>
        /// <param name="requireBillingAddress">require_billing_address.</param>
        /// <param name="requireShippingAddress">require_shipping_address.</param>
        /// <param name="taxCode">tax_code.</param>
        /// <param name="defaultProductPricePointId">default_product_price_point_id.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        /// <param name="itemCategory">item_category.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        public Product(
            int? id = null,
            string name = null,
            string handle = null,
            string description = null,
            string accountingCode = null,
            bool? requestCreditCard = null,
            int? expirationInterval = null,
            Models.ExpirationIntervalUnit? expirationIntervalUnit = null,
            DateTimeOffset? createdAt = null,
            DateTimeOffset? updatedAt = null,
            long? priceInCents = null,
            int? interval = null,
            Models.IntervalUnit? intervalUnit = null,
            long? initialChargeInCents = null,
            long? trialPriceInCents = null,
            int? trialInterval = null,
            Models.IntervalUnit? trialIntervalUnit = null,
            DateTimeOffset? archivedAt = null,
            bool? requireCreditCard = null,
            string returnParams = null,
            bool? taxable = null,
            string updateReturnUrl = null,
            bool? initialChargeAfterTrial = null,
            int? versionNumber = null,
            string updateReturnParams = null,
            Models.ProductFamily productFamily = null,
            List<Models.PublicSignupPage> publicSignupPages = null,
            string productPricePointName = null,
            bool? requestBillingAddress = null,
            bool? requireBillingAddress = null,
            bool? requireShippingAddress = null,
            string taxCode = null,
            int? defaultProductPricePointId = null,
            bool? useSiteExchangeRate = null,
            string itemCategory = null,
            int? productPricePointId = null,
            string productPricePointHandle = null)
        {
            this.Id = id;
            this.Name = name;
            if (handle != null)
            {
                this.Handle = handle;
            }

            if (description != null)
            {
                this.Description = description;
            }

            if (accountingCode != null)
            {
                this.AccountingCode = accountingCode;
            }

            this.RequestCreditCard = requestCreditCard;
            if (expirationInterval != null)
            {
                this.ExpirationInterval = expirationInterval;
            }

            if (expirationIntervalUnit != null)
            {
                this.ExpirationIntervalUnit = expirationIntervalUnit;
            }

            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.PriceInCents = priceInCents;
            this.Interval = interval;
            this.IntervalUnit = intervalUnit;
            if (initialChargeInCents != null)
            {
                this.InitialChargeInCents = initialChargeInCents;
            }

            if (trialPriceInCents != null)
            {
                this.TrialPriceInCents = trialPriceInCents;
            }

            if (trialInterval != null)
            {
                this.TrialInterval = trialInterval;
            }

            if (trialIntervalUnit != null)
            {
                this.TrialIntervalUnit = trialIntervalUnit;
            }

            if (archivedAt != null)
            {
                this.ArchivedAt = archivedAt;
            }

            this.RequireCreditCard = requireCreditCard;
            if (returnParams != null)
            {
                this.ReturnParams = returnParams;
            }

            this.Taxable = taxable;
            if (updateReturnUrl != null)
            {
                this.UpdateReturnUrl = updateReturnUrl;
            }

            if (initialChargeAfterTrial != null)
            {
                this.InitialChargeAfterTrial = initialChargeAfterTrial;
            }

            this.VersionNumber = versionNumber;
            if (updateReturnParams != null)
            {
                this.UpdateReturnParams = updateReturnParams;
            }

            this.ProductFamily = productFamily;
            this.PublicSignupPages = publicSignupPages;
            this.ProductPricePointName = productPricePointName;
            this.RequestBillingAddress = requestBillingAddress;
            this.RequireBillingAddress = requireBillingAddress;
            this.RequireShippingAddress = requireShippingAddress;
            if (taxCode != null)
            {
                this.TaxCode = taxCode;
            }

            this.DefaultProductPricePointId = defaultProductPricePointId;
            if (useSiteExchangeRate != null)
            {
                this.UseSiteExchangeRate = useSiteExchangeRate;
            }

            if (itemCategory != null)
            {
                this.ItemCategory = itemCategory;
            }

            this.ProductPricePointId = productPricePointId;
            if (productPricePointHandle != null)
            {
                this.ProductPricePointHandle = productPricePointHandle;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The product name
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// The product API handle
        /// </summary>
        [JsonProperty("handle")]
        public string Handle
        {
            get
            {
                return this.handle;
            }

            set
            {
                this.shouldSerialize["handle"] = true;
                this.handle = value;
            }
        }

        /// <summary>
        /// The product description
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
        /// E.g. Internal ID or SKU Number
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
        /// Deprecated value that can be ignored unless you have legacy hosted pages. For Public Signup Page users, please read this attribute from under the signup page.
        /// </summary>
        [JsonProperty("request_credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestCreditCard { get; set; }

        /// <summary>
        /// A numerical interval for the length a subscription to this product will run before it expires. See the description of interval for a description of how this value is coupled with an interval unit to calculate the full interval
        /// </summary>
        [JsonProperty("expiration_interval")]
        public int? ExpirationInterval
        {
            get
            {
                return this.expirationInterval;
            }

            set
            {
                this.shouldSerialize["expiration_interval"] = true;
                this.expirationInterval = value;
            }
        }

        /// <summary>
        /// A string representing the expiration interval unit for this product, either month, day or never
        /// </summary>
        [JsonProperty("expiration_interval_unit")]
        public Models.ExpirationIntervalUnit? ExpirationIntervalUnit
        {
            get
            {
                return this.expirationIntervalUnit;
            }

            set
            {
                this.shouldSerialize["expiration_interval_unit"] = true;
                this.expirationIntervalUnit = value;
            }
        }

        /// <summary>
        /// Timestamp indicating when this product was created
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp indicating when this product was last updated
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdatedAt { get; set; }

        /// <summary>
        /// The product price, in integer cents
        /// </summary>
        [JsonProperty("price_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? PriceInCents { get; set; }

        /// <summary>
        /// The numerical interval. i.e. an interval of ‘30’ coupled with an interval_unit of day would mean this product would renew every 30 days
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// A string representing the interval unit for this product, either month or day
        /// </summary>
        [JsonProperty("interval_unit", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IntervalUnit? IntervalUnit { get; set; }

        /// <summary>
        /// The up front charge you have specified.
        /// </summary>
        [JsonProperty("initial_charge_in_cents")]
        public long? InitialChargeInCents
        {
            get
            {
                return this.initialChargeInCents;
            }

            set
            {
                this.shouldSerialize["initial_charge_in_cents"] = true;
                this.initialChargeInCents = value;
            }
        }

        /// <summary>
        /// The price of the trial period for a subscription to this product, in integer cents.
        /// </summary>
        [JsonProperty("trial_price_in_cents")]
        public long? TrialPriceInCents
        {
            get
            {
                return this.trialPriceInCents;
            }

            set
            {
                this.shouldSerialize["trial_price_in_cents"] = true;
                this.trialPriceInCents = value;
            }
        }

        /// <summary>
        /// A numerical interval for the length of the trial period of a subscription to this product. See the description of interval for a description of how this value is coupled with an interval unit to calculate the full interval
        /// </summary>
        [JsonProperty("trial_interval")]
        public int? TrialInterval
        {
            get
            {
                return this.trialInterval;
            }

            set
            {
                this.shouldSerialize["trial_interval"] = true;
                this.trialInterval = value;
            }
        }

        /// <summary>
        /// A string representing the trial interval unit for this product, either month or day
        /// </summary>
        [JsonProperty("trial_interval_unit")]
        public Models.IntervalUnit? TrialIntervalUnit
        {
            get
            {
                return this.trialIntervalUnit;
            }

            set
            {
                this.shouldSerialize["trial_interval_unit"] = true;
                this.trialIntervalUnit = value;
            }
        }

        /// <summary>
        /// Timestamp indicating when this product was archived
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("archived_at")]
        public DateTimeOffset? ArchivedAt
        {
            get
            {
                return this.archivedAt;
            }

            set
            {
                this.shouldSerialize["archived_at"] = true;
                this.archivedAt = value;
            }
        }

        /// <summary>
        /// Boolean that controls whether a payment profile is required to be entered for customers wishing to sign up on this product.
        /// </summary>
        [JsonProperty("require_credit_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireCreditCard { get; set; }

        /// <summary>
        /// Gets or sets ReturnParams.
        /// </summary>
        [JsonProperty("return_params")]
        public string ReturnParams
        {
            get
            {
                return this.returnParams;
            }

            set
            {
                this.shouldSerialize["return_params"] = true;
                this.returnParams = value;
            }
        }

        /// <summary>
        /// Gets or sets Taxable.
        /// </summary>
        [JsonProperty("taxable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// The url to which a customer will be returned after a successful account update
        /// </summary>
        [JsonProperty("update_return_url")]
        public string UpdateReturnUrl
        {
            get
            {
                return this.updateReturnUrl;
            }

            set
            {
                this.shouldSerialize["update_return_url"] = true;
                this.updateReturnUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets InitialChargeAfterTrial.
        /// </summary>
        [JsonProperty("initial_charge_after_trial")]
        public bool? InitialChargeAfterTrial
        {
            get
            {
                return this.initialChargeAfterTrial;
            }

            set
            {
                this.shouldSerialize["initial_charge_after_trial"] = true;
                this.initialChargeAfterTrial = value;
            }
        }

        /// <summary>
        /// The version of the product
        /// </summary>
        [JsonProperty("version_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionNumber { get; set; }

        /// <summary>
        /// The parameters will append to the url after a successful account update. See [help documentation](https://help.chargify.com/products/product-editing.html#return-parameters-after-account-update)
        /// </summary>
        [JsonProperty("update_return_params")]
        public string UpdateReturnParams
        {
            get
            {
                return this.updateReturnParams;
            }

            set
            {
                this.shouldSerialize["update_return_params"] = true;
                this.updateReturnParams = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductFamily.
        /// </summary>
        [JsonProperty("product_family", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ProductFamily ProductFamily { get; set; }

        /// <summary>
        /// Gets or sets PublicSignupPages.
        /// </summary>
        [JsonProperty("public_signup_pages", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PublicSignupPage> PublicSignupPages { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointName.
        /// </summary>
        [JsonProperty("product_price_point_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointName { get; set; }

        /// <summary>
        /// A boolean indicating whether to request a billing address on any Self-Service Pages that are used by subscribers of this product.
        /// </summary>
        [JsonProperty("request_billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestBillingAddress { get; set; }

        /// <summary>
        /// A boolean indicating whether a billing address is required to add a payment profile, especially at signup.
        /// </summary>
        [JsonProperty("require_billing_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireBillingAddress { get; set; }

        /// <summary>
        /// A boolean indicating whether a shipping address is required for the customer, especially at signup.
        /// </summary>
        [JsonProperty("require_shipping_address", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireShippingAddress { get; set; }

        /// <summary>
        /// A string representing the tax code related to the product type. This is especially important when using the Avalara service to tax based on locale. This attribute has a max length of 10 characters.
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
        /// Gets or sets DefaultProductPricePointId.
        /// </summary>
        [JsonProperty("default_product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets UseSiteExchangeRate.
        /// </summary>
        [JsonProperty("use_site_exchange_rate")]
        public bool? UseSiteExchangeRate
        {
            get
            {
                return this.useSiteExchangeRate;
            }

            set
            {
                this.shouldSerialize["use_site_exchange_rate"] = true;
                this.useSiteExchangeRate = value;
            }
        }

        /// <summary>
        /// One of the following: Business Software, Consumer Software, Digital Services, Physical Goods, Other
        /// </summary>
        [JsonProperty("item_category")]
        public string ItemCategory
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
        /// Gets or sets ProductPricePointId.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// Gets or sets ProductPricePointHandle.
        /// </summary>
        [JsonProperty("product_price_point_handle")]
        public string ProductPricePointHandle
        {
            get
            {
                return this.productPricePointHandle;
            }

            set
            {
                this.shouldSerialize["product_price_point_handle"] = true;
                this.productPricePointHandle = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Product : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHandle()
        {
            this.shouldSerialize["handle"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountingCode()
        {
            this.shouldSerialize["accounting_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpirationInterval()
        {
            this.shouldSerialize["expiration_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpirationIntervalUnit()
        {
            this.shouldSerialize["expiration_interval_unit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInitialChargeInCents()
        {
            this.shouldSerialize["initial_charge_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialPriceInCents()
        {
            this.shouldSerialize["trial_price_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialInterval()
        {
            this.shouldSerialize["trial_interval"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTrialIntervalUnit()
        {
            this.shouldSerialize["trial_interval_unit"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetArchivedAt()
        {
            this.shouldSerialize["archived_at"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReturnParams()
        {
            this.shouldSerialize["return_params"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpdateReturnUrl()
        {
            this.shouldSerialize["update_return_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInitialChargeAfterTrial()
        {
            this.shouldSerialize["initial_charge_after_trial"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUpdateReturnParams()
        {
            this.shouldSerialize["update_return_params"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTaxCode()
        {
            this.shouldSerialize["tax_code"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUseSiteExchangeRate()
        {
            this.shouldSerialize["use_site_exchange_rate"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetItemCategory()
        {
            this.shouldSerialize["item_category"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductPricePointHandle()
        {
            this.shouldSerialize["product_price_point_handle"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHandle()
        {
            return this.shouldSerialize["handle"];
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
        public bool ShouldSerializeExpirationInterval()
        {
            return this.shouldSerialize["expiration_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpirationIntervalUnit()
        {
            return this.shouldSerialize["expiration_interval_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialChargeInCents()
        {
            return this.shouldSerialize["initial_charge_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialPriceInCents()
        {
            return this.shouldSerialize["trial_price_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialInterval()
        {
            return this.shouldSerialize["trial_interval"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTrialIntervalUnit()
        {
            return this.shouldSerialize["trial_interval_unit"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeArchivedAt()
        {
            return this.shouldSerialize["archived_at"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReturnParams()
        {
            return this.shouldSerialize["return_params"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdateReturnUrl()
        {
            return this.shouldSerialize["update_return_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInitialChargeAfterTrial()
        {
            return this.shouldSerialize["initial_charge_after_trial"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUpdateReturnParams()
        {
            return this.shouldSerialize["update_return_params"];
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
        public bool ShouldSerializeUseSiteExchangeRate()
        {
            return this.shouldSerialize["use_site_exchange_rate"];
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
        public bool ShouldSerializeProductPricePointHandle()
        {
            return this.shouldSerialize["product_price_point_handle"];
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
            return obj is Product other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Handle == null && other.Handle == null) || (this.Handle?.Equals(other.Handle) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.AccountingCode == null && other.AccountingCode == null) || (this.AccountingCode?.Equals(other.AccountingCode) == true)) &&
                ((this.RequestCreditCard == null && other.RequestCreditCard == null) || (this.RequestCreditCard?.Equals(other.RequestCreditCard) == true)) &&
                ((this.ExpirationInterval == null && other.ExpirationInterval == null) || (this.ExpirationInterval?.Equals(other.ExpirationInterval) == true)) &&
                ((this.ExpirationIntervalUnit == null && other.ExpirationIntervalUnit == null) || (this.ExpirationIntervalUnit?.Equals(other.ExpirationIntervalUnit) == true)) &&
                ((this.CreatedAt == null && other.CreatedAt == null) || (this.CreatedAt?.Equals(other.CreatedAt) == true)) &&
                ((this.UpdatedAt == null && other.UpdatedAt == null) || (this.UpdatedAt?.Equals(other.UpdatedAt) == true)) &&
                ((this.PriceInCents == null && other.PriceInCents == null) || (this.PriceInCents?.Equals(other.PriceInCents) == true)) &&
                ((this.Interval == null && other.Interval == null) || (this.Interval?.Equals(other.Interval) == true)) &&
                ((this.IntervalUnit == null && other.IntervalUnit == null) || (this.IntervalUnit?.Equals(other.IntervalUnit) == true)) &&
                ((this.InitialChargeInCents == null && other.InitialChargeInCents == null) || (this.InitialChargeInCents?.Equals(other.InitialChargeInCents) == true)) &&
                ((this.TrialPriceInCents == null && other.TrialPriceInCents == null) || (this.TrialPriceInCents?.Equals(other.TrialPriceInCents) == true)) &&
                ((this.TrialInterval == null && other.TrialInterval == null) || (this.TrialInterval?.Equals(other.TrialInterval) == true)) &&
                ((this.TrialIntervalUnit == null && other.TrialIntervalUnit == null) || (this.TrialIntervalUnit?.Equals(other.TrialIntervalUnit) == true)) &&
                ((this.ArchivedAt == null && other.ArchivedAt == null) || (this.ArchivedAt?.Equals(other.ArchivedAt) == true)) &&
                ((this.RequireCreditCard == null && other.RequireCreditCard == null) || (this.RequireCreditCard?.Equals(other.RequireCreditCard) == true)) &&
                ((this.ReturnParams == null && other.ReturnParams == null) || (this.ReturnParams?.Equals(other.ReturnParams) == true)) &&
                ((this.Taxable == null && other.Taxable == null) || (this.Taxable?.Equals(other.Taxable) == true)) &&
                ((this.UpdateReturnUrl == null && other.UpdateReturnUrl == null) || (this.UpdateReturnUrl?.Equals(other.UpdateReturnUrl) == true)) &&
                ((this.InitialChargeAfterTrial == null && other.InitialChargeAfterTrial == null) || (this.InitialChargeAfterTrial?.Equals(other.InitialChargeAfterTrial) == true)) &&
                ((this.VersionNumber == null && other.VersionNumber == null) || (this.VersionNumber?.Equals(other.VersionNumber) == true)) &&
                ((this.UpdateReturnParams == null && other.UpdateReturnParams == null) || (this.UpdateReturnParams?.Equals(other.UpdateReturnParams) == true)) &&
                ((this.ProductFamily == null && other.ProductFamily == null) || (this.ProductFamily?.Equals(other.ProductFamily) == true)) &&
                ((this.PublicSignupPages == null && other.PublicSignupPages == null) || (this.PublicSignupPages?.Equals(other.PublicSignupPages) == true)) &&
                ((this.ProductPricePointName == null && other.ProductPricePointName == null) || (this.ProductPricePointName?.Equals(other.ProductPricePointName) == true)) &&
                ((this.RequestBillingAddress == null && other.RequestBillingAddress == null) || (this.RequestBillingAddress?.Equals(other.RequestBillingAddress) == true)) &&
                ((this.RequireBillingAddress == null && other.RequireBillingAddress == null) || (this.RequireBillingAddress?.Equals(other.RequireBillingAddress) == true)) &&
                ((this.RequireShippingAddress == null && other.RequireShippingAddress == null) || (this.RequireShippingAddress?.Equals(other.RequireShippingAddress) == true)) &&
                ((this.TaxCode == null && other.TaxCode == null) || (this.TaxCode?.Equals(other.TaxCode) == true)) &&
                ((this.DefaultProductPricePointId == null && other.DefaultProductPricePointId == null) || (this.DefaultProductPricePointId?.Equals(other.DefaultProductPricePointId) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true)) &&
                ((this.ItemCategory == null && other.ItemCategory == null) || (this.ItemCategory?.Equals(other.ItemCategory) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.ProductPricePointHandle == null && other.ProductPricePointHandle == null) || (this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Handle = {(this.Handle == null ? "null" : this.Handle)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.AccountingCode = {(this.AccountingCode == null ? "null" : this.AccountingCode)}");
            toStringOutput.Add($"this.RequestCreditCard = {(this.RequestCreditCard == null ? "null" : this.RequestCreditCard.ToString())}");
            toStringOutput.Add($"this.ExpirationInterval = {(this.ExpirationInterval == null ? "null" : this.ExpirationInterval.ToString())}");
            toStringOutput.Add($"this.ExpirationIntervalUnit = {(this.ExpirationIntervalUnit == null ? "null" : this.ExpirationIntervalUnit.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {(this.CreatedAt == null ? "null" : this.CreatedAt.ToString())}");
            toStringOutput.Add($"this.UpdatedAt = {(this.UpdatedAt == null ? "null" : this.UpdatedAt.ToString())}");
            toStringOutput.Add($"this.PriceInCents = {(this.PriceInCents == null ? "null" : this.PriceInCents.ToString())}");
            toStringOutput.Add($"this.Interval = {(this.Interval == null ? "null" : this.Interval.ToString())}");
            toStringOutput.Add($"this.IntervalUnit = {(this.IntervalUnit == null ? "null" : this.IntervalUnit.ToString())}");
            toStringOutput.Add($"this.InitialChargeInCents = {(this.InitialChargeInCents == null ? "null" : this.InitialChargeInCents.ToString())}");
            toStringOutput.Add($"this.TrialPriceInCents = {(this.TrialPriceInCents == null ? "null" : this.TrialPriceInCents.ToString())}");
            toStringOutput.Add($"this.TrialInterval = {(this.TrialInterval == null ? "null" : this.TrialInterval.ToString())}");
            toStringOutput.Add($"this.TrialIntervalUnit = {(this.TrialIntervalUnit == null ? "null" : this.TrialIntervalUnit.ToString())}");
            toStringOutput.Add($"this.ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");
            toStringOutput.Add($"this.RequireCreditCard = {(this.RequireCreditCard == null ? "null" : this.RequireCreditCard.ToString())}");
            toStringOutput.Add($"this.ReturnParams = {(this.ReturnParams == null ? "null" : this.ReturnParams)}");
            toStringOutput.Add($"this.Taxable = {(this.Taxable == null ? "null" : this.Taxable.ToString())}");
            toStringOutput.Add($"this.UpdateReturnUrl = {(this.UpdateReturnUrl == null ? "null" : this.UpdateReturnUrl)}");
            toStringOutput.Add($"this.InitialChargeAfterTrial = {(this.InitialChargeAfterTrial == null ? "null" : this.InitialChargeAfterTrial.ToString())}");
            toStringOutput.Add($"this.VersionNumber = {(this.VersionNumber == null ? "null" : this.VersionNumber.ToString())}");
            toStringOutput.Add($"this.UpdateReturnParams = {(this.UpdateReturnParams == null ? "null" : this.UpdateReturnParams)}");
            toStringOutput.Add($"this.ProductFamily = {(this.ProductFamily == null ? "null" : this.ProductFamily.ToString())}");
            toStringOutput.Add($"this.PublicSignupPages = {(this.PublicSignupPages == null ? "null" : $"[{string.Join(", ", this.PublicSignupPages)} ]")}");
            toStringOutput.Add($"this.ProductPricePointName = {(this.ProductPricePointName == null ? "null" : this.ProductPricePointName)}");
            toStringOutput.Add($"this.RequestBillingAddress = {(this.RequestBillingAddress == null ? "null" : this.RequestBillingAddress.ToString())}");
            toStringOutput.Add($"this.RequireBillingAddress = {(this.RequireBillingAddress == null ? "null" : this.RequireBillingAddress.ToString())}");
            toStringOutput.Add($"this.RequireShippingAddress = {(this.RequireShippingAddress == null ? "null" : this.RequireShippingAddress.ToString())}");
            toStringOutput.Add($"this.TaxCode = {(this.TaxCode == null ? "null" : this.TaxCode)}");
            toStringOutput.Add($"this.DefaultProductPricePointId = {(this.DefaultProductPricePointId == null ? "null" : this.DefaultProductPricePointId.ToString())}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");
            toStringOutput.Add($"this.ItemCategory = {(this.ItemCategory == null ? "null" : this.ItemCategory)}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointHandle = {(this.ProductPricePointHandle == null ? "null" : this.ProductPricePointHandle)}");

            base.ToString(toStringOutput);
        }
    }
}