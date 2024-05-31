// <copyright file="DebitNoteRole.cs" company="APIMatic">
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
    /// DebitNoteRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebitNoteRole
    {
        /// <summary>
        /// Chargeback.
        /// </summary>
        [EnumMember(Value = "chargeback")]
        Chargeback,

        /// <summary>
        /// Refund.
        /// </summary>
        [EnumMember(Value = "refund")]
        Refund
    }
}