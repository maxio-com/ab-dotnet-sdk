// <copyright file="RecurringScheme.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using AdvancedBilling.Standard;
    using AdvancedBilling.Standard.Utilities;
    using Newtonsoft.Json;

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