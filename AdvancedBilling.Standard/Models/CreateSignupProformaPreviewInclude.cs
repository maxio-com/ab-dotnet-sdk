// <copyright file="CreateSignupProformaPreviewInclude.cs" company="APIMatic">
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
    /// CreateSignupProformaPreviewInclude.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreateSignupProformaPreviewInclude
    {
        /// <summary>
        /// NextProformaInvoice.
        /// </summary>
        [EnumMember(Value = "next_proforma_invoice")]
        NextProformaInvoice
    }
}