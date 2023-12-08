using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InvoiceLineItemComponentCostData2>),
        new Type[] {
            typeof(InvoiceLineItemComponentCostDataCase)
        },
        true
    )]
    public abstract class InvoiceLineItemComponentCostData2
    {
        /// <summary>
        /// This is Invoice Line Item Component Cost Data case.
        /// </summary>
        /// <returns>
        /// The InvoiceLineItemComponentCostData2 instance, wrapping the provided InvoiceLineItemComponentCostData value.
        /// </returns>
        public static InvoiceLineItemComponentCostData2 FromInvoiceLineItemComponentCostData(InvoiceLineItemComponentCostData invoiceLineItemComponentCostData)
        {
            return new InvoiceLineItemComponentCostDataCase().Set(invoiceLineItemComponentCostData);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<InvoiceLineItemComponentCostData, T> invoiceLineItemComponentCostData);

        [JsonConverter(typeof(UnionTypeCaseConverter<InvoiceLineItemComponentCostDataCase, InvoiceLineItemComponentCostData>))]
        private sealed class InvoiceLineItemComponentCostDataCase : InvoiceLineItemComponentCostData2, ICaseValue<InvoiceLineItemComponentCostDataCase, InvoiceLineItemComponentCostData>
        {
            public InvoiceLineItemComponentCostData _value;

            public override T Match<T>(Func<InvoiceLineItemComponentCostData, T> invoiceLineItemComponentCostData)
            {
                return invoiceLineItemComponentCostData(_value);
            }

            public InvoiceLineItemComponentCostDataCase Set(InvoiceLineItemComponentCostData value)
            {
                _value = value;
                return this;
            }

            public InvoiceLineItemComponentCostData Get()
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