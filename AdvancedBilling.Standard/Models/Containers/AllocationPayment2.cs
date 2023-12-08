using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<AllocationPayment2>),
        new Type[] {
            typeof(AllocationPaymentCase)
        },
        true
    )]
    public abstract class AllocationPayment2
    {
        /// <summary>
        /// This is Allocation Payment case.
        /// </summary>
        /// <returns>
        /// The AllocationPayment2 instance, wrapping the provided AllocationPayment value.
        /// </returns>
        public static AllocationPayment2 FromAllocationPayment(AllocationPayment allocationPayment)
        {
            return new AllocationPaymentCase().Set(allocationPayment);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<AllocationPayment, T> allocationPayment);

        [JsonConverter(typeof(UnionTypeCaseConverter<AllocationPaymentCase, AllocationPayment>))]
        private sealed class AllocationPaymentCase : AllocationPayment2, ICaseValue<AllocationPaymentCase, AllocationPayment>
        {
            public AllocationPayment _value;

            public override T Match<T>(Func<AllocationPayment, T> allocationPayment)
            {
                return allocationPayment(_value);
            }

            public AllocationPaymentCase Set(AllocationPayment value)
            {
                _value = value;
                return this;
            }

            public AllocationPayment Get()
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