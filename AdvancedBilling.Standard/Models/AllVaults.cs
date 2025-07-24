// <copyright file="AllVaults.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// AllVaults.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AllVaults
    {
        /// <summary>
        /// Adyen.
        /// </summary>
        [EnumMember(Value = "adyen")]
        Adyen,

        /// <summary>
        /// Authorizenet.
        /// </summary>
        [EnumMember(Value = "authorizenet")]
        Authorizenet,

        /// <summary>
        /// Beanstream.
        /// </summary>
        [EnumMember(Value = "beanstream")]
        Beanstream,

        /// <summary>
        /// BlueSnap.
        /// </summary>
        [EnumMember(Value = "blue_snap")]
        BlueSnap,

        /// <summary>
        /// Bogus.
        /// </summary>
        [EnumMember(Value = "bogus")]
        Bogus,

        /// <summary>
        /// Braintree1.
        /// </summary>
        [EnumMember(Value = "braintree1")]
        Braintree1,

        /// <summary>
        /// BraintreeBlue.
        /// </summary>
        [EnumMember(Value = "braintree_blue")]
        BraintreeBlue,

        /// <summary>
        /// Checkout.
        /// </summary>
        [EnumMember(Value = "checkout")]
        Checkout,

        /// <summary>
        /// Cybersource.
        /// </summary>
        [EnumMember(Value = "cybersource")]
        Cybersource,

        /// <summary>
        /// Elavon.
        /// </summary>
        [EnumMember(Value = "elavon")]
        Elavon,

        /// <summary>
        /// Eway.
        /// </summary>
        [EnumMember(Value = "eway")]
        Eway,

        /// <summary>
        /// EwayRapid.
        /// </summary>
        [EnumMember(Value = "eway_rapid")]
        EwayRapid,

        /// <summary>
        /// EwayRapidStd.
        /// </summary>
        [EnumMember(Value = "eway_rapid_std")]
        EwayRapidStd,

        /// <summary>
        /// Firstdata.
        /// </summary>
        [EnumMember(Value = "firstdata")]
        Firstdata,

        /// <summary>
        /// Forte.
        /// </summary>
        [EnumMember(Value = "forte")]
        Forte,

        /// <summary>
        /// Gocardless.
        /// </summary>
        [EnumMember(Value = "gocardless")]
        Gocardless,

        /// <summary>
        /// Litle.
        /// </summary>
        [EnumMember(Value = "litle")]
        Litle,

        /// <summary>
        /// MaxioPayments.
        /// </summary>
        [EnumMember(Value = "maxio_payments")]
        MaxioPayments,

        /// <summary>
        /// Maxp.
        /// </summary>
        [EnumMember(Value = "maxp")]
        Maxp,

        /// <summary>
        /// Moduslink.
        /// </summary>
        [EnumMember(Value = "moduslink")]
        Moduslink,

        /// <summary>
        /// Moneris.
        /// </summary>
        [EnumMember(Value = "moneris")]
        Moneris,

        /// <summary>
        /// Nmi.
        /// </summary>
        [EnumMember(Value = "nmi")]
        Nmi,

        /// <summary>
        /// Orbital.
        /// </summary>
        [EnumMember(Value = "orbital")]
        Orbital,

        /// <summary>
        /// PaymentExpress.
        /// </summary>
        [EnumMember(Value = "payment_express")]
        PaymentExpress,

        /// <summary>
        /// Paymill.
        /// </summary>
        [EnumMember(Value = "paymill")]
        Paymill,

        /// <summary>
        /// Paypal.
        /// </summary>
        [EnumMember(Value = "paypal")]
        Paypal,

        /// <summary>
        /// PaypalComplete.
        /// </summary>
        [EnumMember(Value = "paypal_complete")]
        PaypalComplete,

        /// <summary>
        /// Pin.
        /// </summary>
        [EnumMember(Value = "pin")]
        Pin,

        /// <summary>
        /// Square.
        /// </summary>
        [EnumMember(Value = "square")]
        Square,

        /// <summary>
        /// Stripe.
        /// </summary>
        [EnumMember(Value = "stripe")]
        Stripe,

        /// <summary>
        /// StripeConnect.
        /// </summary>
        [EnumMember(Value = "stripe_connect")]
        StripeConnect,

        /// <summary>
        /// TrustCommerce.
        /// </summary>
        [EnumMember(Value = "trust_commerce")]
        TrustCommerce,

        /// <summary>
        /// Unipaas.
        /// </summary>
        [EnumMember(Value = "unipaas")]
        Unipaas,

        /// <summary>
        /// Wirecard.
        /// </summary>
        [EnumMember(Value = "wirecard")]
        Wirecard
    }
}