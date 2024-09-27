// <copyright file="ChargebackStatus.cs" company="APIMatic">
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
    /// ChargebackStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChargebackStatus
    {
        /// <summary>
        /// Open.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Lost.
        /// </summary>
        [EnumMember(Value = "lost")]
        Lost,

        /// <summary>
        /// Won.
        /// </summary>
        [EnumMember(Value = "won")]
        Won,

        /// <summary>
        /// Closed.
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed
    }
}