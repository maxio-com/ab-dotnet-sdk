using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CustomerChangeCustomFields>),
        new Type[] {
            typeof(CustomerCustomFieldsChangeCase)
        },
        true
    )]
    public abstract class CustomerChangeCustomFields
    {
        /// <summary>
        /// This is Customer Custom Fields Change case.
        /// </summary>
        /// <returns>
        /// The CustomerChangeCustomFields instance, wrapping the provided CustomerCustomFieldsChange value.
        /// </returns>
        public static CustomerChangeCustomFields FromCustomerCustomFieldsChange(CustomerCustomFieldsChange customerCustomFieldsChange)
        {
            return new CustomerCustomFieldsChangeCase().Set(customerCustomFieldsChange);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<CustomerCustomFieldsChange, T> customerCustomFieldsChange);

        [JsonConverter(typeof(UnionTypeCaseConverter<CustomerCustomFieldsChangeCase, CustomerCustomFieldsChange>))]
        private sealed class CustomerCustomFieldsChangeCase : CustomerChangeCustomFields, ICaseValue<CustomerCustomFieldsChangeCase, CustomerCustomFieldsChange>
        {
            public CustomerCustomFieldsChange _value;

            public override T Match<T>(Func<CustomerCustomFieldsChange, T> customerCustomFieldsChange)
            {
                return customerCustomFieldsChange(_value);
            }

            public CustomerCustomFieldsChangeCase Set(CustomerCustomFieldsChange value)
            {
                _value = value;
                return this;
            }

            public CustomerCustomFieldsChange Get()
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