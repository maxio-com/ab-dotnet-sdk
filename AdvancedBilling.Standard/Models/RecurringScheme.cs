// <copyright file="RecurringScheme.cs" company="APIMatic">
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
    /// RecurringScheme.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecurringScheme
    {
        /// <summary>
        /// DoNotRecur.
        /// </summary>
        [EnumMember(Value = "do_not_recur")]
        DoNotRecur,

        /// <summary>
        /// RecurIndefinitely.
        /// </summary>
        [EnumMember(Value = "recur_indefinitely")]
        RecurIndefinitely,

        /// <summary>
        /// RecurWithDuration.
        /// </summary>
        [EnumMember(Value = "recur_with_duration")]
        RecurWithDuration
    }
}