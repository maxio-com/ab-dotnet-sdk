using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CustomerChangePayer>),
        new Type[] {
            typeof(CustomerPayerChangeCase)
        },
        true
    )]
    public abstract class CustomerChangePayer
    {
        /// <summary>
        /// This is Customer Payer Change case.
        /// </summary>
        /// <returns>
        /// The CustomerChangePayer instance, wrapping the provided CustomerPayerChange value.
        /// </returns>
        public static CustomerChangePayer FromCustomerPayerChange(CustomerPayerChange customerPayerChange)
        {
            return new CustomerPayerChangeCase().Set(customerPayerChange);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CustomerPayerChange, T> customerPayerChange);

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomerPayerChangeCase, CustomerPayerChange>))]
        private sealed class CustomerPayerChangeCase : CustomerChangePayer, ICaseValue<CustomerPayerChangeCase, CustomerPayerChange>
        {
            public CustomerPayerChange _value;

            public override T Match<T>(Func<CustomerPayerChange, T> customerPayerChange)
            {
                return customerPayerChange(_value);
            }

            public CustomerPayerChangeCase Set(CustomerPayerChange value)
            {
                _value = value;
                return this;
            }

            public CustomerPayerChange Get()
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