// <copyright file="Event.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// Event.
    /// </summary>
    public class Event : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        public Event()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Event"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key.</param>
        /// <param name="message">message.</param>
        /// <param name="createdAt">created_at.</param>
        /// <param name="subscriptionId">subscription_id.</param>
        /// <param name="customerId">customer_id.</param>
        /// <param name="eventSpecificData">event_specific_data.</param>
        public Event(
            long id,
            Models.EventKey key,
            string message,
            DateTimeOffset createdAt,
            int? subscriptionId = null,
            int? customerId = null,
            EventEventSpecificData eventSpecificData = null)
        {
            this.Id = id;
            this.Key = key;
            this.Message = message;
            this.SubscriptionId = subscriptionId;
            this.CustomerId = customerId;
            this.CreatedAt = createdAt;
            this.EventSpecificData = eventSpecificData;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets Key.
        /// </summary>
        [JsonProperty("key")]
        public Models.EventKey Key { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets SubscriptionId.
        /// </summary>
        [JsonProperty("subscription_id", NullValueHandling = NullValueHandling.Include)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets CustomerId.
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Include)]
        public int? CustomerId { get; set; }

        /// <summary>
        /// Gets or sets CreatedAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The schema varies based on the event key. The key-to-event data mapping is as follows:
        /// * `subscription_product_change` - SubscriptionProductChange
        /// * `subscription_state_change` - SubscriptionStateChange
        /// * `signup_success`, `delayed_signup_creation_success`, `payment_success`, `payment_failure`, `renewal_success`, `renewal_failure`, `chargeback_lost`, `chargeback_accepted`, `chargeback_closed` - PaymentRelatedEvents
        /// * `refund_success` - RefundSuccess
        /// * `component_allocation_change` - ComponentAllocationChange
        /// * `metered_usage` - MeteredUsage
        /// * `prepaid_usage` - PrepaidUsage
        /// * `dunning_step_reached` - DunningStepReached
        /// * `invoice_issued` - InvoiceIssued
        /// * `pending_cancellation_change` - PendingCancellationChange
        /// * `prepaid_subscription_balance_changed` - PrepaidSubscriptionBalanceChanged
        /// * `subscription_group_signup_success` and `subscription_group_signup_failure` - SubscriptionGroupSignupEventData
        /// * `proforma_invoice_issued` - ProformaInvoiceIssued
        /// * `subscription_prepayment_account_balance_changed` - PrepaymentAccountBalanceChanged
        /// * `payment_collection_method_changed` - PaymentCollectionMethodChanged
        /// * `subscription_service_credit_account_balance_changed` - CreditAccountBalanceChanged
        /// * `item_price_point_changed` - ItemPricePointChanged
        /// * `custom_field_value_change` - CustomFieldValueChange
        /// * The rest, that is `delayed_signup_creation_failure`, `billing_date_change`, `expiration_date_change`, `expiring_card`,
        /// `customer_update`, `customer_create`, `customer_delete`, `upgrade_downgrade_success`, `upgrade_downgrade_failure`,
        /// `statement_closed`, `statement_settled`, `subscription_card_update`, `subscription_group_card_update`,
        /// `subscription_bank_account_update`, `refund_failure`, `upcoming_renewal_notice`, `trial_end_notice`,
        /// `direct_debit_payment_paid_out`, `direct_debit_payment_rejected`, `direct_debit_payment_pending`, `pending_payment_created`,
        /// `pending_payment_failed`, `pending_payment_completed`,  don't have event_specific_data defined,
        /// `renewal_success_recreated`, `renewal_failure_recreated`, `payment_success_recreated`, `payment_failure_recreated`,
        /// `subscription_deletion`, `subscription_group_bank_account_update`, `subscription_paypal_account_update`, `subscription_group_paypal_account_update`,
        /// `subscription_customer_change`, `account_transaction_changed`, `go_cardless_payment_paid_out`, `go_cardless_payment_rejected`,
        /// `go_cardless_payment_pending`, `stripe_direct_debit_payment_paid_out`, `stripe_direct_debit_payment_rejected`, `stripe_direct_debit_payment_pending`,
        /// `maxio_payments_direct_debit_payment_paid_out`, `maxio_payments_direct_debit_payment_rejected`, `maxio_payments_direct_debit_payment_pending`,
        /// `invoice_in_collections_canceled`, `subscription_added_to_group`, `subscription_removed_from_group`, `chargeback_opened`, `chargeback_lost`,
        /// `chargeback_accepted`, `chargeback_closed`, `chargeback_won`, `payment_collection_method_changed`, `component_billing_date_changed`,
        /// `subscription_term_renewal_scheduled`, `subscription_term_renewal_pending`, `subscription_term_renewal_activated`, `subscription_term_renewal_removed`
        /// they map to `null` instead.
        /// </summary>
        [JsonProperty("event_specific_data", NullValueHandling = NullValueHandling.Include)]
        public EventEventSpecificData EventSpecificData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Event : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Event other &&
                (this.Id.Equals(other.Id)) &&
                (this.Key.Equals(other.Key)) &&
                (this.Message == null && other.Message == null ||
                 this.Message?.Equals(other.Message) == true) &&
                (this.SubscriptionId == null && other.SubscriptionId == null ||
                 this.SubscriptionId?.Equals(other.SubscriptionId) == true) &&
                (this.CustomerId == null && other.CustomerId == null ||
                 this.CustomerId?.Equals(other.CustomerId) == true) &&
                (this.CreatedAt.Equals(other.CreatedAt)) &&
                (this.EventSpecificData == null && other.EventSpecificData == null ||
                 this.EventSpecificData?.Equals(other.EventSpecificData) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {this.Id}");
            toStringOutput.Add($"this.Key = {this.Key}");
            toStringOutput.Add($"this.Message = {this.Message ?? "null"}");
            toStringOutput.Add($"this.SubscriptionId = {(this.SubscriptionId == null ? "null" : this.SubscriptionId.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");
            toStringOutput.Add($"this.CreatedAt = {this.CreatedAt}");
            toStringOutput.Add($"EventSpecificData = {(this.EventSpecificData == null ? "null" : this.EventSpecificData.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}