// <copyright file="IncludeNullOrNotNull.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
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
    /// IncludeNullOrNotNull.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IncludeNullOrNotNull
    {
        /// <summary>
        /// NotNull.
        /// </summary>
        [EnumMember(Value = "not_null")]
        NotNull,

        /// <summary>
        /// Null.
        /// </summary>
        [EnumMember(Value = "null")]
        Null
    }
}