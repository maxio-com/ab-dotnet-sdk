// <copyright file="PaymentProfile2.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
        typeof(UnionTypeConverter<PaymentProfile2>),
        new[] {
            typeof(ApplePayPaymentProfileCase),
            typeof(BankAccountPaymentProfileCase),
            typeof(CreditCardPaymentProfileCase),
            typeof(PaypalPaymentProfileCase)
        },
        new[] {
            "apple_pay",
            "bank_account",
            "credit_card",
            "paypal_account"
        },
        "payment_type",
        false
    )]
    public abstract class PaymentProfile2
    {
        /// <summary>
        /// This is ApplePay Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile2 instance, wrapping the provided ApplePayPaymentProfile value.
        /// </returns>
        public static PaymentProfile2 FromApplePayPaymentProfile(ApplePayPaymentProfile applePayPaymentProfile)
        {
            return new ApplePayPaymentProfileCase().Set(applePayPaymentProfile);
        }

        /// <summary>
        /// This is Bank Account Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile2 instance, wrapping the provided BankAccountPaymentProfile value.
        /// </returns>
        public static PaymentProfile2 FromBankAccountPaymentProfile(BankAccountPaymentProfile bankAccountPaymentProfile)
        {
            return new BankAccountPaymentProfileCase().Set(bankAccountPaymentProfile);
        }

        /// <summary>
        /// This is Credit Card Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile2 instance, wrapping the provided CreditCardPaymentProfile value.
        /// </returns>
        public static PaymentProfile2 FromCreditCardPaymentProfile(CreditCardPaymentProfile creditCardPaymentProfile)
        {
            return new CreditCardPaymentProfileCase().Set(creditCardPaymentProfile);
        }

        /// <summary>
        /// This is Paypal Payment Profile case.
        /// </summary>
        /// <returns>
        /// The PaymentProfile2 instance, wrapping the provided PaypalPaymentProfile value.
        /// </returns>
        public static PaymentProfile2 FromPaypalPaymentProfile(PaypalPaymentProfile paypalPaymentProfile)
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

        /// <summary>
        /// Method to match from the provided any-of cases. The parameters represent
        /// optional callback functions for any-of type cases. You may provide only
        /// the callbacks you are interested in; others can be left as <c>null</c>. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function, or the default value if no callback is provided for the matched case.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public T MatchSome<T>(
            Func<ApplePayPaymentProfile, T> applePayPaymentProfile = null,
            Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile = null,
            Func<CreditCardPaymentProfile, T> creditCardPaymentProfile = null,
            Func<PaypalPaymentProfile, T> paypalPaymentProfile = null) =>
                Match(applePayPaymentProfile, bankAccountPaymentProfile, creditCardPaymentProfile, paypalPaymentProfile);

        [JsonConverter(typeof(UnionTypeCaseConverter<ApplePayPaymentProfileCase, ApplePayPaymentProfile>))]
        private sealed class ApplePayPaymentProfileCase : PaymentProfile2, ICaseValue<ApplePayPaymentProfileCase, ApplePayPaymentProfile>
        {
            public ApplePayPaymentProfile Value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile) =>
                   applePayPaymentProfile != null ? applePayPaymentProfile(Value) : default;

            public ApplePayPaymentProfileCase Set(ApplePayPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public ApplePayPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is ApplePayPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<BankAccountPaymentProfileCase, BankAccountPaymentProfile>))]
        private sealed class BankAccountPaymentProfileCase : PaymentProfile2, ICaseValue<BankAccountPaymentProfileCase, BankAccountPaymentProfile>
        {
            public BankAccountPaymentProfile Value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile) =>
                   bankAccountPaymentProfile != null ? bankAccountPaymentProfile(Value) : default;

            public BankAccountPaymentProfileCase Set(BankAccountPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public BankAccountPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is BankAccountPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<CreditCardPaymentProfileCase, CreditCardPaymentProfile>))]
        private sealed class CreditCardPaymentProfileCase : PaymentProfile2, ICaseValue<CreditCardPaymentProfileCase, CreditCardPaymentProfile>
        {
            public CreditCardPaymentProfile Value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile) =>
                   creditCardPaymentProfile != null ? creditCardPaymentProfile(Value) : default;

            public CreditCardPaymentProfileCase Set(CreditCardPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public CreditCardPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is CreditCardPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaypalPaymentProfileCase, PaypalPaymentProfile>))]
        private sealed class PaypalPaymentProfileCase : PaymentProfile2, ICaseValue<PaypalPaymentProfileCase, PaypalPaymentProfile>
        {
            public PaypalPaymentProfile Value;

            public override T Match<T>(
                Func<ApplePayPaymentProfile, T> applePayPaymentProfile,
                Func<BankAccountPaymentProfile, T> bankAccountPaymentProfile,
                Func<CreditCardPaymentProfile, T> creditCardPaymentProfile,
                Func<PaypalPaymentProfile, T> paypalPaymentProfile) =>
                   paypalPaymentProfile != null ? paypalPaymentProfile(Value) : default;

            public PaypalPaymentProfileCase Set(PaypalPaymentProfile value)
            {
                Value = value;
                return this;
            }

            public PaypalPaymentProfile Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaypalPaymentProfileCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}