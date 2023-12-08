using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InvoiceEvent1PaymentMethod>),
        new Type[] {
            typeof(PaymentMethodApplePayTypeCase),
            typeof(PaymentMethodBankAccountTypeCase),
            typeof(PaymentMethodCreditCardTypeCase),
            typeof(PaymentMethodExternalTypeCase),
            typeof(PaymentMethodPaypalTypeCase)
        },
        true
    )]
    public abstract class InvoiceEvent1PaymentMethod
    {
        /// <summary>
        /// This is Payment Method Apple Pay Type case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent1PaymentMethod instance, wrapping the provided PaymentMethodApplePayType value.
        /// </returns>
        public static InvoiceEvent1PaymentMethod FromPaymentMethodApplePayType(PaymentMethodApplePayType paymentMethodApplePayType)
        {
            return new PaymentMethodApplePayTypeCase().Set(paymentMethodApplePayType);
        }

        /// <summary>
        /// This is Payment Method Bank Account Type case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent1PaymentMethod instance, wrapping the provided PaymentMethodBankAccountType value.
        /// </returns>
        public static InvoiceEvent1PaymentMethod FromPaymentMethodBankAccountType(PaymentMethodBankAccountType paymentMethodBankAccountType)
        {
            return new PaymentMethodBankAccountTypeCase().Set(paymentMethodBankAccountType);
        }

        /// <summary>
        /// This is Payment Method Credit Card Type case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent1PaymentMethod instance, wrapping the provided PaymentMethodCreditCardType value.
        /// </returns>
        public static InvoiceEvent1PaymentMethod FromPaymentMethodCreditCardType(PaymentMethodCreditCardType paymentMethodCreditCardType)
        {
            return new PaymentMethodCreditCardTypeCase().Set(paymentMethodCreditCardType);
        }

        /// <summary>
        /// This is Payment Method External Type case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent1PaymentMethod instance, wrapping the provided PaymentMethodExternalType value.
        /// </returns>
        public static InvoiceEvent1PaymentMethod FromPaymentMethodExternalType(PaymentMethodExternalType paymentMethodExternalType)
        {
            return new PaymentMethodExternalTypeCase().Set(paymentMethodExternalType);
        }

        /// <summary>
        /// This is Payment Method Paypal Type case.
        /// </summary>
        /// <returns>
        /// The InvoiceEvent1PaymentMethod instance, wrapping the provided PaymentMethodPaypalType value.
        /// </returns>
        public static InvoiceEvent1PaymentMethod FromPaymentMethodPaypalType(PaymentMethodPaypalType paymentMethodPaypalType)
        {
            return new PaymentMethodPaypalTypeCase().Set(paymentMethodPaypalType);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
            Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
            Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
            Func<PaymentMethodExternalType, T> paymentMethodExternalType,
            Func<PaymentMethodPaypalType, T> paymentMethodPaypalType);

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodApplePayTypeCase, PaymentMethodApplePayType>))]
        private sealed class PaymentMethodApplePayTypeCase : InvoiceEvent1PaymentMethod, ICaseValue<PaymentMethodApplePayTypeCase, PaymentMethodApplePayType>
        {
            public PaymentMethodApplePayType _value;

            public override T Match<T>(
                Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
                Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
                Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
                Func<PaymentMethodExternalType, T> paymentMethodExternalType,
                Func<PaymentMethodPaypalType, T> paymentMethodPaypalType)
            {
                return paymentMethodApplePayType(_value);
            }

            public PaymentMethodApplePayTypeCase Set(PaymentMethodApplePayType value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodApplePayType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodBankAccountTypeCase, PaymentMethodBankAccountType>))]
        private sealed class PaymentMethodBankAccountTypeCase : InvoiceEvent1PaymentMethod, ICaseValue<PaymentMethodBankAccountTypeCase, PaymentMethodBankAccountType>
        {
            public PaymentMethodBankAccountType _value;

            public override T Match<T>(
                Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
                Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
                Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
                Func<PaymentMethodExternalType, T> paymentMethodExternalType,
                Func<PaymentMethodPaypalType, T> paymentMethodPaypalType)
            {
                return paymentMethodBankAccountType(_value);
            }

            public PaymentMethodBankAccountTypeCase Set(PaymentMethodBankAccountType value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodBankAccountType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodCreditCardTypeCase, PaymentMethodCreditCardType>))]
        private sealed class PaymentMethodCreditCardTypeCase : InvoiceEvent1PaymentMethod, ICaseValue<PaymentMethodCreditCardTypeCase, PaymentMethodCreditCardType>
        {
            public PaymentMethodCreditCardType _value;

            public override T Match<T>(
                Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
                Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
                Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
                Func<PaymentMethodExternalType, T> paymentMethodExternalType,
                Func<PaymentMethodPaypalType, T> paymentMethodPaypalType)
            {
                return paymentMethodCreditCardType(_value);
            }

            public PaymentMethodCreditCardTypeCase Set(PaymentMethodCreditCardType value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodCreditCardType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodExternalTypeCase, PaymentMethodExternalType>))]
        private sealed class PaymentMethodExternalTypeCase : InvoiceEvent1PaymentMethod, ICaseValue<PaymentMethodExternalTypeCase, PaymentMethodExternalType>
        {
            public PaymentMethodExternalType _value;

            public override T Match<T>(
                Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
                Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
                Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
                Func<PaymentMethodExternalType, T> paymentMethodExternalType,
                Func<PaymentMethodPaypalType, T> paymentMethodPaypalType)
            {
                return paymentMethodExternalType(_value);
            }

            public PaymentMethodExternalTypeCase Set(PaymentMethodExternalType value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodExternalType Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodPaypalTypeCase, PaymentMethodPaypalType>))]
        private sealed class PaymentMethodPaypalTypeCase : InvoiceEvent1PaymentMethod, ICaseValue<PaymentMethodPaypalTypeCase, PaymentMethodPaypalType>
        {
            public PaymentMethodPaypalType _value;

            public override T Match<T>(
                Func<PaymentMethodApplePayType, T> paymentMethodApplePayType,
                Func<PaymentMethodBankAccountType, T> paymentMethodBankAccountType,
                Func<PaymentMethodCreditCardType, T> paymentMethodCreditCardType,
                Func<PaymentMethodExternalType, T> paymentMethodExternalType,
                Func<PaymentMethodPaypalType, T> paymentMethodPaypalType)
            {
                return paymentMethodPaypalType(_value);
            }

            public PaymentMethodPaypalTypeCase Set(PaymentMethodPaypalType value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodPaypalType Get()
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