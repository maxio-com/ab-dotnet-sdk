// <copyright file="GroupType.cs" company="APIMatic">
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
    /// GroupType.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum GroupType
    {
        /// <summary>
        /// SingleCustomer.
        /// </summary>
        [EnumMember(Value = "single_customer")]
        SingleCustomer,

        /// <summary>
        /// MultipleCustomers.
        /// </summary>
        [EnumMember(Value = "multiple_customers")]
        MultipleCustomers
    }
}