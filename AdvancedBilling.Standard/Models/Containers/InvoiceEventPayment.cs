// <copyright file="InvoiceEventPayment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for any-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<InvoiceEventPayment>),
        new Type[] {
            typeof(PaymentMethodApplePayCase),
            typeof(PaymentMethodBankAccountCase),
            typeof(PaymentMethodCreditCardCase),
            typeof(PaymentMethodExternalCase),
            typeof(PaymentMethodPaypalCase)
        },
        new string[] {
            "apple_pay",
            "bank_account",
            "credit_card",
            "external",
            "paypal_account"
        },
        "type",
        false
    )]
    public abstract class InvoiceEventPayment
    {
        /// <summary>
        /// This is Payment Method Apple Pay case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventPayment instance, wrapping the provided PaymentMethodApplePay value.
        /// </returns>
        public static InvoiceEventPayment FromPaymentMethodApplePay(PaymentMethodApplePay paymentMethodApplePay)
        {
            return new PaymentMethodApplePayCase().Set(paymentMethodApplePay);
        }

        /// <summary>
        /// This is Payment Method Bank Account case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventPayment instance, wrapping the provided PaymentMethodBankAccount value.
        /// </returns>
        public static InvoiceEventPayment FromPaymentMethodBankAccount(PaymentMethodBankAccount paymentMethodBankAccount)
        {
            return new PaymentMethodBankAccountCase().Set(paymentMethodBankAccount);
        }

        /// <summary>
        /// This is Payment Method Credit Card case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventPayment instance, wrapping the provided PaymentMethodCreditCard value.
        /// </returns>
        public static InvoiceEventPayment FromPaymentMethodCreditCard(PaymentMethodCreditCard paymentMethodCreditCard)
        {
            return new PaymentMethodCreditCardCase().Set(paymentMethodCreditCard);
        }

        /// <summary>
        /// This is Payment Method External case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventPayment instance, wrapping the provided PaymentMethodExternal value.
        /// </returns>
        public static InvoiceEventPayment FromPaymentMethodExternal(PaymentMethodExternal paymentMethodExternal)
        {
            return new PaymentMethodExternalCase().Set(paymentMethodExternal);
        }

        /// <summary>
        /// This is Payment Method Paypal case.
        /// </summary>
        /// <returns>
        /// The InvoiceEventPayment instance, wrapping the provided PaymentMethodPaypal value.
        /// </returns>
        public static InvoiceEventPayment FromPaymentMethodPaypal(PaymentMethodPaypal paymentMethodPaypal)
        {
            return new PaymentMethodPaypalCase().Set(paymentMethodPaypal);
        }

        /// <summary>
        /// Method to match from the provided any-of cases. Here parameters
        /// represents the callback functions for any-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(
            Func<PaymentMethodApplePay, T> paymentMethodApplePay,
            Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
            Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
            Func<PaymentMethodExternal, T> paymentMethodExternal,
            Func<PaymentMethodPaypal, T> paymentMethodPaypal);

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodApplePayCase, PaymentMethodApplePay>))]
        private sealed class PaymentMethodApplePayCase : InvoiceEventPayment, ICaseValue<PaymentMethodApplePayCase, PaymentMethodApplePay>
        {
            public PaymentMethodApplePay _value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal)
            {
                return paymentMethodApplePay(_value);
            }

            public PaymentMethodApplePayCase Set(PaymentMethodApplePay value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodApplePay Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodBankAccountCase, PaymentMethodBankAccount>))]
        private sealed class PaymentMethodBankAccountCase : InvoiceEventPayment, ICaseValue<PaymentMethodBankAccountCase, PaymentMethodBankAccount>
        {
            public PaymentMethodBankAccount _value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal)
            {
                return paymentMethodBankAccount(_value);
            }

            public PaymentMethodBankAccountCase Set(PaymentMethodBankAccount value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodBankAccount Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodCreditCardCase, PaymentMethodCreditCard>))]
        private sealed class PaymentMethodCreditCardCase : InvoiceEventPayment, ICaseValue<PaymentMethodCreditCardCase, PaymentMethodCreditCard>
        {
            public PaymentMethodCreditCard _value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal)
            {
                return paymentMethodCreditCard(_value);
            }

            public PaymentMethodCreditCardCase Set(PaymentMethodCreditCard value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodCreditCard Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodExternalCase, PaymentMethodExternal>))]
        private sealed class PaymentMethodExternalCase : InvoiceEventPayment, ICaseValue<PaymentMethodExternalCase, PaymentMethodExternal>
        {
            public PaymentMethodExternal _value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal)
            {
                return paymentMethodExternal(_value);
            }

            public PaymentMethodExternalCase Set(PaymentMethodExternal value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodExternal Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodPaypalCase, PaymentMethodPaypal>))]
        private sealed class PaymentMethodPaypalCase : InvoiceEventPayment, ICaseValue<PaymentMethodPaypalCase, PaymentMethodPaypal>
        {
            public PaymentMethodPaypal _value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal)
            {
                return paymentMethodPaypal(_value);
            }

            public PaymentMethodPaypalCase Set(PaymentMethodPaypal value)
            {
                _value = value;
                return this;
            }

            public PaymentMethodPaypal Get()
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