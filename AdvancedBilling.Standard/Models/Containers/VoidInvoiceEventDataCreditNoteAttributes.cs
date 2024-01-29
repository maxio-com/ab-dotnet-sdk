using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<VoidInvoiceEventDataCreditNoteAttributes>),
        new Type[] {
            typeof(CreditNoteCase)
        },
        true
    )]
    public abstract class VoidInvoiceEventDataCreditNoteAttributes
    {
        /// <summary>
        /// This is Credit Note case.
        /// </summary>
        /// <returns>
        /// The VoidInvoiceEventDataCreditNoteAttributes instance, wrapping the provided CreditNote value.
        /// </returns>
        public static VoidInvoiceEventDataCreditNoteAttributes FromCreditNote(CreditNote creditNote)
        {
            return new CreditNoteCase().Set(creditNote);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CreditNote, T> creditNote);

        [JsonConverter(typeof(UnionTypeCaseConverter<CreditNoteCase, CreditNote>))]
        private sealed class CreditNoteCase : VoidInvoiceEventDataCreditNoteAttributes, ICaseValue<CreditNoteCase, CreditNote>
        {
            public CreditNote _value;

            public override T Match<T>(Func<CreditNote, T> creditNote)
            {
                return creditNote(_value);
            }

            public CreditNoteCase Set(CreditNote value)
            {
                _value = value;
                return this;
            }

            public CreditNote Get()
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