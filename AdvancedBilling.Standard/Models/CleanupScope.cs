// <copyright file="CleanupScope.cs" company="APIMatic">
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
    /// CleanupScope.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CleanupScope
    {
        /// <summary>
        /// All.
        /// </summary>
        [EnumMember(Value = "all")]
        All,

        /// <summary>
        /// Customers.
        /// </summary>
        [EnumMember(Value = "customers")]
        Customers
    }
}