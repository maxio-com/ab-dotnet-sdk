// <copyright file="EventEventSpecificData.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
        new Type[] {
            typeof(SubscriptionProductChangeCase),
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
            typeof(CustomFieldValueChangeCase)
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
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<SubscriptionProductChange, T> subscriptionProductChange,
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
            Func<CustomFieldValueChange, T> customFieldValueChange);

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionProductChangeCase, SubscriptionProductChange>))]
        private sealed class SubscriptionProductChangeCase : EventEventSpecificData, ICaseValue<SubscriptionProductChangeCase, SubscriptionProductChange>
        {
            public SubscriptionProductChange _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return subscriptionProductChange(_value);
            }

            public SubscriptionProductChangeCase Set(SubscriptionProductChange value)
            {
                _value = value;
                return this;
            }

            public SubscriptionProductChange Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionProductChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionStateChangeCase, SubscriptionStateChange>))]
        private sealed class SubscriptionStateChangeCase : EventEventSpecificData, ICaseValue<SubscriptionStateChangeCase, SubscriptionStateChange>
        {
            public SubscriptionStateChange _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return subscriptionStateChange(_value);
            }

            public SubscriptionStateChangeCase Set(SubscriptionStateChange value)
            {
                _value = value;
                return this;
            }

            public SubscriptionStateChange Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionStateChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentRelatedEventsCase, PaymentRelatedEvents>))]
        private sealed class PaymentRelatedEventsCase : EventEventSpecificData, ICaseValue<PaymentRelatedEventsCase, PaymentRelatedEvents>
        {
            public PaymentRelatedEvents _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return paymentRelatedEvents(_value);
            }

            public PaymentRelatedEventsCase Set(PaymentRelatedEvents value)
            {
                _value = value;
                return this;
            }

            public PaymentRelatedEvents Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentRelatedEventsCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundSuccessCase, RefundSuccess>))]
        private sealed class RefundSuccessCase : EventEventSpecificData, ICaseValue<RefundSuccessCase, RefundSuccess>
        {
            public RefundSuccess _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return refundSuccess(_value);
            }

            public RefundSuccessCase Set(RefundSuccess value)
            {
                _value = value;
                return this;
            }

            public RefundSuccess Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RefundSuccessCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ComponentAllocationChangeCase, ComponentAllocationChange>))]
        private sealed class ComponentAllocationChangeCase : EventEventSpecificData, ICaseValue<ComponentAllocationChangeCase, ComponentAllocationChange>
        {
            public ComponentAllocationChange _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return componentAllocationChange(_value);
            }

            public ComponentAllocationChangeCase Set(ComponentAllocationChange value)
            {
                _value = value;
                return this;
            }

            public ComponentAllocationChange Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ComponentAllocationChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MeteredUsageCase, MeteredUsage>))]
        private sealed class MeteredUsageCase : EventEventSpecificData, ICaseValue<MeteredUsageCase, MeteredUsage>
        {
            public MeteredUsage _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return meteredUsage(_value);
            }

            public MeteredUsageCase Set(MeteredUsage value)
            {
                _value = value;
                return this;
            }

            public MeteredUsage Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is MeteredUsageCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaidUsageCase, PrepaidUsage>))]
        private sealed class PrepaidUsageCase : EventEventSpecificData, ICaseValue<PrepaidUsageCase, PrepaidUsage>
        {
            public PrepaidUsage _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return prepaidUsage(_value);
            }

            public PrepaidUsageCase Set(PrepaidUsage value)
            {
                _value = value;
                return this;
            }

            public PrepaidUsage Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaidUsageCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<DunningStepReachedCase, DunningStepReached>))]
        private sealed class DunningStepReachedCase : EventEventSpecificData, ICaseValue<DunningStepReachedCase, DunningStepReached>
        {
            public DunningStepReached _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return dunningStepReached(_value);
            }

            public DunningStepReachedCase Set(DunningStepReached value)
            {
                _value = value;
                return this;
            }

            public DunningStepReached Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is DunningStepReachedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<InvoiceIssuedCase, InvoiceIssued>))]
        private sealed class InvoiceIssuedCase : EventEventSpecificData, ICaseValue<InvoiceIssuedCase, InvoiceIssued>
        {
            public InvoiceIssued _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return invoiceIssued(_value);
            }

            public InvoiceIssuedCase Set(InvoiceIssued value)
            {
                _value = value;
                return this;
            }

            public InvoiceIssued Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is InvoiceIssuedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PendingCancellationChangeCase, PendingCancellationChange>))]
        private sealed class PendingCancellationChangeCase : EventEventSpecificData, ICaseValue<PendingCancellationChangeCase, PendingCancellationChange>
        {
            public PendingCancellationChange _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return pendingCancellationChange(_value);
            }

            public PendingCancellationChangeCase Set(PendingCancellationChange value)
            {
                _value = value;
                return this;
            }

            public PendingCancellationChange Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PendingCancellationChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaidSubscriptionBalanceChangedCase, PrepaidSubscriptionBalanceChanged>))]
        private sealed class PrepaidSubscriptionBalanceChangedCase : EventEventSpecificData, ICaseValue<PrepaidSubscriptionBalanceChangedCase, PrepaidSubscriptionBalanceChanged>
        {
            public PrepaidSubscriptionBalanceChanged _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return prepaidSubscriptionBalanceChanged(_value);
            }

            public PrepaidSubscriptionBalanceChangedCase Set(PrepaidSubscriptionBalanceChanged value)
            {
                _value = value;
                return this;
            }

            public PrepaidSubscriptionBalanceChanged Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaidSubscriptionBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ProformaInvoiceIssuedCase, ProformaInvoiceIssued>))]
        private sealed class ProformaInvoiceIssuedCase : EventEventSpecificData, ICaseValue<ProformaInvoiceIssuedCase, ProformaInvoiceIssued>
        {
            public ProformaInvoiceIssued _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return proformaInvoiceIssued(_value);
            }

            public ProformaInvoiceIssuedCase Set(ProformaInvoiceIssued value)
            {
                _value = value;
                return this;
            }

            public ProformaInvoiceIssued Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ProformaInvoiceIssuedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<SubscriptionGroupSignupEventDataCase, SubscriptionGroupSignupEventData>))]
        private sealed class SubscriptionGroupSignupEventDataCase : EventEventSpecificData, ICaseValue<SubscriptionGroupSignupEventDataCase, SubscriptionGroupSignupEventData>
        {
            public SubscriptionGroupSignupEventData _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return subscriptionGroupSignupEventData(_value);
            }

            public SubscriptionGroupSignupEventDataCase Set(SubscriptionGroupSignupEventData value)
            {
                _value = value;
                return this;
            }

            public SubscriptionGroupSignupEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is SubscriptionGroupSignupEventDataCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreditAccountBalanceChangedCase, CreditAccountBalanceChanged>))]
        private sealed class CreditAccountBalanceChangedCase : EventEventSpecificData, ICaseValue<CreditAccountBalanceChangedCase, CreditAccountBalanceChanged>
        {
            public CreditAccountBalanceChanged _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return creditAccountBalanceChanged(_value);
            }

            public CreditAccountBalanceChangedCase Set(CreditAccountBalanceChanged value)
            {
                _value = value;
                return this;
            }

            public CreditAccountBalanceChanged Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreditAccountBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PrepaymentAccountBalanceChangedCase, PrepaymentAccountBalanceChanged>))]
        private sealed class PrepaymentAccountBalanceChangedCase : EventEventSpecificData, ICaseValue<PrepaymentAccountBalanceChangedCase, PrepaymentAccountBalanceChanged>
        {
            public PrepaymentAccountBalanceChanged _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return prepaymentAccountBalanceChanged(_value);
            }

            public PrepaymentAccountBalanceChangedCase Set(PrepaymentAccountBalanceChanged value)
            {
                _value = value;
                return this;
            }

            public PrepaymentAccountBalanceChanged Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PrepaymentAccountBalanceChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentCollectionMethodChangedCase, PaymentCollectionMethodChanged>))]
        private sealed class PaymentCollectionMethodChangedCase : EventEventSpecificData, ICaseValue<PaymentCollectionMethodChangedCase, PaymentCollectionMethodChanged>
        {
            public PaymentCollectionMethodChanged _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return paymentCollectionMethodChanged(_value);
            }

            public PaymentCollectionMethodChangedCase Set(PaymentCollectionMethodChanged value)
            {
                _value = value;
                return this;
            }

            public PaymentCollectionMethodChanged Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentCollectionMethodChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ItemPricePointChangedCase, ItemPricePointChanged>))]
        private sealed class ItemPricePointChangedCase : EventEventSpecificData, ICaseValue<ItemPricePointChangedCase, ItemPricePointChanged>
        {
            public ItemPricePointChanged _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return itemPricePointChanged(_value);
            }

            public ItemPricePointChangedCase Set(ItemPricePointChanged value)
            {
                _value = value;
                return this;
            }

            public ItemPricePointChanged Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ItemPricePointChangedCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomFieldValueChangeCase, CustomFieldValueChange>))]
        private sealed class CustomFieldValueChangeCase : EventEventSpecificData, ICaseValue<CustomFieldValueChangeCase, CustomFieldValueChange>
        {
            public CustomFieldValueChange _value;

            public override T Match<T>(
                Func<SubscriptionProductChange, T> subscriptionProductChange,
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
                Func<CustomFieldValueChange, T> customFieldValueChange)
            {
                return customFieldValueChange(_value);
            }

            public CustomFieldValueChangeCase Set(CustomFieldValueChange value)
            {
                _value = value;
                return this;
            }

            public CustomFieldValueChange Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CustomFieldValueChangeCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}