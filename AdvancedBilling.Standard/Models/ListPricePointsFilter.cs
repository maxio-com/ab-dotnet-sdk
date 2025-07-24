// <copyright file="ListPricePointsFilter.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
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
    /// ListPricePointsFilter.
    /// </summary>
    public class ListPricePointsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPricePointsFilter"/> class.
        /// </summary>
        public ListPricePointsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPricePointsFilter"/> class.
        /// </summary>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="type">type.</param>
        /// <param name="ids">ids.</param>
        /// <param name="archivedAt">archived_at.</param>
        public ListPricePointsFilter(
            Models.BasicDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            DateTimeOffset? startDatetime = null,
            DateTimeOffset? endDatetime = null,
            List<Models.PricePointType> type = null,
            List<int> ids = null,
            Models.IncludeNullOrNotNull? archivedAt = null)
        {
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.Type = type;
            this.Ids = ids;
            this.ArchivedAt = archivedAt;
        }

        /// <summary>
        /// The type of filter you would like to apply to your search. Use in query: `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns price points with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns price points with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns price points with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns price points with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDatetime { get; set; }

        /// <summary>
        /// Allows fetching price points with matching type. Use in query: `filter[type]=custom,catalog`.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.PricePointType> Type { get; set; }

        /// <summary>
        /// Allows fetching price points with matching id based on provided values. Use in query: `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Allows fetching price points only if archived_at is present or not. Use in query: `filter[archived_at]=not_null`.
        /// </summary>
        [JsonProperty("archived_at", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IncludeNullOrNotNull? ArchivedAt { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ListPricePointsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ListPricePointsFilter other &&
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
                (this.Type == null && other.Type == null ||
                 this.Type?.Equals(other.Type) == true) &&
                (this.Ids == null && other.Ids == null ||
                 this.Ids?.Equals(other.Ids) == true) &&
                (this.ArchivedAt == null && other.ArchivedAt == null ||
                 this.ArchivedAt?.Equals(other.ArchivedAt) == true) &&
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
            toStringOutput.Add($"StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");
            toStringOutput.Add($"Type = {(this.Type == null ? "null" : $"[{string.Join(", ", this.Type)} ]")}");
            toStringOutput.Add($"Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
            toStringOutput.Add($"ArchivedAt = {(this.ArchivedAt == null ? "null" : this.ArchivedAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}