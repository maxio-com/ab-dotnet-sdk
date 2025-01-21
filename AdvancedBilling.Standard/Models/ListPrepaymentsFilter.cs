// <copyright file="ListPrepaymentsFilter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using AdvancedBilling.Standard;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// ListPrepaymentsFilter.
    /// </summary>
    public class ListPrepaymentsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsFilter"/> class.
        /// </summary>
        public ListPrepaymentsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPrepaymentsFilter"/> class.
        /// </summary>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        public ListPrepaymentsFilter(
            Models.ListPrepaymentDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null)
        {
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The type of filter you would like to apply to your search. `created_at` - Time when prepayment was created. `application_at` - Time when prepayment was applied to invoice. Use in query `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ListPrepaymentDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns prepayments with a timestamp at or after midnight (12:00:00 AM) in your site's time zone on the date specified. Use in query: `filter[start_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns prepayments with a timestamp up to and including 11:59:59PM in your site's time zone on the date specified. Use in query: `filter[end_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListPrepaymentsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListPrepaymentsFilter other &&
                (this.DateField == null && other.DateField == null ||
                 this.DateField?.Equals(other.DateField) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}