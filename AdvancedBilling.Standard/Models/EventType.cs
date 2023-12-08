// <copyright file="EventType.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// EventType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventType
    {
        /// <summary>
        /// AccountTransactionChanged.
        /// </summary>
        [EnumMember(Value = "account_transaction_changed")]
        AccountTransactionChanged,

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
        /// DunningStepReached.
        /// </summary>
        [EnumMember(Value = "dunning_step_reached")]
        DunningStepReached,

        /// <summary>
        /// ExpirationDateChange.
        /// </summary>
        [EnumMember(Value = "expiration_date_change")]
        ExpirationDateChange,

        /// <summary>
        /// ExpiringCard.
        /// </summary>
        [EnumMember(Value = "expiring_card")]
        ExpiringCard,

        /// <summary>
        /// MeteredUsage.
        /// </summary>
        [EnumMember(Value = "metered_usage")]
        MeteredUsage,

        /// <summary>
        /// PaymentSuccess.
        /// </summary>
        [EnumMember(Value = "payment_success")]
        PaymentSuccess,

        /// <summary>
        /// PaymentSuccessRecreated.
        /// </summary>
        [EnumMember(Value = "payment_success_recreated")]
        PaymentSuccessRecreated,

        /// <summary>
        /// PaymentFailure.
        /// </summary>
        [EnumMember(Value = "payment_failure")]
        PaymentFailure,

        /// <summary>
        /// PaymentFailureRecreated.
        /// </summary>
        [EnumMember(Value = "payment_failure_recreated")]
        PaymentFailureRecreated,

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
        /// RenewalSuccess.
        /// </summary>
        [EnumMember(Value = "renewal_success")]
        RenewalSuccess,

        /// <summary>
        /// RenewalSuccessRecreated.
        /// </summary>
        [EnumMember(Value = "renewal_success_recreated")]
        RenewalSuccessRecreated,

        /// <summary>
        /// RenewalFailure.
        /// </summary>
        [EnumMember(Value = "renewal_failure")]
        RenewalFailure,

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
        /// SubscriptionBankAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_bank_account_update")]
        SubscriptionBankAccountUpdate,

        /// <summary>
        /// SubscriptionDeletion.
        /// </summary>
        [EnumMember(Value = "subscription_deletion")]
        SubscriptionDeletion,

        /// <summary>
        /// SubscriptionPaypalAccountUpdate.
        /// </summary>
        [EnumMember(Value = "subscription_paypal_account_update")]
        SubscriptionPaypalAccountUpdate,

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
        /// UpcomingRenewalNotice.
        /// </summary>
        [EnumMember(Value = "upcoming_renewal_notice")]
        UpcomingRenewalNotice,

        /// <summary>
        /// CustomFieldValueChange.
        /// </summary>
        [EnumMember(Value = "custom_field_value_change")]
        CustomFieldValueChange,

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