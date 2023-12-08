using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InvoiceEventEventData>),
        new Type[] {
            typeof(ApplyCreditNoteEventDataCase),
            typeof(ApplyDebitNoteEventDataCase),
            typeof(ApplyPaymentEventDataCase),
            typeof(ChangeInvoiceCollectionMethodEventDataCase),
            typeof(IssueInvoiceEventDataCase),
            typeof(RefundInvoiceEventDataCase),
            typeof(RemovePaymentEventDataCase),
            typeof(VoidInvoiceEventDataCase),
            typeof(VoidInvoiceEventData1Case)
        },
        false
    )]
    public abstract class InvoiceEventEventData
    {
        /// <summary>
        /// This is Apply Credit Note Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided ApplyCreditNoteEventData value.
        /// </returns>
        public static InvoiceEventEventData FromApplyCreditNoteEventData(ApplyCreditNoteEventData applyCreditNoteEventData)
        {
            return new ApplyCreditNoteEventDataCase().Set(applyCreditNoteEventData);
        }

        /// <summary>
        /// This is Apply Debit Note Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided ApplyDebitNoteEventData value.
        /// </returns>
        public static InvoiceEventEventData FromApplyDebitNoteEventData(ApplyDebitNoteEventData applyDebitNoteEventData)
        {
            return new ApplyDebitNoteEventDataCase().Set(applyDebitNoteEventData);
        }

        /// <summary>
        /// This is Apply Payment Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided ApplyPaymentEventData value.
        /// </returns>
        public static InvoiceEventEventData FromApplyPaymentEventData(ApplyPaymentEventData applyPaymentEventData)
        {
            return new ApplyPaymentEventDataCase().Set(applyPaymentEventData);
        }

        /// <summary>
        /// This is Change Invoice Collection Method Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided ChangeInvoiceCollectionMethodEventData value.
        /// </returns>
        public static InvoiceEventEventData FromChangeInvoiceCollectionMethodEventData(ChangeInvoiceCollectionMethodEventData changeInvoiceCollectionMethodEventData)
        {
            return new ChangeInvoiceCollectionMethodEventDataCase().Set(changeInvoiceCollectionMethodEventData);
        }

        /// <summary>
        /// This is Issue Invoice Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided IssueInvoiceEventData value.
        /// </returns>
        public static InvoiceEventEventData FromIssueInvoiceEventData(IssueInvoiceEventData issueInvoiceEventData)
        {
            return new IssueInvoiceEventDataCase().Set(issueInvoiceEventData);
        }

        /// <summary>
        /// This is Refund Invoice Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided RefundInvoiceEventData value.
        /// </returns>
        public static InvoiceEventEventData FromRefundInvoiceEventData(RefundInvoiceEventData refundInvoiceEventData)
        {
            return new RefundInvoiceEventDataCase().Set(refundInvoiceEventData);
        }

        /// <summary>
        /// This is Remove Payment Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided RemovePaymentEventData value.
        /// </returns>
        public static InvoiceEventEventData FromRemovePaymentEventData(RemovePaymentEventData removePaymentEventData)
        {
            return new RemovePaymentEventDataCase().Set(removePaymentEventData);
        }

        /// <summary>
        /// This is Void Invoice Event Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided VoidInvoiceEventData value.
        /// </returns>
        public static InvoiceEventEventData FromVoidInvoiceEventData(VoidInvoiceEventData voidInvoiceEventData)
        {
            return new VoidInvoiceEventDataCase().Set(voidInvoiceEventData);
        }

        /// <summary>
        /// This is Void Invoice Event Data1 case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventEventData instance, wrapping the provided VoidInvoiceEventData1 value.
        /// </returns>
        public static InvoiceEventEventData FromVoidInvoiceEventData1(VoidInvoiceEventData1 voidInvoiceEventData1)
        {
            return new VoidInvoiceEventData1Case().Set(voidInvoiceEventData1);
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
            Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
            Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
            Func<ApplyPaymentEventData, T> applyPaymentEventData,
            Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
            Func<IssueInvoiceEventData, T> issueInvoiceEventData,
            Func<RefundInvoiceEventData, T> refundInvoiceEventData,
            Func<RemovePaymentEventData, T> removePaymentEventData,
            Func<VoidInvoiceEventData, T> voidInvoiceEventData,
            Func<VoidInvoiceEventData1, T> voidInvoiceEventData1);

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyCreditNoteEventDataCase, ApplyCreditNoteEventData>))]
        private sealed class ApplyCreditNoteEventDataCase : InvoiceEventEventData, ICaseValue<ApplyCreditNoteEventDataCase, ApplyCreditNoteEventData>
        {
            public ApplyCreditNoteEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return applyCreditNoteEventData(_value);
            }

            public ApplyCreditNoteEventDataCase Set(ApplyCreditNoteEventData value)
            {
                _value = value;
                return this;
            }

            public ApplyCreditNoteEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyDebitNoteEventDataCase, ApplyDebitNoteEventData>))]
        private sealed class ApplyDebitNoteEventDataCase : InvoiceEventEventData, ICaseValue<ApplyDebitNoteEventDataCase, ApplyDebitNoteEventData>
        {
            public ApplyDebitNoteEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return applyDebitNoteEventData(_value);
            }

            public ApplyDebitNoteEventDataCase Set(ApplyDebitNoteEventData value)
            {
                _value = value;
                return this;
            }

            public ApplyDebitNoteEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplyPaymentEventDataCase, ApplyPaymentEventData>))]
        private sealed class ApplyPaymentEventDataCase : InvoiceEventEventData, ICaseValue<ApplyPaymentEventDataCase, ApplyPaymentEventData>
        {
            public ApplyPaymentEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return applyPaymentEventData(_value);
            }

            public ApplyPaymentEventDataCase Set(ApplyPaymentEventData value)
            {
                _value = value;
                return this;
            }

            public ApplyPaymentEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<ChangeInvoiceCollectionMethodEventDataCase, ChangeInvoiceCollectionMethodEventData>))]
        private sealed class ChangeInvoiceCollectionMethodEventDataCase : InvoiceEventEventData, ICaseValue<ChangeInvoiceCollectionMethodEventDataCase, ChangeInvoiceCollectionMethodEventData>
        {
            public ChangeInvoiceCollectionMethodEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return changeInvoiceCollectionMethodEventData(_value);
            }

            public ChangeInvoiceCollectionMethodEventDataCase Set(ChangeInvoiceCollectionMethodEventData value)
            {
                _value = value;
                return this;
            }

            public ChangeInvoiceCollectionMethodEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<IssueInvoiceEventDataCase, IssueInvoiceEventData>))]
        private sealed class IssueInvoiceEventDataCase : InvoiceEventEventData, ICaseValue<IssueInvoiceEventDataCase, IssueInvoiceEventData>
        {
            public IssueInvoiceEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return issueInvoiceEventData(_value);
            }

            public IssueInvoiceEventDataCase Set(IssueInvoiceEventData value)
            {
                _value = value;
                return this;
            }

            public IssueInvoiceEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundInvoiceEventDataCase, RefundInvoiceEventData>))]
        private sealed class RefundInvoiceEventDataCase : InvoiceEventEventData, ICaseValue<RefundInvoiceEventDataCase, RefundInvoiceEventData>
        {
            public RefundInvoiceEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return refundInvoiceEventData(_value);
            }

            public RefundInvoiceEventDataCase Set(RefundInvoiceEventData value)
            {
                _value = value;
                return this;
            }

            public RefundInvoiceEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RemovePaymentEventDataCase, RemovePaymentEventData>))]
        private sealed class RemovePaymentEventDataCase : InvoiceEventEventData, ICaseValue<RemovePaymentEventDataCase, RemovePaymentEventData>
        {
            public RemovePaymentEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return removePaymentEventData(_value);
            }

            public RemovePaymentEventDataCase Set(RemovePaymentEventData value)
            {
                _value = value;
                return this;
            }

            public RemovePaymentEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VoidInvoiceEventDataCase, VoidInvoiceEventData>))]
        private sealed class VoidInvoiceEventDataCase : InvoiceEventEventData, ICaseValue<VoidInvoiceEventDataCase, VoidInvoiceEventData>
        {
            public VoidInvoiceEventData _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return voidInvoiceEventData(_value);
            }

            public VoidInvoiceEventDataCase Set(VoidInvoiceEventData value)
            {
                _value = value;
                return this;
            }

            public VoidInvoiceEventData Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<VoidInvoiceEventData1Case, VoidInvoiceEventData1>))]
        private sealed class VoidInvoiceEventData1Case : InvoiceEventEventData, ICaseValue<VoidInvoiceEventData1Case, VoidInvoiceEventData1>
        {
            public VoidInvoiceEventData1 _value;

            public override T Match<T>(
                Func<ApplyCreditNoteEventData, T> applyCreditNoteEventData,
                Func<ApplyDebitNoteEventData, T> applyDebitNoteEventData,
                Func<ApplyPaymentEventData, T> applyPaymentEventData,
                Func<ChangeInvoiceCollectionMethodEventData, T> changeInvoiceCollectionMethodEventData,
                Func<IssueInvoiceEventData, T> issueInvoiceEventData,
                Func<RefundInvoiceEventData, T> refundInvoiceEventData,
                Func<RemovePaymentEventData, T> removePaymentEventData,
                Func<VoidInvoiceEventData, T> voidInvoiceEventData,
                Func<VoidInvoiceEventData1, T> voidInvoiceEventData1)
            {
                return voidInvoiceEventData1(_value);
            }

            public VoidInvoiceEventData1Case Set(VoidInvoiceEventData1 value)
            {
                _value = value;
                return this;
            }

            public VoidInvoiceEventData1 Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }
    }
}