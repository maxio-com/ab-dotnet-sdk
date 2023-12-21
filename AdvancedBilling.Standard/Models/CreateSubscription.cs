// <copyright file="CreateSubscription.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// CreateSubscription.
    /// </summary>
    public class CreateSubscription
    {
        private bool? dunningCommunicationDelayEnabled;
        private string dunningCommunicationDelayTimeZone;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "dunning_communication_delay_enabled", true },
            { "dunning_communication_delay_time_zone", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscription"/> class.
        /// </summary>
        public CreateSubscription()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscription"/> class.
        /// </summary>
        /// <param name="productHandle">product_handle.</param>
        /// <param name="productId">product_id.</param>
        /// <param name="productPricePointHandle">product_price_point_handle.</param>
        /// <param name="productPricePointId">product_price_point_id.</param>
        /// <param name="customPrice">custom_price.</param>
        /// <param name="couponCode">coupon_code.</param>
        /// <param name="couponCodes">coupon_codes.</param>
        /// <param name="paymentCollectionMethod">payment_collection_method.</param>
        /// <param name="receivesInvoiceEmails">receives_invoice_emails.</param>
        /// <param name="netTerms">net_terms.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="nextBillingAt">next_billing_at.</param>
        /// <param name="initialBillingAt">initial_billing_at.</param>
        /// <param name="storedCredentialTransactionId">stored_credential_transaction_id.</param>
        /// <param name="salesRepId">sales_rep_id.</param>
        /// <param name="paymentProfileId">payment_profile_id.</param>
        /// <param name="reference">reference.</param>
        /// <param name="customerAttributes">customer_attributes.</param>
        /// <param name="paymentProfileAttributes">payment_profile_attributes.</param>
        /// <param name="creditCardAttributes">credit_card_attributes.</param>
        /// <param name="bankAccountAttributes">bank_account_attributes.</param>
        /// <param name="components">components.</param>
        /// <param name="calendarBilling">calendar_billing.</param>
        /// <param name="metafields">metafields.</param>
        /// <param name="customerReference">customer_reference.</param>
        /// <param name="mGroup">group.</param>
        /// <param name="mRef">ref.</param>
        /// <param name="cancellationMessage">cancellation_message.</param>
        /// <param name="cancellationMethod">cancellation_method.</param>
        /// <param name="currency">currency.</param>
        /// <param name="expiresAt">expires_at.</param>
        /// <param name="expirationTracksNextBillingChange">expiration_tracks_next_billing_change.</param>
        /// <param name="agreementTerms">agreement_terms.</param>
        /// <param name="authorizerFirstName">authorizer_first_name.</param>
        /// <param name="authorizerLastName">authorizer_last_name.</param>
        /// <param name="calendarBillingFirstCharge">calendar_billing_first_charge.</param>
        /// <param name="reasonCode">reason_code.</param>
        /// <param name="productChangeDelayed">product_change_delayed.</param>
        /// <param name="offerId">offer_id.</param>
        /// <param name="prepaidConfiguration">prepaid_configuration.</param>
        /// <param name="previousBillingAt">previous_billing_at.</param>
        /// <param name="importMrr">import_mrr.</param>
        /// <param name="canceledAt">canceled_at.</param>
        /// <param name="activatedAt">activated_at.</param>
        /// <param name="agreementAcceptance">agreement_acceptance.</param>
        /// <param name="achAgreement">ach_agreement.</param>
        /// <param name="dunningCommunicationDelayEnabled">dunning_communication_delay_enabled.</param>
        /// <param name="dunningCommunicationDelayTimeZone">dunning_communication_delay_time_zone.</param>
        /// <param name="skipBillingManifestTaxes">skip_billing_manifest_taxes.</param>
        public CreateSubscription(
            string productHandle = null,
            int? productId = null,
            string productPricePointHandle = null,
            int? productPricePointId = null,
            Models.SubscriptionCustomPrice customPrice = null,
            string couponCode = null,
            List<string> couponCodes = null,
            Models.PaymentCollectionMethod? paymentCollectionMethod = Models.PaymentCollectionMethod.Automatic,
            string receivesInvoiceEmails = null,
            string netTerms = null,
            int? customerId = null,
            DateTimeOffset? nextBillingAt = null,
            string initialBillingAt = null,
            int? storedCredentialTransactionId = null,
            int? salesRepId = null,
            int? paymentProfileId = null,
            string reference = null,
            Models.CustomerAttributes customerAttributes = null,
            Models.PaymentProfileAttributes paymentProfileAttributes = null,
            Models.PaymentProfileAttributes creditCardAttributes = null,
            Models.BankAccountAttributes bankAccountAttributes = null,
            List<Models.CreateSubscriptionComponent> components = null,
            Models.CalendarBilling calendarBilling = null,
            Dictionary<string, string> metafields = null,
            string customerReference = null,
            Models.GroupSettings mGroup = null,
            string mRef = null,
            string cancellationMessage = null,
            string cancellationMethod = null,
            string currency = null,
            DateTimeOffset? expiresAt = null,
            string expirationTracksNextBillingChange = null,
            string agreementTerms = null,
            string authorizerFirstName = null,
            string authorizerLastName = null,
            string calendarBillingFirstCharge = null,
            string reasonCode = null,
            bool? productChangeDelayed = null,
            CreateSubscriptionOfferId offerId = null,
            Models.UpsertPrepaidConfiguration prepaidConfiguration = null,
            DateTimeOffset? previousBillingAt = null,
            bool? importMrr = null,
            string canceledAt = null,
            DateTimeOffset? activatedAt = null,
            Models.AgreementAcceptance agreementAcceptance = null,
            Models.ACHAgreement achAgreement = null,
            bool? dunningCommunicationDelayEnabled = false,
            string dunningCommunicationDelayTimeZone = null,
            bool? skipBillingManifestTaxes = false)
        {
            this.ProductHandle = productHandle;
            this.ProductId = productId;
            this.ProductPricePointHandle = productPricePointHandle;
            this.ProductPricePointId = productPricePointId;
            this.CustomPrice = customPrice;
            this.CouponCode = couponCode;
            this.CouponCodes = couponCodes;
            this.PaymentCollectionMethod = paymentCollectionMethod;
            this.ReceivesInvoiceEmails = receivesInvoiceEmails;
            this.NetTerms = netTerms;
            this.CustomerId = customerId;
            this.NextBillingAt = nextBillingAt;
            this.InitialBillingAt = initialBillingAt;
            this.StoredCredentialTransactionId = storedCredentialTransactionId;
            this.SalesRepId = salesRepId;
            this.PaymentProfileId = paymentProfileId;
            this.Reference = reference;
            this.CustomerAttributes = customerAttributes;
            this.PaymentProfileAttributes = paymentProfileAttributes;
            this.CreditCardAttributes = creditCardAttributes;
            this.BankAccountAttributes = bankAccountAttributes;
            this.Components = components;
            this.CalendarBilling = calendarBilling;
            this.Metafields = metafields;
            this.CustomerReference = customerReference;
            this.MGroup = mGroup;
            this.MRef = mRef;
            this.CancellationMessage = cancellationMessage;
            this.CancellationMethod = cancellationMethod;
            this.Currency = currency;
            this.ExpiresAt = expiresAt;
            this.ExpirationTracksNextBillingChange = expirationTracksNextBillingChange;
            this.AgreementTerms = agreementTerms;
            this.AuthorizerFirstName = authorizerFirstName;
            this.AuthorizerLastName = authorizerLastName;
            this.CalendarBillingFirstCharge = calendarBillingFirstCharge;
            this.ReasonCode = reasonCode;
            this.ProductChangeDelayed = productChangeDelayed;
            this.OfferId = offerId;
            this.PrepaidConfiguration = prepaidConfiguration;
            this.PreviousBillingAt = previousBillingAt;
            this.ImportMrr = importMrr;
            this.CanceledAt = canceledAt;
            this.ActivatedAt = activatedAt;
            this.AgreementAcceptance = agreementAcceptance;
            this.AchAgreement = achAgreement;
            this.DunningCommunicationDelayEnabled = dunningCommunicationDelayEnabled;
            if (dunningCommunicationDelayTimeZone != null)
            {
                this.DunningCommunicationDelayTimeZone = dunningCommunicationDelayTimeZone;
            }

            this.SkipBillingManifestTaxes = skipBillingManifestTaxes;
        }

        /// <summary>
        /// The API Handle of the product for which you are creating a subscription. Required, unless a `product_id` is given instead.
        /// </summary>
        [JsonProperty("product_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductHandle { get; set; }

        /// <summary>
        /// The Product ID of the product for which you are creating a subscription. The product ID is not currently published, so we recommend using the API Handle instead.
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductId { get; set; }

        /// <summary>
        /// The user-friendly API handle of a product's particular price point.
        /// </summary>
        [JsonProperty("product_price_point_handle", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductPricePointHandle { get; set; }

        /// <summary>
        /// The ID of the particular price point on the product.
        /// </summary>
        [JsonProperty("product_price_point_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ProductPricePointId { get; set; }

        /// <summary>
        /// (Optional) Used in place of `product_price_point_id` to define a custom price point unique to the subscription
        /// </summary>
        [JsonProperty("custom_price", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionCustomPrice CustomPrice { get; set; }

        /// <summary>
        /// (deprecated) The coupon code of the single coupon currently applied to the subscription. See coupon_codes instead as subscriptions can now have more than one coupon.
        /// </summary>
        [JsonProperty("coupon_code", NullValueHandling = NullValueHandling.Ignore)]
        public string CouponCode { get; set; }

        /// <summary>
        /// An array for all the coupons attached to the subscription.
        /// </summary>
        [JsonProperty("coupon_codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// The type of payment collection to be used in the subscription. For legacy Statements Architecture valid options are - `invoice`, `automatic`. For current Relationship Invoicing Architecture valid options are - `remittance`, `automatic`, `prepaid`.
        /// </summary>
        [JsonProperty("payment_collection_method", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentCollectionMethod? PaymentCollectionMethod { get; set; }

        /// <summary>
        /// (Optional) Default: True - Whether or not this subscription is set to receive emails related to this subscription.
        /// </summary>
        [JsonProperty("receives_invoice_emails", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceivesInvoiceEmails { get; set; }

        /// <summary>
        /// (Optional) Default: null The number of days after renewal (on invoice billing) that a subscription is due. A value between 0 (due immediately) and 180.
        /// </summary>
        [JsonProperty("net_terms", NullValueHandling = NullValueHandling.Ignore)]
        public string NetTerms { get; set; }

        /// <summary>
        /// The ID of an existing customer within Chargify. Required, unless a `customer_reference` or a set of `customer_attributes` is given.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// (Optional) Set this attribute to a future date/time to sync imported subscriptions to your existing renewal schedule. See the notes on “Date/Time Format” in our [subscription import documentation](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404863655821#date-format). If you provide a next_billing_at timestamp that is in the future, no trial or initial charges will be applied when you create the subscription. In fact, no payment will be captured at all. The first payment will be captured, according to the prices defined by the product, near the time specified by next_billing_at. If you do not provide a value for next_billing_at, any trial and/or initial charges will be assessed and charged at the time of subscription creation. If the card cannot be successfully charged, the subscription will not be created. See further notes in the section on Importing Subscriptions.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NextBillingAt { get; set; }

        /// <summary>
        /// (Optional) Set this attribute to a future date/time to create a subscription in the "Awaiting Signup" state, rather than "Active" or "Trialing". See the notes on “Date/Time Format” in our [subscription import documentation](https://maxio-chargify.zendesk.com/hc/en-us/articles/5404863655821#date-format). In the "Awaiting Signup" state, a subscription behaves like any other. It can be canceled, allocated to, had its billing date changed. etc. When the initial_billing_at date hits, the subscription will transition to the expected state. If the product has a trial, the subscription will enter a trial, otherwise it will go active. Setup fees will be respected either before or after the trial, as configured on the price point. If the payment is due at the initial_billing_at and it fails the subscription will be immediately canceled. See further notes in the section on Delayed Signups.
        /// </summary>
        [JsonProperty("initial_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public string InitialBillingAt { get; set; }

        /// <summary>
        /// For European sites subject to PSD2 and using 3D Secure, this can be used to reference a previous transaction for the customer. This will ensure the card will be charged successfully at renewal.
        /// </summary>
        [JsonProperty("stored_credential_transaction_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? StoredCredentialTransactionId { get; set; }

        /// <summary>
        /// Gets or sets SalesRepId.
        /// </summary>
        [JsonProperty("sales_rep_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesRepId { get; set; }

        /// <summary>
        /// The Payment Profile ID of an existing card or bank account, which belongs to an existing customer to use for payment for this subscription. If the card, bank account, or customer does not exist already, or if you want to use a new (unstored) card or bank account for the subscription, use `payment_profile_attributes` instead to create a new payment profile along with the subscription. (This value is available on an existing subscription via the API as `credit_card` > id or `bank_account` > id)
        /// </summary>
        [JsonProperty("payment_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? PaymentProfileId { get; set; }

        /// <summary>
        /// The reference value (provided by your app) for the subscription itelf.
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets CustomerAttributes.
        /// </summary>
        [JsonProperty("customer_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerAttributes CustomerAttributes { get; set; }

        /// <summary>
        /// alias to credit_card_attributes
        /// </summary>
        [JsonProperty("payment_profile_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentProfileAttributes PaymentProfileAttributes { get; set; }

        /// <summary>
        /// Credit Card data to create a new Subscription. Interchangeable with `payment_profile_attributes` property.
        /// </summary>
        [JsonProperty("credit_card_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PaymentProfileAttributes CreditCardAttributes { get; set; }

        /// <summary>
        /// Gets or sets BankAccountAttributes.
        /// </summary>
        [JsonProperty("bank_account_attributes", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BankAccountAttributes BankAccountAttributes { get; set; }

        /// <summary>
        /// (Optional) An array of component ids and quantities to be added to the subscription. See [Components](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405020625677) for more information.
        /// </summary>
        [JsonProperty("components", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.CreateSubscriptionComponent> Components { get; set; }

        /// <summary>
        /// (Optional). Cannot be used when also specifying next_billing_at
        /// </summary>
        [JsonProperty("calendar_billing", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CalendarBilling CalendarBilling { get; set; }

        /// <summary>
        /// (Optional) A set of key/value pairs representing custom fields and their values. Metafields will be created “on-the-fly” in your site for a given key, if they have not been created yet.
        /// </summary>
        [JsonProperty("metafields", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Metafields { get; set; }

        /// <summary>
        /// The reference value (provided by your app) of an existing customer within Chargify. Required, unless a `customer_id` or a set of `customer_attributes` is given.
        /// </summary>
        [JsonProperty("customer_reference", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Gets or sets MGroup.
        /// </summary>
        [JsonProperty("group", NullValueHandling = NullValueHandling.Ignore)]
        public Models.GroupSettings MGroup { get; set; }

        /// <summary>
        /// A valid referral code. (optional, see [Referrals](https://maxio-chargify.zendesk.com/hc/en-us/articles/5405420204045-Referrals-Reference#how-to-obtain-referral-codes) for more details). If supplied, must be valid, or else subscription creation will fail.
        /// </summary>
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string MRef { get; set; }

        /// <summary>
        /// (Optional) Can be used when canceling a subscription (via the HTTP DELETE method) to make a note about the reason for cancellation.
        /// </summary>
        [JsonProperty("cancellation_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMessage { get; set; }

        /// <summary>
        /// (Optional) Can be used when canceling a subscription (via the HTTP DELETE method) to make a note about how the subscription was canceled.
        /// </summary>
        [JsonProperty("cancellation_method", NullValueHandling = NullValueHandling.Ignore)]
        public string CancellationMethod { get; set; }

        /// <summary>
        /// (Optional) If Multi-Currency is enabled and the currency is configured in Chargify, pass it at signup to create a subscription on a non-default currency. Note that you cannot update the currency of an existing subscription.
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }

        /// <summary>
        /// Timestamp giving the expiration date of this subscription (if any). You may manually change the expiration date at any point during a subscription period.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// (Optional, default false) When set to true, and when next_billing_at is present, if the subscription expires, the expires_at will be shifted by the same amount of time as the difference between the old and new “next billing” dates.
        /// </summary>
        [JsonProperty("expiration_tracks_next_billing_change", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpirationTracksNextBillingChange { get; set; }

        /// <summary>
        /// (Optional) The ACH authorization agreement terms. If enabled, an email will be sent to the customer with a copy of the terms.
        /// </summary>
        [JsonProperty("agreement_terms", NullValueHandling = NullValueHandling.Ignore)]
        public string AgreementTerms { get; set; }

        /// <summary>
        /// (Optional) The first name of the person authorizing the ACH agreement.
        /// </summary>
        [JsonProperty("authorizer_first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerFirstName { get; set; }

        /// <summary>
        /// (Optional) The last name of the person authorizing the ACH agreement.
        /// </summary>
        [JsonProperty("authorizer_last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthorizerLastName { get; set; }

        /// <summary>
        /// (Optional) One of “prorated” (the default – the prorated product price will be charged immediately), “immediate” (the full product price will be charged immediately), or “delayed” (the full product price will be charged with the first scheduled renewal).
        /// </summary>
        [JsonProperty("calendar_billing_first_charge", NullValueHandling = NullValueHandling.Ignore)]
        public string CalendarBillingFirstCharge { get; set; }

        /// <summary>
        /// (Optional) Can be used when canceling a subscription (via the HTTP DELETE method) to indicate why a subscription was canceled.
        /// </summary>
        [JsonProperty("reason_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// (Optional, used only for Delayed Product Change When set to true, indicates that a changed value for product_handle should schedule the product change to the next subscription renewal.
        /// </summary>
        [JsonProperty("product_change_delayed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProductChangeDelayed { get; set; }

        /// <summary>
        /// Use in place of passing product and component information to set up the subscription with an existing offer. May be either the Chargify id of the offer or its handle prefixed with `handle:`.er
        /// </summary>
        [JsonProperty("offer_id", NullValueHandling = NullValueHandling.Ignore)]
        public CreateSubscriptionOfferId OfferId { get; set; }

        /// <summary>
        /// Gets or sets PrepaidConfiguration.
        /// </summary>
        [JsonProperty("prepaid_configuration", NullValueHandling = NullValueHandling.Ignore)]
        public Models.UpsertPrepaidConfiguration PrepaidConfiguration { get; set; }

        /// <summary>
        /// Providing a previous_billing_at that is in the past will set the current_period_starts_at when the subscription is created. It will also set activated_at if not explicitly passed during the subscription import. Can only be used if next_billing_at is also passed. Using this option will allow you to set the period start for the subscription so mid period component allocations have the correct prorated amount.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("previous_billing_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PreviousBillingAt { get; set; }

        /// <summary>
        /// Setting this attribute to true will cause the subscription's MRR to be added to your MRR analytics immediately. For this value to be honored, a next_billing_at must be present and set to a future date. This key/value will not be returned in the subscription response body.
        /// </summary>
        [JsonProperty("import_mrr", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportMrr { get; set; }

        /// <summary>
        /// Gets or sets CanceledAt.
        /// </summary>
        [JsonProperty("canceled_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CanceledAt { get; set; }

        /// <summary>
        /// Gets or sets ActivatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("activated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ActivatedAt { get; set; }

        /// <summary>
        /// Required when creating a subscription with Maxio Payments.
        /// </summary>
        [JsonProperty("agreement_acceptance", NullValueHandling = NullValueHandling.Ignore)]
        public Models.AgreementAcceptance AgreementAcceptance { get; set; }

        /// <summary>
        /// (Optional) If passed, the proof of the authorized ACH agreement terms will be persisted.
        /// </summary>
        [JsonProperty("ach_agreement", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ACHAgreement AchAgreement { get; set; }

        /// <summary>
        /// Enable Communication Delay feature, making sure no communication (email or SMS) is sent to the Customer between 9PM and 8AM in time zone set by the `dunning_communication_delay_time_zone` attribute.
        /// </summary>
        [JsonProperty("dunning_communication_delay_enabled")]
        public bool? DunningCommunicationDelayEnabled
        {
            get
            {
                return this.dunningCommunicationDelayEnabled;
            }

            set
            {
                this.shouldSerialize["dunning_communication_delay_enabled"] = true;
                this.dunningCommunicationDelayEnabled = value;
            }
        }

        /// <summary>
        /// Time zone for the Dunning Communication Delay feature.
        /// </summary>
        [JsonProperty("dunning_communication_delay_time_zone")]
        public string DunningCommunicationDelayTimeZone
        {
            get
            {
                return this.dunningCommunicationDelayTimeZone;
            }

            set
            {
                this.shouldSerialize["dunning_communication_delay_time_zone"] = true;
                this.dunningCommunicationDelayTimeZone = value;
            }
        }

        /// <summary>
        /// Valid only for the Subscription Preview endpoint. When set to `true` it skips calculating taxes for the current and next billing manifests.
        /// </summary>
        [JsonProperty("skip_billing_manifest_taxes", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipBillingManifestTaxes { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CreateSubscription : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDunningCommunicationDelayEnabled()
        {
            this.shouldSerialize["dunning_communication_delay_enabled"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDunningCommunicationDelayTimeZone()
        {
            this.shouldSerialize["dunning_communication_delay_time_zone"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDunningCommunicationDelayEnabled()
        {
            return this.shouldSerialize["dunning_communication_delay_enabled"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDunningCommunicationDelayTimeZone()
        {
            return this.shouldSerialize["dunning_communication_delay_time_zone"];
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
            return obj is CreateSubscription other &&                ((this.ProductHandle == null && other.ProductHandle == null) || (this.ProductHandle?.Equals(other.ProductHandle) == true)) &&
                ((this.ProductId == null && other.ProductId == null) || (this.ProductId?.Equals(other.ProductId) == true)) &&
                ((this.ProductPricePointHandle == null && other.ProductPricePointHandle == null) || (this.ProductPricePointHandle?.Equals(other.ProductPricePointHandle) == true)) &&
                ((this.ProductPricePointId == null && other.ProductPricePointId == null) || (this.ProductPricePointId?.Equals(other.ProductPricePointId) == true)) &&
                ((this.CustomPrice == null && other.CustomPrice == null) || (this.CustomPrice?.Equals(other.CustomPrice) == true)) &&
                ((this.CouponCode == null && other.CouponCode == null) || (this.CouponCode?.Equals(other.CouponCode) == true)) &&
                ((this.CouponCodes == null && other.CouponCodes == null) || (this.CouponCodes?.Equals(other.CouponCodes) == true)) &&
                ((this.PaymentCollectionMethod == null && other.PaymentCollectionMethod == null) || (this.PaymentCollectionMethod?.Equals(other.PaymentCollectionMethod) == true)) &&
                ((this.ReceivesInvoiceEmails == null && other.ReceivesInvoiceEmails == null) || (this.ReceivesInvoiceEmails?.Equals(other.ReceivesInvoiceEmails) == true)) &&
                ((this.NetTerms == null && other.NetTerms == null) || (this.NetTerms?.Equals(other.NetTerms) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true)) &&
                ((this.NextBillingAt == null && other.NextBillingAt == null) || (this.NextBillingAt?.Equals(other.NextBillingAt) == true)) &&
                ((this.InitialBillingAt == null && other.InitialBillingAt == null) || (this.InitialBillingAt?.Equals(other.InitialBillingAt) == true)) &&
                ((this.StoredCredentialTransactionId == null && other.StoredCredentialTransactionId == null) || (this.StoredCredentialTransactionId?.Equals(other.StoredCredentialTransactionId) == true)) &&
                ((this.SalesRepId == null && other.SalesRepId == null) || (this.SalesRepId?.Equals(other.SalesRepId) == true)) &&
                ((this.PaymentProfileId == null && other.PaymentProfileId == null) || (this.PaymentProfileId?.Equals(other.PaymentProfileId) == true)) &&
                ((this.Reference == null && other.Reference == null) || (this.Reference?.Equals(other.Reference) == true)) &&
                ((this.CustomerAttributes == null && other.CustomerAttributes == null) || (this.CustomerAttributes?.Equals(other.CustomerAttributes) == true)) &&
                ((this.PaymentProfileAttributes == null && other.PaymentProfileAttributes == null) || (this.PaymentProfileAttributes?.Equals(other.PaymentProfileAttributes) == true)) &&
                ((this.CreditCardAttributes == null && other.CreditCardAttributes == null) || (this.CreditCardAttributes?.Equals(other.CreditCardAttributes) == true)) &&
                ((this.BankAccountAttributes == null && other.BankAccountAttributes == null) || (this.BankAccountAttributes?.Equals(other.BankAccountAttributes) == true)) &&
                ((this.Components == null && other.Components == null) || (this.Components?.Equals(other.Components) == true)) &&
                ((this.CalendarBilling == null && other.CalendarBilling == null) || (this.CalendarBilling?.Equals(other.CalendarBilling) == true)) &&
                ((this.Metafields == null && other.Metafields == null) || (this.Metafields?.Equals(other.Metafields) == true)) &&
                ((this.CustomerReference == null && other.CustomerReference == null) || (this.CustomerReference?.Equals(other.CustomerReference) == true)) &&
                ((this.MGroup == null && other.MGroup == null) || (this.MGroup?.Equals(other.MGroup) == true)) &&
                ((this.MRef == null && other.MRef == null) || (this.MRef?.Equals(other.MRef) == true)) &&
                ((this.CancellationMessage == null && other.CancellationMessage == null) || (this.CancellationMessage?.Equals(other.CancellationMessage) == true)) &&
                ((this.CancellationMethod == null && other.CancellationMethod == null) || (this.CancellationMethod?.Equals(other.CancellationMethod) == true)) &&
                ((this.Currency == null && other.Currency == null) || (this.Currency?.Equals(other.Currency) == true)) &&
                ((this.ExpiresAt == null && other.ExpiresAt == null) || (this.ExpiresAt?.Equals(other.ExpiresAt) == true)) &&
                ((this.ExpirationTracksNextBillingChange == null && other.ExpirationTracksNextBillingChange == null) || (this.ExpirationTracksNextBillingChange?.Equals(other.ExpirationTracksNextBillingChange) == true)) &&
                ((this.AgreementTerms == null && other.AgreementTerms == null) || (this.AgreementTerms?.Equals(other.AgreementTerms) == true)) &&
                ((this.AuthorizerFirstName == null && other.AuthorizerFirstName == null) || (this.AuthorizerFirstName?.Equals(other.AuthorizerFirstName) == true)) &&
                ((this.AuthorizerLastName == null && other.AuthorizerLastName == null) || (this.AuthorizerLastName?.Equals(other.AuthorizerLastName) == true)) &&
                ((this.CalendarBillingFirstCharge == null && other.CalendarBillingFirstCharge == null) || (this.CalendarBillingFirstCharge?.Equals(other.CalendarBillingFirstCharge) == true)) &&
                ((this.ReasonCode == null && other.ReasonCode == null) || (this.ReasonCode?.Equals(other.ReasonCode) == true)) &&
                ((this.ProductChangeDelayed == null && other.ProductChangeDelayed == null) || (this.ProductChangeDelayed?.Equals(other.ProductChangeDelayed) == true)) &&
                ((this.OfferId == null && other.OfferId == null) || (this.OfferId?.Equals(other.OfferId) == true)) &&
                ((this.PrepaidConfiguration == null && other.PrepaidConfiguration == null) || (this.PrepaidConfiguration?.Equals(other.PrepaidConfiguration) == true)) &&
                ((this.PreviousBillingAt == null && other.PreviousBillingAt == null) || (this.PreviousBillingAt?.Equals(other.PreviousBillingAt) == true)) &&
                ((this.ImportMrr == null && other.ImportMrr == null) || (this.ImportMrr?.Equals(other.ImportMrr) == true)) &&
                ((this.CanceledAt == null && other.CanceledAt == null) || (this.CanceledAt?.Equals(other.CanceledAt) == true)) &&
                ((this.ActivatedAt == null && other.ActivatedAt == null) || (this.ActivatedAt?.Equals(other.ActivatedAt) == true)) &&
                ((this.AgreementAcceptance == null && other.AgreementAcceptance == null) || (this.AgreementAcceptance?.Equals(other.AgreementAcceptance) == true)) &&
                ((this.AchAgreement == null && other.AchAgreement == null) || (this.AchAgreement?.Equals(other.AchAgreement) == true)) &&
                ((this.DunningCommunicationDelayEnabled == null && other.DunningCommunicationDelayEnabled == null) || (this.DunningCommunicationDelayEnabled?.Equals(other.DunningCommunicationDelayEnabled) == true)) &&
                ((this.DunningCommunicationDelayTimeZone == null && other.DunningCommunicationDelayTimeZone == null) || (this.DunningCommunicationDelayTimeZone?.Equals(other.DunningCommunicationDelayTimeZone) == true)) &&
                ((this.SkipBillingManifestTaxes == null && other.SkipBillingManifestTaxes == null) || (this.SkipBillingManifestTaxes?.Equals(other.SkipBillingManifestTaxes) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProductHandle = {(this.ProductHandle == null ? "null" : this.ProductHandle)}");
            toStringOutput.Add($"this.ProductId = {(this.ProductId == null ? "null" : this.ProductId.ToString())}");
            toStringOutput.Add($"this.ProductPricePointHandle = {(this.ProductPricePointHandle == null ? "null" : this.ProductPricePointHandle)}");
            toStringOutput.Add($"this.ProductPricePointId = {(this.ProductPricePointId == null ? "null" : this.ProductPricePointId.ToString())}");
            toStringOutput.Add($"this.CustomPrice = {(this.CustomPrice == null ? "null" : this.CustomPrice.ToString())}");
            toStringOutput.Add($"this.CouponCode = {(this.CouponCode == null ? "null" : this.CouponCode)}");
            toStringOutput.Add($"this.CouponCodes = {(this.CouponCodes == null ? "null" : $"[{string.Join(", ", this.CouponCodes)} ]")}");
            toStringOutput.Add($"this.PaymentCollectionMethod = {(this.PaymentCollectionMethod == null ? "null" : this.PaymentCollectionMethod.ToString())}");
            toStringOutput.Add($"this.ReceivesInvoiceEmails = {(this.ReceivesInvoiceEmails == null ? "null" : this.ReceivesInvoiceEmails)}");
            toStringOutput.Add($"this.NetTerms = {(this.NetTerms == null ? "null" : this.NetTerms)}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.NextBillingAt = {(this.NextBillingAt == null ? "null" : this.NextBillingAt.ToString())}");
            toStringOutput.Add($"this.InitialBillingAt = {(this.InitialBillingAt == null ? "null" : this.InitialBillingAt)}");
            toStringOutput.Add($"this.StoredCredentialTransactionId = {(this.StoredCredentialTransactionId == null ? "null" : this.StoredCredentialTransactionId.ToString())}");
            toStringOutput.Add($"this.SalesRepId = {(this.SalesRepId == null ? "null" : this.SalesRepId.ToString())}");
            toStringOutput.Add($"this.PaymentProfileId = {(this.PaymentProfileId == null ? "null" : this.PaymentProfileId.ToString())}");
            toStringOutput.Add($"this.Reference = {(this.Reference == null ? "null" : this.Reference)}");
            toStringOutput.Add($"this.CustomerAttributes = {(this.CustomerAttributes == null ? "null" : this.CustomerAttributes.ToString())}");
            toStringOutput.Add($"this.PaymentProfileAttributes = {(this.PaymentProfileAttributes == null ? "null" : this.PaymentProfileAttributes.ToString())}");
            toStringOutput.Add($"this.CreditCardAttributes = {(this.CreditCardAttributes == null ? "null" : this.CreditCardAttributes.ToString())}");
            toStringOutput.Add($"this.BankAccountAttributes = {(this.BankAccountAttributes == null ? "null" : this.BankAccountAttributes.ToString())}");
            toStringOutput.Add($"this.Components = {(this.Components == null ? "null" : $"[{string.Join(", ", this.Components)} ]")}");
            toStringOutput.Add($"this.CalendarBilling = {(this.CalendarBilling == null ? "null" : this.CalendarBilling.ToString())}");
            toStringOutput.Add($"Metafields = {(this.Metafields == null ? "null" : this.Metafields.ToString())}");
            toStringOutput.Add($"this.CustomerReference = {(this.CustomerReference == null ? "null" : this.CustomerReference)}");
            toStringOutput.Add($"this.MGroup = {(this.MGroup == null ? "null" : this.MGroup.ToString())}");
            toStringOutput.Add($"this.MRef = {(this.MRef == null ? "null" : this.MRef)}");
            toStringOutput.Add($"this.CancellationMessage = {(this.CancellationMessage == null ? "null" : this.CancellationMessage)}");
            toStringOutput.Add($"this.CancellationMethod = {(this.CancellationMethod == null ? "null" : this.CancellationMethod)}");
            toStringOutput.Add($"this.Currency = {(this.Currency == null ? "null" : this.Currency)}");
            toStringOutput.Add($"this.ExpiresAt = {(this.ExpiresAt == null ? "null" : this.ExpiresAt.ToString())}");
            toStringOutput.Add($"this.ExpirationTracksNextBillingChange = {(this.ExpirationTracksNextBillingChange == null ? "null" : this.ExpirationTracksNextBillingChange)}");
            toStringOutput.Add($"this.AgreementTerms = {(this.AgreementTerms == null ? "null" : this.AgreementTerms)}");
            toStringOutput.Add($"this.AuthorizerFirstName = {(this.AuthorizerFirstName == null ? "null" : this.AuthorizerFirstName)}");
            toStringOutput.Add($"this.AuthorizerLastName = {(this.AuthorizerLastName == null ? "null" : this.AuthorizerLastName)}");
            toStringOutput.Add($"this.CalendarBillingFirstCharge = {(this.CalendarBillingFirstCharge == null ? "null" : this.CalendarBillingFirstCharge)}");
            toStringOutput.Add($"this.ReasonCode = {(this.ReasonCode == null ? "null" : this.ReasonCode)}");
            toStringOutput.Add($"this.ProductChangeDelayed = {(this.ProductChangeDelayed == null ? "null" : this.ProductChangeDelayed.ToString())}");
            toStringOutput.Add($"OfferId = {(this.OfferId == null ? "null" : this.OfferId.ToString())}");
            toStringOutput.Add($"this.PrepaidConfiguration = {(this.PrepaidConfiguration == null ? "null" : this.PrepaidConfiguration.ToString())}");
            toStringOutput.Add($"this.PreviousBillingAt = {(this.PreviousBillingAt == null ? "null" : this.PreviousBillingAt.ToString())}");
            toStringOutput.Add($"this.ImportMrr = {(this.ImportMrr == null ? "null" : this.ImportMrr.ToString())}");
            toStringOutput.Add($"this.CanceledAt = {(this.CanceledAt == null ? "null" : this.CanceledAt)}");
            toStringOutput.Add($"this.ActivatedAt = {(this.ActivatedAt == null ? "null" : this.ActivatedAt.ToString())}");
            toStringOutput.Add($"this.AgreementAcceptance = {(this.AgreementAcceptance == null ? "null" : this.AgreementAcceptance.ToString())}");
            toStringOutput.Add($"this.AchAgreement = {(this.AchAgreement == null ? "null" : this.AchAgreement.ToString())}");
            toStringOutput.Add($"this.DunningCommunicationDelayEnabled = {(this.DunningCommunicationDelayEnabled == null ? "null" : this.DunningCommunicationDelayEnabled.ToString())}");
            toStringOutput.Add($"this.DunningCommunicationDelayTimeZone = {(this.DunningCommunicationDelayTimeZone == null ? "null" : this.DunningCommunicationDelayTimeZone)}");
            toStringOutput.Add($"this.SkipBillingManifestTaxes = {(this.SkipBillingManifestTaxes == null ? "null" : this.SkipBillingManifestTaxes.ToString())}");
        }
    }
}