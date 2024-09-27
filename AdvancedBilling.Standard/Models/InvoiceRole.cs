// <copyright file="InvoiceRole.cs" company="APIMatic">
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
    /// InvoiceRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum InvoiceRole
    {
        /// <summary>
        /// Unset.
        /// </summary>
        [EnumMember(Value = "unset")]
        Unset,

        /// <summary>
        /// Signup.
        /// </summary>
        [EnumMember(Value = "signup")]
        Signup,

        /// <summary>
        /// Renewal.
        /// </summary>
        [EnumMember(Value = "renewal")]
        Renewal,

        /// <summary>
        /// Usage.
        /// </summary>
        [EnumMember(Value = "usage")]
        Usage,

        /// <summary>
        /// Reactivation.
        /// </summary>
        [EnumMember(Value = "reactivation")]
        Reactivation,

        /// <summary>
        /// Proration.
        /// </summary>
        [EnumMember(Value = "proration")]
        Proration,

        /// <summary>
        /// Migration.
        /// </summary>
        [EnumMember(Value = "migration")]
        Migration,

        /// <summary>
        /// Adhoc.
        /// </summary>
        [EnumMember(Value = "adhoc")]
        Adhoc,

        /// <summary>
        /// Backport.
        /// </summary>
        [EnumMember(Value = "backport")]
        Backport,

        /// <summary>
        /// Backportbalancereconciliation.
        /// </summary>
        [EnumMember(Value = "backport-balance-reconciliation")]
        Backportbalancereconciliation
    }
}