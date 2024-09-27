// <copyright file="CreateInvoiceItemQuantity.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace AdvancedBilling.Standard.Models.Containers
{
    /// <summary>
    /// This is a container class for one-of types.
    /// </summary>
    [JsonConverter(
        typeof(UnionTypeConverter<CreateInvoiceItemQuantity>),
        new Type[] {
            typeof(PrecisionCase),
            typeof(MStringCase)
        },
        true
    )]
    public abstract class CreateInvoiceItemQuantity
    {
        /// <summary>
        /// This is Precision case.
        /// </summary>
        /// <returns>
        /// The CreateInvoiceItemQuantity instance, wrapping the provided double value.
        /// </returns>
        public static CreateInvoiceItemQuantity FromPrecision(double precision)
        {
            return new PrecisionCase().Set(precision);
        }

        /// <summary>
        /// This is String case.
        /// </summary>
        /// <returns>
        /// The CreateInvoiceItemQuantity instance, wrapping the provided string value.
        /// </returns>
        public static CreateInvoiceItemQuantity FromString(string mString)
        {
            return new MStringCase().Set(mString);
        }

        /// <summary>
        /// Method to match from the provided one-of cases. Here parameters
        /// represents the callback functions for one-of type cases. All
        /// callback functions must have the same return type T. This typeparam T
        /// represents the type that will be returned after applying the selected
        /// callback function.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public abstract T Match<T>(Func<double, T> precision, Func<string, T> mString);

        [JsonConverter(typeof(UnionTypeCaseConverter<PrecisionCase, double>), JTokenType.Float)]
        private sealed class PrecisionCase : CreateInvoiceItemQuantity, ICaseValue<PrecisionCase, double>
        {
            public double _value;

            public override T Match<T>(Func<double, T> precision, Func<string, T> mString)
            {
                return precision(_value);
            }

            public PrecisionCase Set(double value)
            {
                _value = value;
                return this;
            }

            public double Get()
            {
                return _value;
            }

            public override string ToString()
            {
                return _value.ToString();
            }
        }

        [JsonConverter(typeof(UnionTypeCaseConverter<MStringCase, string>), JTokenType.String, JTokenType.Null)]
        private sealed class MStringCase : CreateInvoiceItemQuantity, ICaseValue<MStringCase, string>
        {
            public string _value;

            public override T Match<T>(Func<double, T> precision, Func<string, T> mString)
            {
                return mString(_value);
            }

            public MStringCase Set(string value)
            {
                _value = value;
                return this;
            }

            public string Get()
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