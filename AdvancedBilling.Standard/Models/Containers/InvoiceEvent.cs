// <copyright file="InvoiceEvent.cs" company="APIMatic">
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
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InvoiceEvent>),
        new[] {
            typeof(ApplyCreditNoteEventCase),
            typeof(ApplyDebitNoteEventCase),
            typeof(ApplyPaymentEventCase),
            typeof(BackportInvoiceEventCase),
            typeof(ChangeChargebackStatusEventCase),
            typeof(ChangeInvoiceCollectionMethodEventCase),
            typeof(ChangeInvoiceStatusEventCase),
            typeof(CreateCreditNoteEventCase),
            typeof(CreateDebitNoteEventCase),
            typeof(FailedPaymentEventCase),
            typeof(IssueInvoiceEventCase),
            typeof(RefundInvoiceEventCase),
            typeof(RemovePaymentEventCase),
            typeof(VoidInvoiceEventCase),
            typeof(VoidRemainderEventCase)
        },
        new[] {
            "apply_credit_note",
            "apply_debit_note",
            "apply_payment",
            "backport_invoice",
            "change_chargeback_status",
            "change_invoice_collection_method",
            "change_invoice_status",
            "create_credit_note",
            "create_debit_note",
            "failed_payment",
            "issue_invoice",
            "refund_invoice",
            "remove_payment",
            "void_invoice",
            "void_remainder"
        },
        "event_type",
        false
    )]
    public abstract class InvoiceEvent
    {
        /// <summary>
        /// This is Apply Credit Note Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ApplyCreditNoteEvent value.
        /// </returns>
        public static InvoiceEvent FromApplyCreditNoteEvent(ApplyCreditNoteEvent applyCreditNoteEvent)
        {
            return new ApplyCreditNoteEventCase().Set(applyCreditNoteEvent);
        }

        /// <summary>
        /// This is Apply Debit Note Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ApplyDebitNoteEvent value.
        /// </returns>
        public static InvoiceEvent FromApplyDebitNoteEvent(ApplyDebitNoteEvent applyDebitNoteEvent)
        {
            return new ApplyDebitNoteEventCase().Set(applyDebitNoteEvent);
        }

        /// <summary>
        /// This is Apply Payment Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ApplyPaymentEvent value.
        /// </returns>
        public static InvoiceEvent FromApplyPaymentEvent(ApplyPaymentEvent applyPaymentEvent)
        {
            return new ApplyPaymentEventCase().Set(applyPaymentEvent);
        }

        /// <summary>
        /// This is Backport Invoice Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided BackportInvoiceEvent value.
        /// </returns>
        public static InvoiceEvent FromBackportInvoiceEvent(BackportInvoiceEvent backportInvoiceEvent)
        {
            return new BackportInvoiceEventCase().Set(backportInvoiceEvent);
        }

        /// <summary>
        /// This is Change Chargeback Status Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ChangeChargebackStatusEvent value.
        /// </returns>
        public static InvoiceEvent FromChangeChargebackStatusEvent(ChangeChargebackStatusEvent changeChargebackStatusEvent)
        {
            return new ChangeChargebackStatusEventCase().Set(changeChargebackStatusEvent);
        }

        /// <summary>
        /// This is Change Invoice Collection Method Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ChangeInvoiceCollectionMethodEvent value.
        /// </returns>
        public static InvoiceEvent FromChangeInvoiceCollectionMethodEvent(ChangeInvoiceCollectionMethodEvent changeInvoiceCollectionMethodEvent)
        {
            return new ChangeInvoiceCollectionMethodEventCase().Set(changeInvoiceCollectionMethodEvent);
        }

        /// <summary>
        /// This is Change Invoice Status Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided ChangeInvoiceStatusEvent value.
        /// </returns>
        public static InvoiceEvent FromChangeInvoiceStatusEvent(ChangeInvoiceStatusEvent changeInvoiceStatusEvent)
        {
            return new ChangeInvoiceStatusEventCase().Set(changeInvoiceStatusEvent);
        }

        /// <summary>
        /// This is Create Credit Note Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided CreateCreditNoteEvent value.
        /// </returns>
        public static InvoiceEvent FromCreateCreditNoteEvent(CreateCreditNoteEvent createCreditNoteEvent)
        {
            return new CreateCreditNoteEventCase().Set(createCreditNoteEvent);
        }

        /// <summary>
        /// This is Create Debit Note Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided CreateDebitNoteEvent value.
        /// </returns>
        public static InvoiceEvent FromCreateDebitNoteEvent(CreateDebitNoteEvent createDebitNoteEvent)
        {
            return new CreateDebitNoteEventCase().Set(createDebitNoteEvent);
        }

        /// <summary>
        /// This is Failed Payment Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided FailedPaymentEvent value.
        /// </returns>
        public static InvoiceEvent FromFailedPaymentEvent(FailedPaymentEvent failedPaymentEvent)
        {
            return new FailedPaymentEventCase().Set(failedPaymentEvent);
        }

        /// <summary>
        /// This is Issue Invoice Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided IssueInvoiceEvent value.
        /// </returns>
        public static InvoiceEvent FromIssueInvoiceEvent(IssueInvoiceEvent issueInvoiceEvent)
        {
            return new IssueInvoiceEventCase().Set(issueInvoiceEvent);
        }

        /// <summary>
        /// This is Refund Invoice Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided RefundInvoiceEvent value.
        /// </returns>
        public static InvoiceEvent FromRefundInvoiceEvent(RefundInvoiceEvent refundInvoiceEvent)
        {
            return new RefundInvoiceEventCase().Set(refundInvoiceEvent);
        }

        /// <summary>
        /// This is Remove Payment Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided RemovePaymentEvent value.
        /// </returns>
        public static InvoiceEvent FromRemovePaymentEvent(RemovePaymentEvent removePaymentEvent)
        {
            return new RemovePaymentEventCase().Set(removePaymentEvent);
        }

        /// <summary>
        /// This is Void Invoice Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided VoidInvoiceEvent value.
        /// </returns>
        public static InvoiceEvent FromVoidInvoiceEvent(VoidInvoiceEvent voidInvoiceEvent)
        {
            return new VoidInvoiceEventCase().Set(voidInvoiceEvent);
        }

        /// <summary>
        /// This is Void Remainder Event case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent instance, wrapping the provided VoidRemainderEvent value.
        /// </returns>
        public static InvoiceEvent FromVoidRemainderEvent(VoidRemainderEvent voidRemainderEvent)
        {
            return new VoidRemainderEventCase().Set(voidRemainderEvent);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
            Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
            Func<ApplyPaymentEvent, T> applyPaymentEvent,
            Func<BackportInvoiceEvent, T> backportInvoiceEvent,
            Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
            Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
            Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
            Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
            Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
            Func<FailedPaymentEvent, T> failedPaymentEvent,
            Func<IssueInvoiceEvent, T> issueInvoiceEvent,
            Func<RefundInvoiceEvent, T> refundInvoiceEvent,
            Func<RemovePaymentEvent, T> removePaymentEvent,
            Func<VoidInvoiceEvent, T> voidInvoiceEvent,
            Func<VoidRemainderEvent, T> voidRemainderEvent);

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent = null,
            Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent = null,
            Func<ApplyPaymentEvent, T> applyPaymentEvent = null,
            Func<BackportInvoiceEvent, T> backportInvoiceEvent = null,
            Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent = null,
            Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent = null,
            Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent = null,
            Func<CreateCreditNoteEvent, T> createCreditNoteEvent = null,
            Func<CreateDebitNoteEvent, T> createDebitNoteEvent = null,
            Func<FailedPaymentEvent, T> failedPaymentEvent = null,
            Func<IssueInvoiceEvent, T> issueInvoiceEvent = null,
            Func<RefundInvoiceEvent, T> refundInvoiceEvent = null,
            Func<RemovePaymentEvent, T> removePaymentEvent = null,
            Func<VoidInvoiceEvent, T> voidInvoiceEvent = null,
            Func<VoidRemainderEvent, T> voidRemainderEvent = null) =>
                Match(applyCreditNoteEvent, applyDebitNoteEvent, applyPaymentEvent, backportInvoiceEvent, changeChargebackStatusEvent, changeInvoiceCollectionMethodEvent, changeInvoiceStatusEvent, createCreditNoteEvent, createDebitNoteEvent, failedPaymentEvent, issueInvoiceEvent, refundInvoiceEvent, removePaymentEvent, voidInvoiceEvent, voidRemainderEvent);

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyCreditNoteEventCase, ApplyCreditNoteEvent>))]
        private sealed class ApplyCreditNoteEventCase : InvoiceEvent, ICaseValue<ApplyCreditNoteEventCase, ApplyCreditNoteEvent>
        {
            public ApplyCreditNoteEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   applyCreditNoteEvent != null ? applyCreditNoteEvent(Value) : default;

            public ApplyCreditNoteEventCase Set(ApplyCreditNoteEvent value)
            {
                Value = value;
                return this;
            }

            public ApplyCreditNoteEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ApplyCreditNoteEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyDebitNoteEventCase, ApplyDebitNoteEvent>))]
        private sealed class ApplyDebitNoteEventCase : InvoiceEvent, ICaseValue<ApplyDebitNoteEventCase, ApplyDebitNoteEvent>
        {
            public ApplyDebitNoteEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   applyDebitNoteEvent != null ? applyDebitNoteEvent(Value) : default;

            public ApplyDebitNoteEventCase Set(ApplyDebitNoteEvent value)
            {
                Value = value;
                return this;
            }

            public ApplyDebitNoteEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ApplyDebitNoteEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyPaymentEventCase, ApplyPaymentEvent>))]
        private sealed class ApplyPaymentEventCase : InvoiceEvent, ICaseValue<ApplyPaymentEventCase, ApplyPaymentEvent>
        {
            public ApplyPaymentEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   applyPaymentEvent != null ? applyPaymentEvent(Value) : default;

            public ApplyPaymentEventCase Set(ApplyPaymentEvent value)
            {
                Value = value;
                return this;
            }

            public ApplyPaymentEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ApplyPaymentEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BackportInvoiceEventCase, BackportInvoiceEvent>))]
        private sealed class BackportInvoiceEventCase : InvoiceEvent, ICaseValue<BackportInvoiceEventCase, BackportInvoiceEvent>
        {
            public BackportInvoiceEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   backportInvoiceEvent != null ? backportInvoiceEvent(Value) : default;

            public BackportInvoiceEventCase Set(BackportInvoiceEvent value)
            {
                Value = value;
                return this;
            }

            public BackportInvoiceEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is BackportInvoiceEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChangeChargebackStatusEventCase, ChangeChargebackStatusEvent>))]
        private sealed class ChangeChargebackStatusEventCase : InvoiceEvent, ICaseValue<ChangeChargebackStatusEventCase, ChangeChargebackStatusEvent>
        {
            public ChangeChargebackStatusEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   changeChargebackStatusEvent != null ? changeChargebackStatusEvent(Value) : default;

            public ChangeChargebackStatusEventCase Set(ChangeChargebackStatusEvent value)
            {
                Value = value;
                return this;
            }

            public ChangeChargebackStatusEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ChangeChargebackStatusEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChangeInvoiceCollectionMethodEventCase, ChangeInvoiceCollectionMethodEvent>))]
        private sealed class ChangeInvoiceCollectionMethodEventCase : InvoiceEvent, ICaseValue<ChangeInvoiceCollectionMethodEventCase, ChangeInvoiceCollectionMethodEvent>
        {
            public ChangeInvoiceCollectionMethodEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   changeInvoiceCollectionMethodEvent != null ? changeInvoiceCollectionMethodEvent(Value) : default;

            public ChangeInvoiceCollectionMethodEventCase Set(ChangeInvoiceCollectionMethodEvent value)
            {
                Value = value;
                return this;
            }

            public ChangeInvoiceCollectionMethodEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ChangeInvoiceCollectionMethodEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChangeInvoiceStatusEventCase, ChangeInvoiceStatusEvent>))]
        private sealed class ChangeInvoiceStatusEventCase : InvoiceEvent, ICaseValue<ChangeInvoiceStatusEventCase, ChangeInvoiceStatusEvent>
        {
            public ChangeInvoiceStatusEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   changeInvoiceStatusEvent != null ? changeInvoiceStatusEvent(Value) : default;

            public ChangeInvoiceStatusEventCase Set(ChangeInvoiceStatusEvent value)
            {
                Value = value;
                return this;
            }

            public ChangeInvoiceStatusEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ChangeInvoiceStatusEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateCreditNoteEventCase, CreateCreditNoteEvent>))]
        private sealed class CreateCreditNoteEventCase : InvoiceEvent, ICaseValue<CreateCreditNoteEventCase, CreateCreditNoteEvent>
        {
            public CreateCreditNoteEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   createCreditNoteEvent != null ? createCreditNoteEvent(Value) : default;

            public CreateCreditNoteEventCase Set(CreateCreditNoteEvent value)
            {
                Value = value;
                return this;
            }

            public CreateCreditNoteEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreateCreditNoteEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreateDebitNoteEventCase, CreateDebitNoteEvent>))]
        private sealed class CreateDebitNoteEventCase : InvoiceEvent, ICaseValue<CreateDebitNoteEventCase, CreateDebitNoteEvent>
        {
            public CreateDebitNoteEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   createDebitNoteEvent != null ? createDebitNoteEvent(Value) : default;

            public CreateDebitNoteEventCase Set(CreateDebitNoteEvent value)
            {
                Value = value;
                return this;
            }

            public CreateDebitNoteEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreateDebitNoteEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<FailedPaymentEventCase, FailedPaymentEvent>))]
        private sealed class FailedPaymentEventCase : InvoiceEvent, ICaseValue<FailedPaymentEventCase, FailedPaymentEvent>
        {
            public FailedPaymentEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   failedPaymentEvent != null ? failedPaymentEvent(Value) : default;

            public FailedPaymentEventCase Set(FailedPaymentEvent value)
            {
                Value = value;
                return this;
            }

            public FailedPaymentEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is FailedPaymentEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<IssueInvoiceEventCase, IssueInvoiceEvent>))]
        private sealed class IssueInvoiceEventCase : InvoiceEvent, ICaseValue<IssueInvoiceEventCase, IssueInvoiceEvent>
        {
            public IssueInvoiceEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   issueInvoiceEvent != null ? issueInvoiceEvent(Value) : default;

            public IssueInvoiceEventCase Set(IssueInvoiceEvent value)
            {
                Value = value;
                return this;
            }

            public IssueInvoiceEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is IssueInvoiceEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundInvoiceEventCase, RefundInvoiceEvent>))]
        private sealed class RefundInvoiceEventCase : InvoiceEvent, ICaseValue<RefundInvoiceEventCase, RefundInvoiceEvent>
        {
            public RefundInvoiceEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   refundInvoiceEvent != null ? refundInvoiceEvent(Value) : default;

            public RefundInvoiceEventCase Set(RefundInvoiceEvent value)
            {
                Value = value;
                return this;
            }

            public RefundInvoiceEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RefundInvoiceEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RemovePaymentEventCase, RemovePaymentEvent>))]
        private sealed class RemovePaymentEventCase : InvoiceEvent, ICaseValue<RemovePaymentEventCase, RemovePaymentEvent>
        {
            public RemovePaymentEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   removePaymentEvent != null ? removePaymentEvent(Value) : default;

            public RemovePaymentEventCase Set(RemovePaymentEvent value)
            {
                Value = value;
                return this;
            }

            public RemovePaymentEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RemovePaymentEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VoidInvoiceEventCase, VoidInvoiceEvent>))]
        private sealed class VoidInvoiceEventCase : InvoiceEvent, ICaseValue<VoidInvoiceEventCase, VoidInvoiceEvent>
        {
            public VoidInvoiceEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   voidInvoiceEvent != null ? voidInvoiceEvent(Value) : default;

            public VoidInvoiceEventCase Set(VoidInvoiceEvent value)
            {
                Value = value;
                return this;
            }

            public VoidInvoiceEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is VoidInvoiceEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VoidRemainderEventCase, VoidRemainderEvent>))]
        private sealed class VoidRemainderEventCase : InvoiceEvent, ICaseValue<VoidRemainderEventCase, VoidRemainderEvent>
        {
            public VoidRemainderEvent Value;

            public override T Match<T>(
                Func<ApplyCreditNoteEvent, T> applyCreditNoteEvent,
                Func<ApplyDebitNoteEvent, T> applyDebitNoteEvent,
                Func<ApplyPaymentEvent, T> applyPaymentEvent,
                Func<BackportInvoiceEvent, T> backportInvoiceEvent,
                Func<ChangeChargebackStatusEvent, T> changeChargebackStatusEvent,
                Func<ChangeInvoiceCollectionMethodEvent, T> changeInvoiceCollectionMethodEvent,
                Func<ChangeInvoiceStatusEvent, T> changeInvoiceStatusEvent,
                Func<CreateCreditNoteEvent, T> createCreditNoteEvent,
                Func<CreateDebitNoteEvent, T> createDebitNoteEvent,
                Func<FailedPaymentEvent, T> failedPaymentEvent,
                Func<IssueInvoiceEvent, T> issueInvoiceEvent,
                Func<RefundInvoiceEvent, T> refundInvoiceEvent,
                Func<RemovePaymentEvent, T> removePaymentEvent,
                Func<VoidInvoiceEvent, T> voidInvoiceEvent,
                Func<VoidRemainderEvent, T> voidRemainderEvent) =>
                   voidRemainderEvent != null ? voidRemainderEvent(Value) : default;

            public VoidRemainderEventCase Set(VoidRemainderEvent value)
            {
                Value = value;
                return this;
            }

            public VoidRemainderEvent Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is VoidRemainderEventCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}