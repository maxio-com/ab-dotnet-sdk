// <copyright file="EventEventSpecificData.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<EventEventSpecificData>),
        new[] {
            typeof(SubscriptionProductChangeCase),
            typeof(SubscriptionProductChangeScheduledCase),
            typeof(SubscriptionStateChangeCase),
            typeof(PaymentRelatedEventsCase),
            typeof(RefundSuccessCase),
            typeof(ComponentAllocationChangeCase),
            typeof(MeteredUsageCase),
            typeof(PrepaidUsageCase),
            typeof(DunningStepReachedCase),
            typeof(InvoiceIssuedCase),
            typeof(PendingCancellationChangeCase),
            typeof(PrepaidSubscriptionBalanceChangedCase),
            typeof(ProformaInvoiceIssuedCase),
            typeof(SubscriptionGroupSignupEventDataCase),
            typeof(CreditAccountBalanceChangedCase),
            typeof(PrepaymentAccountBalanceChangedCase),
            typeof(PaymentCollectionMethodChangedCase),
            typeof(ItemPricePointChangedCase),
            typeof(CustomFieldValueChangeCase),
            typeof(ChjsTokenizationSuccessCase),
            typeof(ChjsTokenizationFailureCase)
        },
        true
    )]
    public abstract class EventEventSpecificData
    {
        /// <summary>
        /// This is Subscription Product Change case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided SubscriptionProductChange value.
        /// </returns>
        public static EventEventSpecificData FromSubscriptionProductChange(SubscriptionProductChange subscriptionProductChange)
        {
            return new SubscriptionProductChangeCase().Set(subscriptionProductChange);
        }

        /// <summary>
        /// This is Subscription Product Change Scheduled case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided SubscriptionProductChangeScheduled value.
        /// </returns>
        public static EventEventSpecificData FromSubscriptionProductChangeScheduled(SubscriptionProductChangeScheduled subscriptionProductChangeScheduled)
        {
            return new SubscriptionProductChangeScheduledCase().Set(subscriptionProductChangeScheduled);
        }

        /// <summary>
        /// This is Subscription State Change case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided SubscriptionStateChange value.
        /// </returns>
        public static EventEventSpecificData FromSubscriptionStateChange(SubscriptionStateChange subscriptionStateChange)
        {
            return new SubscriptionStateChangeCase().Set(subscriptionStateChange);
        }

        /// <summary>
        /// This is Payment Related Events case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PaymentRelatedEvents value.
        /// </returns>
        public static EventEventSpecificData FromPaymentRelatedEvents(PaymentRelatedEvents paymentRelatedEvents)
        {
            return new PaymentRelatedEventsCase().Set(paymentRelatedEvents);
        }

        /// <summary>
        /// This is Refund Success case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided RefundSuccess value.
        /// </returns>
        public static EventEventSpecificData FromRefundSuccess(RefundSuccess refundSuccess)
        {
            return new RefundSuccessCase().Set(refundSuccess);
        }

        /// <summary>
        /// This is Component Allocation Change case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided ComponentAllocationChange value.
        /// </returns>
        public static EventEventSpecificData FromComponentAllocationChange(ComponentAllocationChange componentAllocationChange)
        {
            return new ComponentAllocationChangeCase().Set(componentAllocationChange);
        }

        /// <summary>
        /// This is Metered Usage case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided MeteredUsage value.
        /// </returns>
        public static EventEventSpecificData FromMeteredUsage(MeteredUsage meteredUsage)
        {
            return new MeteredUsageCase().Set(meteredUsage);
        }

        /// <summary>
        /// This is Prepaid Usage case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PrepaidUsage value.
        /// </returns>
        public static EventEventSpecificData FromPrepaidUsage(PrepaidUsage prepaidUsage)
        {
            return new PrepaidUsageCase().Set(prepaidUsage);
        }

        /// <summary>
        /// This is Dunning Step Reached case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided DunningStepReached value.
        /// </returns>
        public static EventEventSpecificData FromDunningStepReached(DunningStepReached dunningStepReached)
        {
            return new DunningStepReachedCase().Set(dunningStepReached);
        }

        /// <summary>
        /// This is Invoice Issued case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided InvoiceIssued value.
        /// </returns>
        public static EventEventSpecificData FromInvoiceIssued(InvoiceIssued invoiceIssued)
        {
            return new InvoiceIssuedCase().Set(invoiceIssued);
        }

        /// <summary>
        /// This is Pending Cancellation Change case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PendingCancellationChange value.
        /// </returns>
        public static EventEventSpecificData FromPendingCancellationChange(PendingCancellationChange pendingCancellationChange)
        {
            return new PendingCancellationChangeCase().Set(pendingCancellationChange);
        }

        /// <summary>
        /// This is Prepaid Subscription Balance Changed case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PrepaidSubscriptionBalanceChanged value.
        /// </returns>
        public static EventEventSpecificData FromPrepaidSubscriptionBalanceChanged(PrepaidSubscriptionBalanceChanged prepaidSubscriptionBalanceChanged)
        {
            return new PrepaidSubscriptionBalanceChangedCase().Set(prepaidSubscriptionBalanceChanged);
        }

        /// <summary>
        /// This is Proforma Invoice Issued case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided ProformaInvoiceIssued value.
        /// </returns>
        public static EventEventSpecificData FromProformaInvoiceIssued(ProformaInvoiceIssued proformaInvoiceIssued)
        {
            return new ProformaInvoiceIssuedCase().Set(proformaInvoiceIssued);
        }

        /// <summary>
        /// This is Subscription Group Signup Event Data case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided SubscriptionGroupSignupEventData value.
        /// </returns>
        public static EventEventSpecificData FromSubscriptionGroupSignupEventData(SubscriptionGroupSignupEventData subscriptionGroupSignupEventData)
        {
            return new SubscriptionGroupSignupEventDataCase().Set(subscriptionGroupSignupEventData);
        }

        /// <summary>
        /// This is Credit Account Balance Changed case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided CreditAccountBalanceChanged value.
        /// </returns>
        public static EventEventSpecificData FromCreditAccountBalanceChanged(CreditAccountBalanceChanged creditAccountBalanceChanged)
        {
            return new CreditAccountBalanceChangedCase().Set(creditAccountBalanceChanged);
        }

        /// <summary>
        /// This is Prepayment Account Balance Changed case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PrepaymentAccountBalanceChanged value.
        /// </returns>
        public static EventEventSpecificData FromPrepaymentAccountBalanceChanged(PrepaymentAccountBalanceChanged prepaymentAccountBalanceChanged)
        {
            return new PrepaymentAccountBalanceChangedCase().Set(prepaymentAccountBalanceChanged);
        }

        /// <summary>
        /// This is Payment Collection Method Changed case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided PaymentCollectionMethodChanged value.
        /// </returns>
        public static EventEventSpecificData FromPaymentCollectionMethodChanged(PaymentCollectionMethodChanged paymentCollectionMethodChanged)
        {
            return new PaymentCollectionMethodChangedCase().Set(paymentCollectionMethodChanged);
        }

        /// <summary>
        /// This is Item Price Point Changed case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided ItemPricePointChanged value.
        /// </returns>
        public static EventEventSpecificData FromItemPricePointChanged(ItemPricePointChanged itemPricePointChanged)
        {
            return new ItemPricePointChangedCase().Set(itemPricePointChanged);
        }

        /// <summary>
        /// This is Custom Field Value Change case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided CustomFieldValueChange value.
        /// </returns>
        public static EventEventSpecificData FromCustomFieldValueChange(CustomFieldValueChange customFieldValueChange)
        {
            return new CustomFieldValueChangeCase().Set(customFieldValueChange);
        }

        /// <summary>
        /// This is Chjs Tokenization Success case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided ChjsTokenizationSuccess value.
        /// </returns>
        public static EventEventSpecificData FromChjsTokenizationSuccess(ChjsTokenizationSuccess chjsTokenizationSuccess)
        {
            return new ChjsTokenizationSuccessCase().Set(chjsTokenizationSuccess);
        }

        /// <summary>
        /// This is Chjs Tokenization Failure case.
        /// </summary>
        /// <returns>
        /// The EventEventSpecificData instance, wrapping the provided ChjsTokenizationFailure value.
        /// </returns>
        public static EventEventSpecificData FromChjsTokenizationFailure(ChjsTokenizationFailure chjsTokenizationFailure)
        {
            return new ChjsTokenizationFailureCase().Set(chjsTokenizationFailure);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<SubscriptionProductChange, T> subscriptionProductChange,
            Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
            Func<SubscriptionStateChange, T> subscriptionStateChange,
            Func<PaymentRelatedEvents, T> paymentRelatedEvents,
            Func<RefundSuccess, T> refundSuccess,
            Func<ComponentAllocationChange, T> componentAllocationChange,
            Func<MeteredUsage, T> meteredUsage,
            Func<PrepaidUsage, T> prepaidUsage,
            Func<DunningStepReached, T> dunningStepReached,
            Func<InvoiceIssued, T> invoiceIssued,
            Func<PendingCancellationChange, T> pendingCancellationChange,
            Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
            Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
            Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
            Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
            Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
            Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
            Func<ItemPricePointChanged, T> itemPricePointChanged,
            Func<CustomFieldValueChange, T> customFieldValueChange,
            Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
            Func<ChjsTokenizationFailure, T> chjsTokenizationFailure);

        /// <summary>
        /// Method to match from the provided one-of cases. The parameters represent
        /// optional callback functions for one-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<SubscriptionProductChange, T> subscriptionProductChange = null,
            Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled = null,
            Func<SubscriptionStateChange, T> subscriptionStateChange = null,
            Func<PaymentRelatedEvents, T> paymentRelatedEvents = null,
            Func<RefundSuccess, T> refundSuccess = null,
            Func<ComponentAllocationChange, T> componentAllocationChange = null,
            Func<MeteredUsage, T> meteredUsage = null,
            Func<PrepaidUsage, T> prepaidUsage = null,
            Func<DunningStepReached, T> dunningStepReached = null,
            Func<InvoiceIssued, T> invoiceIssued = null,
            Func<PendingCancellationChange, T> pendingCancellationChange = null,
            Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged = null,
            Func<ProformaInvoiceIssued, T> proformaInvoiceIssued = null,
            Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData = null,
            Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged = null,
            Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged = null,
            Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged = null,
            Func<ItemPricePointChanged, T> itemPricePointChanged = null,
            Func<CustomFieldValueChange, T> customFieldValueChange = null,
            Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess = null,
            Func<ChjsTokenizationFailure, T> chjsTokenizationFailure = null) =>
                Match(subscriptionProductChange, subscriptionProductChangeScheduled, subscriptionStateChange, paymentRelatedEvents, refundSuccess, componentAllocationChange, meteredUsage, prepaidUsage, dunningStepReached, invoiceIssued, pendingCancellationChange, prepaidSubscriptionBalanceChanged, proformaInvoiceIssued, subscriptionGroupSignupEventData, creditAccountBalanceChanged, prepaymentAccountBalanceChanged, paymentCollectionMethodChanged, itemPricePointChanged, customFieldValueChange, chjsTokenizationSuccess, chjsTokenizationFailure);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionProductChangeCase, SubscriptionProductChange>))]
        private sealed class SubscriptionProductChangeCase : EventEventSpecificData, ICaseValue<SubscriptionProductChangeCase, SubscriptionProductChange>
        {
            public SubscriptionProductChange Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   subscriptionProductChange != null ? subscriptionProductChange(Value) : default;

            public SubscriptionProductChangeCase Set(SubscriptionProductChange value)
            {
                Value = value;
                return this;
            }

            public SubscriptionProductChange Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionProductChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionProductChangeScheduledCase, SubscriptionProductChangeScheduled>))]
        private sealed class SubscriptionProductChangeScheduledCase : EventEventSpecificData, ICaseValue<SubscriptionProductChangeScheduledCase, SubscriptionProductChangeScheduled>
        {
            public SubscriptionProductChangeScheduled Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   subscriptionProductChangeScheduled != null ? subscriptionProductChangeScheduled(Value) : default;

            public SubscriptionProductChangeScheduledCase Set(SubscriptionProductChangeScheduled value)
            {
                Value = value;
                return this;
            }

            public SubscriptionProductChangeScheduled Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionProductChangeScheduledCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionStateChangeCase, SubscriptionStateChange>))]
        private sealed class SubscriptionStateChangeCase : EventEventSpecificData, ICaseValue<SubscriptionStateChangeCase, SubscriptionStateChange>
        {
            public SubscriptionStateChange Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   subscriptionStateChange != null ? subscriptionStateChange(Value) : default;

            public SubscriptionStateChangeCase Set(SubscriptionStateChange value)
            {
                Value = value;
                return this;
            }

            public SubscriptionStateChange Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionStateChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentRelatedEventsCase, PaymentRelatedEvents>))]
        private sealed class PaymentRelatedEventsCase : EventEventSpecificData, ICaseValue<PaymentRelatedEventsCase, PaymentRelatedEvents>
        {
            public PaymentRelatedEvents Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   paymentRelatedEvents != null ? paymentRelatedEvents(Value) : default;

            public PaymentRelatedEventsCase Set(PaymentRelatedEvents value)
            {
                Value = value;
                return this;
            }

            public PaymentRelatedEvents Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentRelatedEventsCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundSuccessCase, RefundSuccess>))]
        private sealed class RefundSuccessCase : EventEventSpecificData, ICaseValue<RefundSuccessCase, RefundSuccess>
        {
            public RefundSuccess Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   refundSuccess != null ? refundSuccess(Value) : default;

            public RefundSuccessCase Set(RefundSuccess value)
            {
                Value = value;
                return this;
            }

            public RefundSuccess Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RefundSuccessCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ComponentAllocationChangeCase, ComponentAllocationChange>))]
        private sealed class ComponentAllocationChangeCase : EventEventSpecificData, ICaseValue<ComponentAllocationChangeCase, ComponentAllocationChange>
        {
            public ComponentAllocationChange Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   componentAllocationChange != null ? componentAllocationChange(Value) : default;

            public ComponentAllocationChangeCase Set(ComponentAllocationChange value)
            {
                Value = value;
                return this;
            }

            public ComponentAllocationChange Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ComponentAllocationChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MeteredUsageCase, MeteredUsage>))]
        private sealed class MeteredUsageCase : EventEventSpecificData, ICaseValue<MeteredUsageCase, MeteredUsage>
        {
            public MeteredUsage Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   meteredUsage != null ? meteredUsage(Value) : default;

            public MeteredUsageCase Set(MeteredUsage value)
            {
                Value = value;
                return this;
            }

            public MeteredUsage Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MeteredUsageCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaidUsageCase, PrepaidUsage>))]
        private sealed class PrepaidUsageCase : EventEventSpecificData, ICaseValue<PrepaidUsageCase, PrepaidUsage>
        {
            public PrepaidUsage Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   prepaidUsage != null ? prepaidUsage(Value) : default;

            public PrepaidUsageCase Set(PrepaidUsage value)
            {
                Value = value;
                return this;
            }

            public PrepaidUsage Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaidUsageCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DunningStepReachedCase, DunningStepReached>))]
        private sealed class DunningStepReachedCase : EventEventSpecificData, ICaseValue<DunningStepReachedCase, DunningStepReached>
        {
            public DunningStepReached Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   dunningStepReached != null ? dunningStepReached(Value) : default;

            public DunningStepReachedCase Set(DunningStepReached value)
            {
                Value = value;
                return this;
            }

            public DunningStepReached Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DunningStepReachedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InvoiceIssuedCase, InvoiceIssued>))]
        private sealed class InvoiceIssuedCase : EventEventSpecificData, ICaseValue<InvoiceIssuedCase, InvoiceIssued>
        {
            public InvoiceIssued Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   invoiceIssued != null ? invoiceIssued(Value) : default;

            public InvoiceIssuedCase Set(InvoiceIssued value)
            {
                Value = value;
                return this;
            }

            public InvoiceIssued Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is InvoiceIssuedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PendingCancellationChangeCase, PendingCancellationChange>))]
        private sealed class PendingCancellationChangeCase : EventEventSpecificData, ICaseValue<PendingCancellationChangeCase, PendingCancellationChange>
        {
            public PendingCancellationChange Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   pendingCancellationChange != null ? pendingCancellationChange(Value) : default;

            public PendingCancellationChangeCase Set(PendingCancellationChange value)
            {
                Value = value;
                return this;
            }

            public PendingCancellationChange Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PendingCancellationChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaidSubscriptionBalanceChangedCase, PrepaidSubscriptionBalanceChanged>))]
        private sealed class PrepaidSubscriptionBalanceChangedCase : EventEventSpecificData, ICaseValue<PrepaidSubscriptionBalanceChangedCase, PrepaidSubscriptionBalanceChanged>
        {
            public PrepaidSubscriptionBalanceChanged Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   prepaidSubscriptionBalanceChanged != null ? prepaidSubscriptionBalanceChanged(Value) : default;

            public PrepaidSubscriptionBalanceChangedCase Set(PrepaidSubscriptionBalanceChanged value)
            {
                Value = value;
                return this;
            }

            public PrepaidSubscriptionBalanceChanged Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaidSubscriptionBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ProformaInvoiceIssuedCase, ProformaInvoiceIssued>))]
        private sealed class ProformaInvoiceIssuedCase : EventEventSpecificData, ICaseValue<ProformaInvoiceIssuedCase, ProformaInvoiceIssued>
        {
            public ProformaInvoiceIssued Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   proformaInvoiceIssued != null ? proformaInvoiceIssued(Value) : default;

            public ProformaInvoiceIssuedCase Set(ProformaInvoiceIssued value)
            {
                Value = value;
                return this;
            }

            public ProformaInvoiceIssued Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ProformaInvoiceIssuedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupSignupEventDataCase, SubscriptionGroupSignupEventData>))]
        private sealed class SubscriptionGroupSignupEventDataCase : EventEventSpecificData, ICaseValue<SubscriptionGroupSignupEventDataCase, SubscriptionGroupSignupEventData>
        {
            public SubscriptionGroupSignupEventData Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   subscriptionGroupSignupEventData != null ? subscriptionGroupSignupEventData(Value) : default;

            public SubscriptionGroupSignupEventDataCase Set(SubscriptionGroupSignupEventData value)
            {
                Value = value;
                return this;
            }

            public SubscriptionGroupSignupEventData Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionGroupSignupEventDataCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreditAccountBalanceChangedCase, CreditAccountBalanceChanged>))]
        private sealed class CreditAccountBalanceChangedCase : EventEventSpecificData, ICaseValue<CreditAccountBalanceChangedCase, CreditAccountBalanceChanged>
        {
            public CreditAccountBalanceChanged Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   creditAccountBalanceChanged != null ? creditAccountBalanceChanged(Value) : default;

            public CreditAccountBalanceChangedCase Set(CreditAccountBalanceChanged value)
            {
                Value = value;
                return this;
            }

            public CreditAccountBalanceChanged Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreditAccountBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaymentAccountBalanceChangedCase, PrepaymentAccountBalanceChanged>))]
        private sealed class PrepaymentAccountBalanceChangedCase : EventEventSpecificData, ICaseValue<PrepaymentAccountBalanceChangedCase, PrepaymentAccountBalanceChanged>
        {
            public PrepaymentAccountBalanceChanged Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   prepaymentAccountBalanceChanged != null ? prepaymentAccountBalanceChanged(Value) : default;

            public PrepaymentAccountBalanceChangedCase Set(PrepaymentAccountBalanceChanged value)
            {
                Value = value;
                return this;
            }

            public PrepaymentAccountBalanceChanged Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaymentAccountBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentCollectionMethodChangedCase, PaymentCollectionMethodChanged>))]
        private sealed class PaymentCollectionMethodChangedCase : EventEventSpecificData, ICaseValue<PaymentCollectionMethodChangedCase, PaymentCollectionMethodChanged>
        {
            public PaymentCollectionMethodChanged Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   paymentCollectionMethodChanged != null ? paymentCollectionMethodChanged(Value) : default;

            public PaymentCollectionMethodChangedCase Set(PaymentCollectionMethodChanged value)
            {
                Value = value;
                return this;
            }

            public PaymentCollectionMethodChanged Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentCollectionMethodChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ItemPricePointChangedCase, ItemPricePointChanged>))]
        private sealed class ItemPricePointChangedCase : EventEventSpecificData, ICaseValue<ItemPricePointChangedCase, ItemPricePointChanged>
        {
            public ItemPricePointChanged Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   itemPricePointChanged != null ? itemPricePointChanged(Value) : default;

            public ItemPricePointChangedCase Set(ItemPricePointChanged value)
            {
                Value = value;
                return this;
            }

            public ItemPricePointChanged Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ItemPricePointChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomFieldValueChangeCase, CustomFieldValueChange>))]
        private sealed class CustomFieldValueChangeCase : EventEventSpecificData, ICaseValue<CustomFieldValueChangeCase, CustomFieldValueChange>
        {
            public CustomFieldValueChange Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   customFieldValueChange != null ? customFieldValueChange(Value) : default;

            public CustomFieldValueChangeCase Set(CustomFieldValueChange value)
            {
                Value = value;
                return this;
            }

            public CustomFieldValueChange Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CustomFieldValueChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChjsTokenizationSuccessCase, ChjsTokenizationSuccess>))]
        private sealed class ChjsTokenizationSuccessCase : EventEventSpecificData, ICaseValue<ChjsTokenizationSuccessCase, ChjsTokenizationSuccess>
        {
            public ChjsTokenizationSuccess Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   chjsTokenizationSuccess != null ? chjsTokenizationSuccess(Value) : default;

            public ChjsTokenizationSuccessCase Set(ChjsTokenizationSuccess value)
            {
                Value = value;
                return this;
            }

            public ChjsTokenizationSuccess Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ChjsTokenizationSuccessCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChjsTokenizationFailureCase, ChjsTokenizationFailure>))]
        private sealed class ChjsTokenizationFailureCase : EventEventSpecificData, ICaseValue<ChjsTokenizationFailureCase, ChjsTokenizationFailure>
        {
            public ChjsTokenizationFailure Value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
                Func<SubscriptionProductChangeScheduled, T> subscriptionProductChangeScheduled,
                Func<SubscriptionStateChange, T> subscriptionStateChange,
                Func<PaymentRelatedEvents, T> paymentRelatedEvents,
                Func<RefundSuccess, T> refundSuccess,
                Func<ComponentAllocationChange, T> componentAllocationChange,
                Func<MeteredUsage, T> meteredUsage,
                Func<PrepaidUsage, T> prepaidUsage,
                Func<DunningStepReached, T> dunningStepReached,
                Func<InvoiceIssued, T> invoiceIssued,
                Func<PendingCancellationChange, T> pendingCancellationChange,
                Func<PrepaidSubscriptionBalanceChanged, T> prepaidSubscriptionBalanceChanged,
                Func<ProformaInvoiceIssued, T> proformaInvoiceIssued,
                Func<SubscriptionGroupSignupEventData, T> subscriptionGroupSignupEventData,
                Func<CreditAccountBalanceChanged, T> creditAccountBalanceChanged,
                Func<PrepaymentAccountBalanceChanged, T> prepaymentAccountBalanceChanged,
                Func<PaymentCollectionMethodChanged, T> paymentCollectionMethodChanged,
                Func<ItemPricePointChanged, T> itemPricePointChanged,
                Func<CustomFieldValueChange, T> customFieldValueChange,
                Func<ChjsTokenizationSuccess, T> chjsTokenizationSuccess,
                Func<ChjsTokenizationFailure, T> chjsTokenizationFailure) =>
                   chjsTokenizationFailure != null ? chjsTokenizationFailure(Value) : default;

            public ChjsTokenizationFailureCase Set(ChjsTokenizationFailure value)
            {
                Value = value;
                return this;
            }

            public ChjsTokenizationFailure Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ChjsTokenizationFailureCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}