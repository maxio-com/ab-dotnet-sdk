// <copyright file="DebitNoteStatus.cs" company="APIMatic">
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
    /// DebitNoteStatus.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DebitNoteStatus
    {
        /// <summary>
        /// Open.
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Applied.
        /// </summary>
        [EnumMember(Value = "applied")]
        Applied,

        /// <summary>
        /// Banished.
        /// </summary>
        [EnumMember(Value = "banished")]
        Banished,

        /// <summary>
        /// Paid.
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid
    }
}