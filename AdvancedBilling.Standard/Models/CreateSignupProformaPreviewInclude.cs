// <copyright file="CreateSignupProformaPreviewInclude.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using System.Runtime.Serialization;

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