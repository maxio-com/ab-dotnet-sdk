// <copyright file="CalendarBilling.cs" company="APIMatic">
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
using AdvancedBilling.Standard.Models.Containers;
using AdvancedBilling.Standard.Utilities;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CalendarBilling.
    /// </summary>
    public class CalendarBilling : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarBilling"/> class.
        /// </summary>
        public CalendarBilling()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarBilling"/> class.
        /// </summary>
        /// <param name="snapDay">snap_day.</param>
        /// <param name="calendarBillingFirstCharge">calendar_billing_first_charge.</param>
        public CalendarBilling(
            CalendarBillingSnapDay snapDay = null,
            Models.FirstChargeType? calendarBillingFirstCharge = null)
        {
            this.SnapDay = snapDay;
            this.CalendarBillingFirstCharge = calendarBillingFirstCharge;
        }

        /// <summary>
        /// A day of month that subscription will be processed on. Can be 1 up to 28 or 'end'.
        /// </summary>
        [JsonProperty("snap_day", NullValueHandling = NullValueHandling.Ignore)]
        public CalendarBillingSnapDay SnapDay { get; set; }

        /// <summary>
        /// Gets or sets CalendarBillingFirstCharge.
        /// </summary>
        [JsonProperty("calendar_billing_first_charge", NullValueHandling = NullValueHandling.Ignore)]
        public Models.FirstChargeType? CalendarBillingFirstCharge { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CalendarBilling : ({string.Join(", ", toStringOutput)})";
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
            return obj is CalendarBilling other &&                ((this.SnapDay == null && other.SnapDay == null) || (this.SnapDay?.Equals(other.SnapDay) == true)) &&
                ((this.CalendarBillingFirstCharge == null && other.CalendarBillingFirstCharge == null) || (this.CalendarBillingFirstCharge?.Equals(other.CalendarBillingFirstCharge) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SnapDay = {(this.SnapDay == null ? "null" : this.SnapDay.ToString())}");
            toStringOutput.Add($"this.CalendarBillingFirstCharge = {(this.CalendarBillingFirstCharge == null ? "null" : this.CalendarBillingFirstCharge.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}