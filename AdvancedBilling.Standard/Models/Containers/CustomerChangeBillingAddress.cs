using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CustomerChangeBillingAddress>),
        new Type[] {
            typeof(AddressChangeCase)
        },
        true
    )]
    public abstract class CustomerChangeBillingAddress
    {
        /// <summary>
        /// This is Address Change case.
        /// </summary>
        /// <returns>
        /// The CustomerChangeBillingAddress instance, wrapping the provided AddressChange value.
        /// </returns>
        public static CustomerChangeBillingAddress FromAddressChange(AddressChange addressChange)
        {
            return new AddressChangeCase().Set(addressChange);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AddressChange, T> addressChange);

        [JsonConverter(typeof(UnionTypeCaseConverter<AddressChangeCase, AddressChange>))]
        private sealed class AddressChangeCase : CustomerChangeBillingAddress, ICaseValue<AddressChangeCase, AddressChange>
        {
            public AddressChange _value;

            public override T Match<T>(Func<AddressChange, T> addressChange)
            {
                return addressChange(_value);
            }

            public AddressChangeCase Set(AddressChange value)
            {
                _value = value;
                return this;
            }

            public AddressChange Get()
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