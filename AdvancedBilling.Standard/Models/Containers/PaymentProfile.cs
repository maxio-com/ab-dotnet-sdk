// <copyright file="PaymentProfile.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<PaymentProfile>),
        new Type[] {
            typeof(ApplePayPaymentProfileCase),
            typeof(BankAccountPaymentProfileCase),
            typeof(CreditCardPaymentProfileCase),
            typeof(PaypalPaymentProfileCase)
        },
        new string[] {
            "apple_pay",
            "bank_account",
            "credit_card",
            "paypal_account"
        },
        "payment_type",
        false
    )]
    public abstract class PaymentProfile
    {
        /// <summary>
        /// This is ApplePay Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile instance, wrapping the provided ApplePayPaymentProfile value.
        /// </returns>
        public static PaymentProfile FromApplePayPaymentProfile(ApplePayPaymentProfile applePayPaymentProfile)
        {
            return new ApplePayPaymentProfileCase().Set(applePayPaymentProfile);
        }

        /// <summary>
        /// This is Bank Account Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile instance, wrapping the provided BankAccountPaymentProfile value.
        /// </returns>
        public static PaymentProfile FromBankAccountPaymentProfile(BankAccountPaymentProfile bankAccountPaymentProfile)
        {
            return new BankAccountPaymentProfileCase().Set(bankAccountPaymentProfile);
        }

        /// <summary>
        /// This is Credit Card Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile instance, wrapping the provided CreditCardPaymentProfile value.
        /// </returns>
        public static PaymentProfile FromCreditCardPaymentProfile(CreditCardPaymentProfile creditCardPaymentProfile)
        {
            return new CreditCardPaymentProfileCase().Set(creditCardPaymentProfile);
        }

        /// <summary>
        /// This is Paypal Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile instance, wrapping the provided PaypalPaymentProfile value.
        /// </returns>
        public static PaymentProfile FromPaypalPaymentProfile(PaypalPaymentProfile paypalPaymentProfile)
        {
            return new PaypalPaymentProfileCase().Set(paypalPaymentProfile);
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
            Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
            Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
            Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
            Func<PaypalPaymentProfile, T> paypalPaymentProfile);

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplePayPaymentProfileCase, ApplePayPaymentProfile>))]
        private sealed class ApplePayPaymentProfileCase : PaymentProfile, ICaseValue<ApplePayPaymentProfileCase, ApplePayPaymentProfile>
        {
            public ApplePayPaymentProfile _value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile)
            {
                return applePayPaymentProfile(_value);
            }

            public ApplePayPaymentProfileCase Set(ApplePayPaymentProfile value)
            {
                _value = value;
                return this;
            }

            public ApplePayPaymentProfile Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value?.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BankAccountPaymentProfileCase, BankAccountPaymentProfile>))]
        private sealed class BankAccountPaymentProfileCase : PaymentProfile, ICaseValue<BankAccountPaymentProfileCase, BankAccountPaymentProfile>
        {
            public BankAccountPaymentProfile _value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile)
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
        private sealed class CreditCardPaymentProfileCase : PaymentProfile, ICaseValue<CreditCardPaymentProfileCase, CreditCardPaymentProfile>
        {
            public CreditCardPaymentProfile _value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile)
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

        [JsonConverter(typeof(UnionTypeCaseConverter<PaypalPaymentProfileCase, PaypalPaymentProfile>))]
        private sealed class PaypalPaymentProfileCase : PaymentProfile, ICaseValue<PaypalPaymentProfileCase, PaypalPaymentProfile>
        {
            public PaypalPaymentProfile _value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile)
            {
                return paypalPaymentProfile(_value);
            }

            public PaypalPaymentProfileCase Set(PaypalPaymentProfile value)
            {
                _value = value;
                return this;
            }

            public PaypalPaymentProfile Get()
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