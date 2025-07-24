// <copyright file="CustomDateTimeConverter.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using APIMatic.Core.Utilities.Date;

namespace AdvancedBilling.Standard.Utilities
{
    /// <summary>
    /// Extends from IsoDateTimeConverter to allow a custom DateTime format.
    /// </summary>
    public class CustomDateTimeConverter : CoreCustomDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomDateTimeConverter"/>
        /// class.
        /// </summary>
        /// <param name="format">format.</param>
        public CustomDateTimeConverter(string format)
            : base(format) { }
    }
}