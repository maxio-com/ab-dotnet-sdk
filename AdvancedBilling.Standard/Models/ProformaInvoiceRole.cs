// <copyright file="ProformaInvoiceRole.cs" company="APIMatic">
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
    /// ProformaInvoiceRole.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProformaInvoiceRole
    {
        /// <summary>
        /// Unset.
        /// </summary>
        [EnumMember(Value = "unset")]
        Unset,

        /// <summary>
        /// Proforma.
        /// </summary>
        [EnumMember(Value = "proforma")]
        Proforma,

        /// <summary>
        /// ProformaAdhoc.
        /// </summary>
        [EnumMember(Value = "proforma_adhoc")]
        ProformaAdhoc,

        /// <summary>
        /// ProformaAutomatic.
        /// </summary>
        [EnumMember(Value = "proforma_automatic")]
        ProformaAutomatic
    }
}