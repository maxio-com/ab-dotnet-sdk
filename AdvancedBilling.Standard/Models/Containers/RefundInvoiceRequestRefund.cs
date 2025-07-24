// <copyright file="RefundInvoiceRequestRefund.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<RefundInvoiceRequestRefund>),
        new Type[] {
            typeof(RefundInvoiceCase),
            typeof(RefundConsolidatedInvoiceCase)
        },
        false
    )]
    public abstract class RefundInvoiceRequestRefund
    {
        /// <summary>
        /// This is Refund Invoice case.
        /// </summary>
        /// <returns>
        /// The RefundInvoiceRequestRefund instance, wrapping the provided RefundInvoice value.
        /// </returns>
        public static RefundInvoiceRequestRefund FromRefundInvoice(RefundInvoice refundInvoice)
        {
            return new RefundInvoiceCase().Set(refundInvoice);
        }

        /// <summary>
        /// This is Refund Consolidated Invoice case.
        /// </summary>
        /// <returns>
        /// The RefundInvoiceRequestRefund instance, wrapping the provided RefundConsolidatedInvoice value.
        /// </returns>
        public static RefundInvoiceRequestRefund FromRefundConsolidatedInvoice(RefundConsolidatedInvoice refundConsolidatedInvoice)
        {
            return new RefundConsolidatedInvoiceCase().Set(refundConsolidatedInvoice);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<RefundInvoice, T> refundInvoice, Func<RefundConsolidatedInvoice, T> refundConsolidatedInvoice);

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundInvoiceCase, RefundInvoice>))]
        private sealed class RefundInvoiceCase : RefundInvoiceRequestRefund, ICaseValue<RefundInvoiceCase, RefundInvoice>
        {
            public RefundInvoice _value;

            public override T Match<T>(Func<RefundInvoice, T> refundInvoice, Func<RefundConsolidatedInvoice, T> refundConsolidatedInvoice)
            {
                return refundInvoice(_value);
            }

            public RefundInvoiceCase Set(RefundInvoice value)
            {
                _value = value;
                return this;
            }

            public RefundInvoice Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RefundInvoiceCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<RefundConsolidatedInvoiceCase, RefundConsolidatedInvoice>))]
        private sealed class RefundConsolidatedInvoiceCase : RefundInvoiceRequestRefund, ICaseValue<RefundConsolidatedInvoiceCase, RefundConsolidatedInvoice>
        {
            public RefundConsolidatedInvoice _value;

            public override T Match<T>(Func<RefundInvoice, T> refundInvoice, Func<RefundConsolidatedInvoice, T> refundConsolidatedInvoice)
            {
                return refundConsolidatedInvoice(_value);
            }

            public RefundConsolidatedInvoiceCase Set(RefundConsolidatedInvoice value)
            {
                _value = value;
                return this;
            }

            public RefundConsolidatedInvoice Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is RefundConsolidatedInvoiceCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return _value == null ? other._value == null : _value?.Equals(other._value) == true;
            }
        }
    }
}