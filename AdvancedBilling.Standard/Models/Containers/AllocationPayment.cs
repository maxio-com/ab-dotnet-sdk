using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<AllocationPayment>),
        new Type[] {
            typeof(PaymentForAllocationCase)
        },
        true
    )]
    public abstract class AllocationPayment
    {
        /// <summary>
        /// This is Payment for Allocation case.
        /// </summary>
        /// <returns>
        /// The AllocationPayment instance, wrapping the provided PaymentForAllocation value.
        /// </returns>
        public static AllocationPayment FromPaymentForAllocation(PaymentForAllocation paymentForAllocation)
        {
            return new PaymentForAllocationCase().Set(paymentForAllocation);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<PaymentForAllocation, T> paymentForAllocation);

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentForAllocationCase, PaymentForAllocation>))]
        private sealed class PaymentForAllocationCase : AllocationPayment, ICaseValue<PaymentForAllocationCase, PaymentForAllocation>
        {
            public PaymentForAllocation _value;

            public override T Match<T>(Func<PaymentForAllocation, T> paymentForAllocation)
            {
                return paymentForAllocation(_value);
            }

            public PaymentForAllocationCase Set(PaymentForAllocation value)
            {
                _value = value;
                return this;
            }

            public PaymentForAllocation Get()
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