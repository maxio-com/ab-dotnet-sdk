// <copyright file="ListCouponsFilter.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace AdvancedBilling.Standard.Models
{
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

    /// <summary>
    /// ListCouponsFilter.
    /// </summary>
    public class ListCouponsFilter : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCouponsFilter"/> class.
        /// </summary>
        public ListCouponsFilter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCouponsFilter"/> class.
        /// </summary>
        /// <param name="dateField">date_field.</param>
        /// <param name="startDate">start_date.</param>
        /// <param name="endDate">end_date.</param>
        /// <param name="startDatetime">start_datetime.</param>
        /// <param name="endDatetime">end_datetime.</param>
        /// <param name="ids">ids.</param>
        /// <param name="codes">codes.</param>
        /// <param name="useSiteExchangeRate">use_site_exchange_rate.</param>
        public ListCouponsFilter(
            Models.BasicDateField? dateField = null,
            DateTime? startDate = null,
            DateTime? endDate = null,
            DateTimeOffset? startDatetime = null,
            DateTimeOffset? endDatetime = null,
            List<int> ids = null,
            List<string> codes = null,
            bool? useSiteExchangeRate = null)
        {
            this.DateField = dateField;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.StartDatetime = startDatetime;
            this.EndDatetime = endDatetime;
            this.Ids = ids;
            this.Codes = codes;
            this.UseSiteExchangeRate = useSiteExchangeRate;
        }

        /// <summary>
        /// The type of filter you would like to apply to your search. Use in query `filter[date_field]=created_at`.
        /// </summary>
        [JsonProperty("date_field", NullValueHandling = NullValueHandling.Ignore)]
        public Models.BasicDateField? DateField { get; set; }

        /// <summary>
        /// The start date (format YYYY-MM-DD) with which to filter the date_field. Returns coupons with a timestamp at or after midnight (12:00:00 AM) in your site’s time zone on the date specified. Use in query `filter[start_date]=2011-12-17`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("start_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The end date (format YYYY-MM-DD) with which to filter the date_field. Returns coupons with a timestamp up to and including 11:59:59PM in your site’s time zone on the date specified. Use in query `filter[end_date]=2011-12-15`.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("end_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The start date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns coupons with a timestamp at or after exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of start_date. Use in query `filter[start_datetime]=2011-12-19T10:15:30+01:00`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("start_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDatetime { get; set; }

        /// <summary>
        /// The end date and time (format YYYY-MM-DD HH:MM:SS) with which to filter the date_field. Returns coupons with a timestamp at or before exact time provided in query. You can specify timezone in query - otherwise your site's time zone will be used. If provided, this parameter will be used instead of end_date. Use in query `filter[end_datetime]=2011-12-1T10:15:30+01:00`.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("end_datetime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDatetime { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching id based on provided values. Use in query `filter[ids]=1,2,3`.
        /// </summary>
        [JsonProperty("ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<int> Ids { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching codes based on provided values. Use in query `filter[codes]=free,free_trial`.
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Codes { get; set; }

        /// <summary>
        /// Allows fetching coupons with matching use_site_exchange_rate based on provided value. Use in query `filter[use_site_exchange_rate]=true`.
        /// </summary>
        [JsonProperty("use_site_exchange_rate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSiteExchangeRate { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListCouponsFilter : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is ListCouponsFilter other &&                ((this.DateField == null && other.DateField == null) || (this.DateField?.Equals(other.DateField) == true)) &&
                ((this.StartDate == null && other.StartDate == null) || (this.StartDate?.Equals(other.StartDate) == true)) &&
                ((this.EndDate == null && other.EndDate == null) || (this.EndDate?.Equals(other.EndDate) == true)) &&
                ((this.StartDatetime == null && other.StartDatetime == null) || (this.StartDatetime?.Equals(other.StartDatetime) == true)) &&
                ((this.EndDatetime == null && other.EndDatetime == null) || (this.EndDatetime?.Equals(other.EndDatetime) == true)) &&
                ((this.Ids == null && other.Ids == null) || (this.Ids?.Equals(other.Ids) == true)) &&
                ((this.Codes == null && other.Codes == null) || (this.Codes?.Equals(other.Codes) == true)) &&
                ((this.UseSiteExchangeRate == null && other.UseSiteExchangeRate == null) || (this.UseSiteExchangeRate?.Equals(other.UseSiteExchangeRate) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.DateField = {(this.DateField == null ? "null" : this.DateField.ToString())}");
            toStringOutput.Add($"this.StartDate = {(this.StartDate == null ? "null" : this.StartDate.ToString())}");
            toStringOutput.Add($"this.EndDate = {(this.EndDate == null ? "null" : this.EndDate.ToString())}");
            toStringOutput.Add($"this.StartDatetime = {(this.StartDatetime == null ? "null" : this.StartDatetime.ToString())}");
            toStringOutput.Add($"this.EndDatetime = {(this.EndDatetime == null ? "null" : this.EndDatetime.ToString())}");
            toStringOutput.Add($"this.Ids = {(this.Ids == null ? "null" : $"[{string.Join(", ", this.Ids)} ]")}");
            toStringOutput.Add($"this.Codes = {(this.Codes == null ? "null" : $"[{string.Join(", ", this.Codes)} ]")}");
            toStringOutput.Add($"this.UseSiteExchangeRate = {(this.UseSiteExchangeRate == null ? "null" : this.UseSiteExchangeRate.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}