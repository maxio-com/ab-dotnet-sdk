// <copyright file="EventKey.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// EventKey.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventKey
    {
        /// <summary>
        /// PaymentSuccess.
        /// </summary>
        [EnumMember(Value = "payment_success")]
        PaymentSuccess,

        /// <summary>
        /// PaymentFailure.
        /// </summary>
        [EnumMember(Value = "payment_failure")]
        PaymentFailure,

        /// <summary>
        /// SignupSuccess.
        /// </summary>
        [EnumMember(Value = "signup_success")]
        SignupSuccess,

        /// <summary>
        /// SignupFailure.
        /// </summary>
        [EnumMember(Value = "signup_failure")]
        SignupFailure,

        /// <summary>
        /// DelayedSignupCreationSuccess.
        /// </summary>
        [EnumMember(Value = "delayed_signup_creation_success")]
        DelayedSignupCreationSuccess,

        /// <summary>
        /// DelayedSignupCreationFailure.
        /// </summary>
        [EnumMember(Value = "delayed_signup_creation_failure")]
        DelayedSignupCreationFailure,

        /// <summary>
        /// BillingDateChange.
        /// </summary>
        [EnumMember(Value = "billing_date_change")]
        BillingDateChange,

        /// <summary>
        /// ExpirationDateChange.
        /// </summary>
        [EnumMember(Value = "expiration_date_change")]
        ExpirationDateChange,

        /// <summary>
        /// RenewalSuccess.
        /// </summary>
        [EnumMember(Value = "renewal_success")]
        RenewalSuccess,

        /// <summary>
        /// RenewalFailure.
        /// </summary>
        [EnumMember(Value = "renewal_failure")]
        RenewalFailure,

        /// <summary>
        /// SubscriptionStateChange.
        /// </summary>
        [EnumMember(Value = "subscription_state_change")]
        SubscriptionStateChange,

        /// <summary>
        /// SubscriptionProductChange.
        /// </summary>
        [EnumMember(Value = "subscription_product_change")]
        SubscriptionProductChange,

        /// <summary>
        /// PendingCancellationChange.
        /// </summary>
        [EnumMember(Value = "pending_cancellation_change")]
        PendingCancellationChange,

        /// <summary>
        /// ExpiringCard.
        /// </summary>
        [EnumMember(Value = "expiring_card")]
        ExpiringCard,

        /// <summary>
        /// CustomerUpdate.
        /// </summary>
        [EnumMember(Value = "customer_update")]
        CustomerUpdate,

        /// <summary>
        /// CustomerCreate.
        /// </summary>
        [EnumMember(Value = "customer_create")]
        CustomerCreate,

        /// <summary>
        /// CustomerDelete.
        /// </summary>
        [EnumMember(Value = "customer_delete")]
        CustomerDelete,

        /// <summary>
        /// ComponentAllocationChange.
        /// </summary>
        [EnumMember(Value = "component_allocation_change")]
        ComponentAllocationChange,

        /// <summary>
        /// MeteredUsage.
        /// </summary>
        [EnumMember(Value = "metered_usage")]
        MeteredUsage,

        /// <summary>
        /// PrepaidUsage.
        /// </summary>
        [EnumMember(Value = "prepaid_usage")]
        PrepaidUsage,

        /// <summary>
        /// UpgradeDowngradeSuccess.
        /// </summary>
        [EnumMember(Value = "upgrade_downgrade_success")]
        UpgradeDowngradeSuccess,

        /// <summary>
        /// UpgradeDowngradeFailure.
        /// </summary>
        [EnumMember(Value = "upgrade_downgrade_failure")]
        UpgradeDowngradeFailure,

        /// <summary>
        /// StatementClosed.
        /// </summary>
        [EnumMember(Value = "statement_closed")]
        StatementClosed,

        /// <summary>
        /// StatementSettled.
        /// </summary>
        [EnumMember(Value = "statement_settled")]
        StatementSettled,

        /// <summary>
        /// SubscriptionCardUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_card_update")]
        SubscriptionCardUpdate,

        /// <summary>
        /// SubscriptionGroupCardUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_group_card_update")]
        SubscriptionGroupCardUpdate,

        /// <summary>
        /// SubscriptionBankAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_bank_account_update")]
        SubscriptionBankAccountUpdate,

        /// <summary>
        /// RefundSuccess.
        /// </summary>
        [EnumMember(Value = "refund_success")]
        RefundSuccess,

        /// <summary>
        /// RefundFailure.
        /// </summary>
        [EnumMember(Value = "refund_failure")]
        RefundFailure,

        /// <summary>
        /// UpcomingRenewalNotice.
        /// </summary>
        [EnumMember(Value = "upcoming_renewal_notice")]
        UpcomingRenewalNotice,

        /// <summary>
        /// TrialEndNotice.
        /// </summary>
        [EnumMember(Value = "trial_end_notice")]
        TrialEndNotice,

        /// <summary>
        /// DunningStepReached.
        /// </summary>
        [EnumMember(Value = "dunning_step_reached")]
        DunningStepReached,

        /// <summary>
        /// InvoiceIssued.
        /// </summary>
        [EnumMember(Value = "invoice_issued")]
        InvoiceIssued,

        /// <summary>
        /// PrepaidSubscriptionBalanceChanged.
        /// </summary>
        [EnumMember(Value = "prepaid_subscription_balance_changed")]
        PrepaidSubscriptionBalanceChanged,

        /// <summary>
        /// SubscriptionGroupSignupSuccess.
        /// </summary>
        [EnumMember(Value = "subscription_group_signup_success")]
        SubscriptionGroupSignupSuccess,

        /// <summary>
        /// SubscriptionGroupSignupFailure.
        /// </summary>
        [EnumMember(Value = "subscription_group_signup_failure")]
        SubscriptionGroupSignupFailure,

        /// <summary>
        /// DirectDebitPaymentPaidOut.
        /// </summary>
        [EnumMember(Value = "direct_debit_payment_paid_out")]
        DirectDebitPaymentPaidOut,

        /// <summary>
        /// DirectDebitPaymentRejected.
        /// </summary>
        [EnumMember(Value = "direct_debit_payment_rejected")]
        DirectDebitPaymentRejected,

        /// <summary>
        /// DirectDebitPaymentPending.
        /// </summary>
        [EnumMember(Value = "direct_debit_payment_pending")]
        DirectDebitPaymentPending,

        /// <summary>
        /// PendingPaymentCreated.
        /// </summary>
        [EnumMember(Value = "pending_payment_created")]
        PendingPaymentCreated,

        /// <summary>
        /// PendingPaymentFailed.
        /// </summary>
        [EnumMember(Value = "pending_payment_failed")]
        PendingPaymentFailed,

        /// <summary>
        /// PendingPaymentCompleted.
        /// </summary>
        [EnumMember(Value = "pending_payment_completed")]
        PendingPaymentCompleted,

        /// <summary>
        /// ProformaInvoiceIssued.
        /// </summary>
        [EnumMember(Value = "proforma_invoice_issued")]
        ProformaInvoiceIssued,

        /// <summary>
        /// SubscriptionPrepaymentAccountBalanceChanged.
        /// </summary>
        [EnumMember(Value = "subscription_prepayment_account_balance_changed")]
        SubscriptionPrepaymentAccountBalanceChanged,

        /// <summary>
        /// SubscriptionServiceCreditAccountBalanceChanged.
        /// </summary>
        [EnumMember(Value = "subscription_service_credit_account_balance_changed")]
        SubscriptionServiceCreditAccountBalanceChanged,

        /// <summary>
        /// CustomFieldValueChange.
        /// </summary>
        [EnumMember(Value = "custom_field_value_change")]
        CustomFieldValueChange,

        /// <summary>
        /// ItemPricePointChanged.
        /// </summary>
        [EnumMember(Value = "item_price_point_changed")]
        ItemPricePointChanged,

        /// <summary>
        /// RenewalSuccessRecreated.
        /// </summary>
        [EnumMember(Value = "renewal_success_recreated")]
        RenewalSuccessRecreated,

        /// <summary>
        /// RenewalFailureRecreated.
        /// </summary>
        [EnumMember(Value = "renewal_failure_recreated")]
        RenewalFailureRecreated,

        /// <summary>
        /// PaymentSuccessRecreated.
        /// </summary>
        [EnumMember(Value = "payment_success_recreated")]
        PaymentSuccessRecreated,

        /// <summary>
        /// PaymentFailureRecreated.
        /// </summary>
        [EnumMember(Value = "payment_failure_recreated")]
        PaymentFailureRecreated,

        /// <summary>
        /// SubscriptionDeletion.
        /// </summary>
        [EnumMember(Value = "subscription_deletion")]
        SubscriptionDeletion,

        /// <summary>
        /// SubscriptionGroupBankAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_group_bank_account_update")]
        SubscriptionGroupBankAccountUpdate,

        /// <summary>
        /// SubscriptionPaypalAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_paypal_account_update")]
        SubscriptionPaypalAccountUpdate,

        /// <summary>
        /// SubscriptionGroupPaypalAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_group_paypal_account_update")]
        SubscriptionGroupPaypalAccountUpdate,

        /// <summary>
        /// SubscriptionCustomerChange.
        /// </summary>
        [EnumMember(Value = "subscription_customer_change")]
        SubscriptionCustomerChange,

        /// <summary>
        /// AccountTransactionChanged.
        /// </summary>
        [EnumMember(Value = "account_transaction_changed")]
        AccountTransactionChanged,

        /// <summary>
        /// GoCardlessPaymentPaidOut.
        /// </summary>
        [EnumMember(Value = "go_cardless_payment_paid_out")]
        GoCardlessPaymentPaidOut,

        /// <summary>
        /// GoCardlessPaymentRejected.
        /// </summary>
        [EnumMember(Value = "go_cardless_payment_rejected")]
        GoCardlessPaymentRejected,

        /// <summary>
        /// GoCardlessPaymentPending.
        /// </summary>
        [EnumMember(Value = "go_cardless_payment_pending")]
        GoCardlessPaymentPending,

        /// <summary>
        /// StripeDirectDebitPaymentPaidOut.
        /// </summary>
        [EnumMember(Value = "stripe_direct_debit_payment_paid_out")]
        StripeDirectDebitPaymentPaidOut,

        /// <summary>
        /// StripeDirectDebitPaymentRejected.
        /// </summary>
        [EnumMember(Value = "stripe_direct_debit_payment_rejected")]
        StripeDirectDebitPaymentRejected,

        /// <summary>
        /// StripeDirectDebitPaymentPending.
        /// </summary>
        [EnumMember(Value = "stripe_direct_debit_payment_pending")]
        StripeDirectDebitPaymentPending,

        /// <summary>
        /// MaxioPaymentsDirectDebitPaymentPaidOut.
        /// </summary>
        [EnumMember(Value = "maxio_payments_direct_debit_payment_paid_out")]
        MaxioPaymentsDirectDebitPaymentPaidOut,

        /// <summary>
        /// MaxioPaymentsDirectDebitPaymentRejected.
        /// </summary>
        [EnumMember(Value = "maxio_payments_direct_debit_payment_rejected")]
        MaxioPaymentsDirectDebitPaymentRejected,

        /// <summary>
        /// MaxioPaymentsDirectDebitPaymentPending.
        /// </summary>
        [EnumMember(Value = "maxio_payments_direct_debit_payment_pending")]
        MaxioPaymentsDirectDebitPaymentPending,

        /// <summary>
        /// InvoiceInCollectionsCanceled.
        /// </summary>
        [EnumMember(Value = "invoice_in_collections_canceled")]
        InvoiceInCollectionsCanceled,

        /// <summary>
        /// SubscriptionAddedToGroup.
        /// </summary>
        [EnumMember(Value = "subscription_added_to_group")]
        SubscriptionAddedToGroup,

        /// <summary>
        /// SubscriptionRemovedFromGroup.
        /// </summary>
        [EnumMember(Value = "subscription_removed_from_group")]
        SubscriptionRemovedFromGroup,

        /// <summary>
        /// ChargebackOpened.
        /// </summary>
        [EnumMember(Value = "chargeback_opened")]
        ChargebackOpened,

        /// <summary>
        /// ChargebackLost.
        /// </summary>
        [EnumMember(Value = "chargeback_lost")]
        ChargebackLost,

        /// <summary>
        /// ChargebackAccepted.
        /// </summary>
        [EnumMember(Value = "chargeback_accepted")]
        ChargebackAccepted,

        /// <summary>
        /// ChargebackClosed.
        /// </summary>
        [EnumMember(Value = "chargeback_closed")]
        ChargebackClosed,

        /// <summary>
        /// ChargebackWon.
        /// </summary>
        [EnumMember(Value = "chargeback_won")]
        ChargebackWon,

        /// <summary>
        /// PaymentCollectionMethodChanged.
        /// </summary>
        [EnumMember(Value = "payment_collection_method_changed")]
        PaymentCollectionMethodChanged,

        /// <summary>
        /// ComponentBillingDateChanged.
        /// </summary>
        [EnumMember(Value = "component_billing_date_changed")]
        ComponentBillingDateChanged,

        /// <summary>
        /// SubscriptionTermRenewalScheduled.
        /// </summary>
        [EnumMember(Value = "subscription_term_renewal_scheduled")]
        SubscriptionTermRenewalScheduled,

        /// <summary>
        /// SubscriptionTermRenewalPending.
        /// </summary>
        [EnumMember(Value = "subscription_term_renewal_pending")]
        SubscriptionTermRenewalPending,

        /// <summary>
        /// SubscriptionTermRenewalActivated.
        /// </summary>
        [EnumMember(Value = "subscription_term_renewal_activated")]
        SubscriptionTermRenewalActivated,

        /// <summary>
        /// SubscriptionTermRenewalRemoved.
        /// </summary>
        [EnumMember(Value = "subscription_term_renewal_removed")]
        SubscriptionTermRenewalRemoved
    }
}