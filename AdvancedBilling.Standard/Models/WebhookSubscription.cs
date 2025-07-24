// <copyright file="WebhookSubscription.cs" company="APIMatic">
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
    /// WebhookSubscription.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum WebhookSubscription
    {
        /// <summary>
        /// BillingDateChange.
        /// </summary>
        [EnumMember(Value = "billing_date_change")]
        BillingDateChange,

        /// <summary>
        /// ComponentAllocationChange.
        /// </summary>
        [EnumMember(Value = "component_allocation_change")]
        ComponentAllocationChange,

        /// <summary>
        /// CustomerCreate.
        /// </summary>
        [EnumMember(Value = "customer_create")]
        CustomerCreate,

        /// <summary>
        /// CustomerUpdate.
        /// </summary>
        [EnumMember(Value = "customer_update")]
        CustomerUpdate,

        /// <summary>
        /// DunningStepReached.
        /// </summary>
        [EnumMember(Value = "dunning_step_reached")]
        DunningStepReached,

        /// <summary>
        /// ExpiringCard.
        /// </summary>
        [EnumMember(Value = "expiring_card")]
        ExpiringCard,

        /// <summary>
        /// ExpirationDateChange.
        /// </summary>
        [EnumMember(Value = "expiration_date_change")]
        ExpirationDateChange,

        /// <summary>
        /// InvoiceIssued.
        /// </summary>
        [EnumMember(Value = "invoice_issued")]
        InvoiceIssued,

        /// <summary>
        /// MeteredUsage.
        /// </summary>
        [EnumMember(Value = "metered_usage")]
        MeteredUsage,

        /// <summary>
        /// PaymentFailure.
        /// </summary>
        [EnumMember(Value = "payment_failure")]
        PaymentFailure,

        /// <summary>
        /// PaymentSuccess.
        /// </summary>
        [EnumMember(Value = "payment_success")]
        PaymentSuccess,

        /// <summary>
        /// DirectDebitPaymentPending.
        /// </summary>
        [EnumMember(Value = "direct_debit_payment_pending")]
        DirectDebitPaymentPending,

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
        /// PrepaidSubscriptionBalanceChanged.
        /// </summary>
        [EnumMember(Value = "prepaid_subscription_balance_changed")]
        PrepaidSubscriptionBalanceChanged,

        /// <summary>
        /// PrepaidUsage.
        /// </summary>
        [EnumMember(Value = "prepaid_usage")]
        PrepaidUsage,

        /// <summary>
        /// RefundFailure.
        /// </summary>
        [EnumMember(Value = "refund_failure")]
        RefundFailure,

        /// <summary>
        /// RefundSuccess.
        /// </summary>
        [EnumMember(Value = "refund_success")]
        RefundSuccess,

        /// <summary>
        /// RenewalFailure.
        /// </summary>
        [EnumMember(Value = "renewal_failure")]
        RenewalFailure,

        /// <summary>
        /// RenewalSuccess.
        /// </summary>
        [EnumMember(Value = "renewal_success")]
        RenewalSuccess,

        /// <summary>
        /// SignupFailure.
        /// </summary>
        [EnumMember(Value = "signup_failure")]
        SignupFailure,

        /// <summary>
        /// SignupSuccess.
        /// </summary>
        [EnumMember(Value = "signup_success")]
        SignupSuccess,

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
        /// SubscriptionProductChange.
        /// </summary>
        [EnumMember(Value = "subscription_product_change")]
        SubscriptionProductChange,

        /// <summary>
        /// SubscriptionStateChange.
        /// </summary>
        [EnumMember(Value = "subscription_state_change")]
        SubscriptionStateChange,

        /// <summary>
        /// TrialEndNotice.
        /// </summary>
        [EnumMember(Value = "trial_end_notice")]
        TrialEndNotice,

        /// <summary>
        /// UpcomingRenewalNotice.
        /// </summary>
        [EnumMember(Value = "upcoming_renewal_notice")]
        UpcomingRenewalNotice,

        /// <summary>
        /// UpgradeDowngradeFailure.
        /// </summary>
        [EnumMember(Value = "upgrade_downgrade_failure")]
        UpgradeDowngradeFailure,

        /// <summary>
        /// UpgradeDowngradeSuccess.
        /// </summary>
        [EnumMember(Value = "upgrade_downgrade_success")]
        UpgradeDowngradeSuccess,

        /// <summary>
        /// PendingCancellationChange.
        /// </summary>
        [EnumMember(Value = "pending_cancellation_change")]
        PendingCancellationChange,

        /// <summary>
        /// SubscriptionPrepaymentAccountBalanceChanged.
        /// </summary>
        [EnumMember(Value = "subscription_prepayment_account_balance_changed")]
        SubscriptionPrepaymentAccountBalanceChanged,

        /// <summary>
        /// SubscriptionServiceCreditAccountBalanceChanged.
        /// </summary>
        [EnumMember(Value = "subscription_service_credit_account_balance_changed")]
        SubscriptionServiceCreditAccountBalanceChanged
    }
}