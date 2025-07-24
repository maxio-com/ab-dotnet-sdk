// <copyright file="FailedPaymentAction.cs" company="APIMatic">
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
    /// FailedPaymentAction.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum FailedPaymentAction
    {
        /// <summary>
        /// LeaveOpenInvoice.
        /// </summary>
        [EnumMember(Value = "leave_open_invoice")]
        LeaveOpenInvoice,

        /// <summary>
        /// RollbackToPending.
        /// </summary>
        [EnumMember(Value = "rollback_to_pending")]
        RollbackToPending,

        /// <summary>
        /// InitiateDunning.
        /// </summary>
        [EnumMember(Value = "initiate_dunning")]
        InitiateDunning
    }
}