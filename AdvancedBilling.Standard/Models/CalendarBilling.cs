// <copyright file="CalendarBilling.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using AdvancedBilling.Standard.Models.Containers;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AdvancedBilling.Standard.Models
{
    /// <summary>
    /// CalendarBilling.
    /// </summary>
    public class CalendarBilling : BaseModel
    {
        private CalendarBillingSnapDay snapDay;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "snap_day", false },
        };

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

            if (snapDay != null)
            {
                this.SnapDay = snapDay;
            }
            this.CalendarBillingFirstCharge = calendarBillingFirstCharge;
        }

        /// <summary>
        /// A day of month that subscription will be processed on. Can be 1 up to 28 or 'end'.
        /// </summary>
        [JsonProperty("snap_day")]
        public CalendarBillingSnapDay SnapDay
        {
            get
            {
                return this.snapDay;
            }

            set
            {
                this.shouldSerialize["snap_day"] = true;
                this.snapDay = value;
            }
        }

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

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetSnapDay()
        {
            this.shouldSerialize["snap_day"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSnapDay()
        {
            return this.shouldSerialize["snap_day"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is CalendarBilling other &&
                (this.SnapDay == null && other.SnapDay == null ||
                 this.SnapDay?.Equals(other.SnapDay) == true) &&
                (this.CalendarBillingFirstCharge == null && other.CalendarBillingFirstCharge == null ||
                 this.CalendarBillingFirstCharge?.Equals(other.CalendarBillingFirstCharge) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"SnapDay = {(this.SnapDay == null ? "null" : this.SnapDay.ToString())}");
            toStringOutput.Add($"CalendarBillingFirstCharge = {(this.CalendarBillingFirstCharge == null ? "null" : this.CalendarBillingFirstCharge.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}