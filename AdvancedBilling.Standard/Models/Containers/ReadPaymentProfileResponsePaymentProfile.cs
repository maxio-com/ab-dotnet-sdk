using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<ReadPaymentProfileResponsePaymentProfile>),
        new Type[] {
            typeof(BankAccountPaymentProfileCase),
            typeof(CreditCardPaymentProfileCase)
        },
        true
    )]
    public abstract class ReadPaymentProfileResponsePaymentProfile
    {
        /// <summary>
        /// This is Bank Account Payment Profile case.
        /// </summary>
        /// <returns>
        /// The ReadPaymentProfileResponsePaymentProfile instance, wrapping the provided BankAccountPaymentProfile value.
        /// </returns>
        public static ReadPaymentProfileResponsePaymentProfile FromBankAccountPaymentProfile(BankAccountPaymentProfile bankAccountPaymentProfile)
        {
            return new BankAccountPaymentProfileCase().Set(bankAccountPaymentProfile);
        }

        /// <summary>
        /// This is Credit Card Payment Profile case.
        /// </summary>
        /// <returns>
        /// The ReadPaymentProfileResponsePaymentProfile instance, wrapping the provided CreditCardPaymentProfile value.
        /// </returns>
        public static ReadPaymentProfileResponsePaymentProfile FromCreditCardPaymentProfile(CreditCardPaymentProfile creditCardPaymentProfile)
        {
            return new CreditCardPaymentProfileCase().Set(creditCardPaymentProfile);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile, Func<CreditCardPaymentProfile, T> creditCardPaymentProfile);

        [JsonConverter(typeof(UnionTypeCaseConverter<BankAccountPaymentProfileCase, BankAccountPaymentProfile>))]
        private sealed class BankAccountPaymentProfileCase : ReadPaymentProfileResponsePaymentProfile, ICaseValue<BankAccountPaymentProfileCase, BankAccountPaymentProfile>
        {
            public BankAccountPaymentProfile _value;

            public override T Match<T>(Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile, Func<CreditCardPaymentProfile, T> creditCardPaymentProfile)
            {
                return bankAccountPaymentProfile(_value);
            }

            public BankAccountPaymentProfileCase Set(BankAccountPaymentProfile value)
            {
                _value = value;
                return this;
            }

            public BankAccountPaymentProfile Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreditCardPaymentProfileCase, CreditCardPaymentProfile>))]
        private sealed class CreditCardPaymentProfileCase : ReadPaymentProfileResponsePaymentProfile, ICaseValue<CreditCardPaymentProfileCase, CreditCardPaymentProfile>
        {
            public CreditCardPaymentProfile _value;

            public override T Match<T>(Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile, Func<CreditCardPaymentProfile, T> creditCardPaymentProfile)
            {
                return creditCardPaymentProfile(_value);
            }

            public CreditCardPaymentProfileCase Set(CreditCardPaymentProfile value)
            {
                _value = value;
                return this;
            }

            public CreditCardPaymentProfile Get()
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