// <copyright file="InvoiceEventPayment.cs" company="APIMatic">
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
        typeof(UnionTypeConverter<InvoiceEventPayment>),
        new[] {
            typeof(PaymentMethodApplePayCase),
            typeof(PaymentMethodBankAccountCase),
            typeof(PaymentMethodCreditCardCase),
            typeof(PaymentMethodExternalCase),
            typeof(PaymentMethodPaypalCase)
        },
        new[] {
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
            Func<PaymentMethodApplePay, T> paymentMethodApplePay = null,
            Func<PaymentMethodBankAccount, T> paymentMethodBankAccount = null,
            Func<PaymentMethodCreditCard, T> paymentMethodCreditCard = null,
            Func<PaymentMethodExternal, T> paymentMethodExternal = null,
            Func<PaymentMethodPaypal, T> paymentMethodPaypal = null) =>
                Match(paymentMethodApplePay, paymentMethodBankAccount, paymentMethodCreditCard, paymentMethodExternal, paymentMethodPaypal);

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodApplePayCase, PaymentMethodApplePay>))]
        private sealed class PaymentMethodApplePayCase : InvoiceEventPayment, ICaseValue<PaymentMethodApplePayCase, PaymentMethodApplePay>
        {
            public PaymentMethodApplePay Value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal) =>
                   paymentMethodApplePay != null ? paymentMethodApplePay(Value) : default;

            public PaymentMethodApplePayCase Set(PaymentMethodApplePay value)
            {
                Value = value;
                return this;
            }

            public PaymentMethodApplePay Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentMethodApplePayCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodBankAccountCase, PaymentMethodBankAccount>))]
        private sealed class PaymentMethodBankAccountCase : InvoiceEventPayment, ICaseValue<PaymentMethodBankAccountCase, PaymentMethodBankAccount>
        {
            public PaymentMethodBankAccount Value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal) =>
                   paymentMethodBankAccount != null ? paymentMethodBankAccount(Value) : default;

            public PaymentMethodBankAccountCase Set(PaymentMethodBankAccount value)
            {
                Value = value;
                return this;
            }

            public PaymentMethodBankAccount Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentMethodBankAccountCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodCreditCardCase, PaymentMethodCreditCard>))]
        private sealed class PaymentMethodCreditCardCase : InvoiceEventPayment, ICaseValue<PaymentMethodCreditCardCase, PaymentMethodCreditCard>
        {
            public PaymentMethodCreditCard Value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal) =>
                   paymentMethodCreditCard != null ? paymentMethodCreditCard(Value) : default;

            public PaymentMethodCreditCardCase Set(PaymentMethodCreditCard value)
            {
                Value = value;
                return this;
            }

            public PaymentMethodCreditCard Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentMethodCreditCardCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodExternalCase, PaymentMethodExternal>))]
        private sealed class PaymentMethodExternalCase : InvoiceEventPayment, ICaseValue<PaymentMethodExternalCase, PaymentMethodExternal>
        {
            public PaymentMethodExternal Value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal) =>
                   paymentMethodExternal != null ? paymentMethodExternal(Value) : default;

            public PaymentMethodExternalCase Set(PaymentMethodExternal value)
            {
                Value = value;
                return this;
            }

            public PaymentMethodExternal Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentMethodExternalCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<PaymentMethodPaypalCase, PaymentMethodPaypal>))]
        private sealed class PaymentMethodPaypalCase : InvoiceEventPayment, ICaseValue<PaymentMethodPaypalCase, PaymentMethodPaypal>
        {
            public PaymentMethodPaypal Value;

            public override T Match<T>(
                Func<PaymentMethodApplePay, T> paymentMethodApplePay,
                Func<PaymentMethodBankAccount, T> paymentMethodBankAccount,
                Func<PaymentMethodCreditCard, T> paymentMethodCreditCard,
                Func<PaymentMethodExternal, T> paymentMethodExternal,
                Func<PaymentMethodPaypal, T> paymentMethodPaypal) =>
                   paymentMethodPaypal != null ? paymentMethodPaypal(Value) : default;

            public PaymentMethodPaypalCase Set(PaymentMethodPaypal value)
            {
                Value = value;
                return this;
            }

            public PaymentMethodPaypal Get()
            {
                return Value;
            }

            public override string ToString()
            {
                return Value?.ToString();
            }

            public override bool Equals(object obj)
            {
                if (!(obj is PaymentMethodPaypalCase other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Value == null ? other.Value == null : Value?.Equals(other.Value) == true; 
            }
        }
    }
}