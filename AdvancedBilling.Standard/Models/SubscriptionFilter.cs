// <copyright file="SubscriptionFilter.cs" company="APIMatic">
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
    /// SubscriptionFilter.
    /// </summary>
    public class SubscriptionFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionFilter"/> class.
        /// </summary>
        public SubscriptionFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionFilter"/> class.
        /// </summary>
        /// <param name="states">states.</param>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        public SubscriptionFilter(
            List<Models.SubscriptionStateFilter> states = null,
            Models.SubscriptionListDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            DateTimeOffset? startDatetime = null,
            DateTimeOffset? endDatetime = null)
        {
            this.States = states;
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
        }

        /// <summary>
        /// <![CDATA[
        /// Allows fetching components allocations that belong to the subscription with matching states based on provided values. To use this filter you also have to include the following param in the request `include=subscription`. Use in query `filter[subscription][states]=active,canceled&include=subscription`.
        /// ]]>
        /// </summary>
        [JsonProperty("states", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.SubscriptionStateFilter> States { get; set; }

        /// <summary>
        /// The type of filter you'd like to apply to your search. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.SubscriptionListDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns components that belong to the subscription with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of start_date. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns components that belong to the subscription with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site''s time zone will be used. If provided, this parameter will be used instead of end_date. To use this filter you also have to include the following param in the request `include=subscription`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDatetime { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionFilter other &&
                (this.States == null && other.States == null ||
                 this.States?.Equals(other.States) == true) &&
                (this.DateField == null && other.DateField == null ||
                 this.DateField?.Equals(other.DateField) == true) &&
                (this.StartDate == null && other.StartDate == null ||
                 this.StartDate?.Equals(other.StartDate) == true) &&
                (this.EndDate == null && other.EndDate == null ||
                 this.EndDate?.Equals(other.EndDate) == true) &&
                (this.StartDatetime == null && other.StartDatetime == null ||
                 this.StartDatetime?.Equals(other.StartDatetime) == true) &&
                (this.EndDatetime == null && other.EndDatetime == null ||
                 this.EndDatetime?.Equals(other.EndDatetime) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.States = {(this.States == null ? "null" : $"[{string.Join(", ", this.States)} ]")}");
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}