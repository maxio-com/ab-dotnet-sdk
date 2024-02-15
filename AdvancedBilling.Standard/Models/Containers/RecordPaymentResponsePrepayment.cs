using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<RecordPaymentResponsePrepayment>),
        new Type[] {
            typeof(InvoicePrePaymentCase)
        },
        true
    )]
    public abstract class RecordPaymentResponsePrepayment
    {
        /// <summary>
        /// This is Invoice PrePayment case.
        /// </summary>
        /// <returns>
        /// The RecordPaymentResponsePrepayment instance, wrapping the provided InvoicePrePayment value.
        /// </returns>
        public static RecordPaymentResponsePrepayment FromInvoicePrePayment(InvoicePrePayment invoicePrePayment)
        {
            return new InvoicePrePaymentCase().Set(invoicePrePayment);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<InvoicePrePayment, T> invoicePrePayment);

        [JsonConverter(typeof(UnionTypeCaseConverter<InvoicePrePaymentCase, InvoicePrePayment>))]
        private sealed class InvoicePrePaymentCase : RecordPaymentResponsePrepayment, ICaseValue<InvoicePrePaymentCase, InvoicePrePayment>
        {
            public InvoicePrePayment _value;

            public override T Match<T>(Func<InvoicePrePayment, T> invoicePrePayment)
            {
                return invoicePrePayment(_value);
            }

            public InvoicePrePaymentCase Set(InvoicePrePayment value)
            {
                _value = value;
                return this;
            }

            public InvoicePrePayment Get()
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