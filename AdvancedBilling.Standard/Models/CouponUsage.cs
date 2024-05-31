// <copyright file="CouponUsage.cs" company="APIMatic">
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
    /// CouponUsage.
    /// </summary>
    public class CouponUsage : BaseModel
    {
        private int? savings;
        private long? savingsInCents;
        private int? revenue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "savings", false },
            { "savings_in_cents", false },
            { "revenue", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponUsage"/> class.
        /// </summary>
        public CouponUsage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CouponUsage"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="signups">signups.</param>
        /// <param name="savings">savings.</param>
        /// <param name="savingsInCents">savings_in_cents.</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="revenueInCents">revenue_in_cents.</param>
        public CouponUsage(
            int? id = null,
            string name = null,
            int? signups = null,
            int? savings = null,
            long? savingsInCents = null,
            int? revenue = null,
            long? revenueInCents = null)
        {
            this.Id = id;
            this.Name = name;
            this.Signups = signups;
            if (savings != null)
            {
                this.Savings = savings;
            }

            if (savingsInCents != null)
            {
                this.SavingsInCents = savingsInCents;
            }

            if (revenue != null)
            {
                this.Revenue = revenue;
            }

            this.RevenueInCents = revenueInCents;
        }

        /// <summary>
        /// The Chargify id of the product
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Name of the product
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Number of times the coupon has been applied
        /// </summary>
        [JsonProperty("signups", NullValueHandling = NullValueHandling.Ignore)]
        public int? Signups { get; set; }

        /// <summary>
        /// Dollar amount of customer savings as a result of the coupon.
        /// </summary>
        [JsonProperty("savings")]
        public int? Savings
        {
            get
            {
                return this.savings;
            }

            set
            {
                this.shouldSerialize["savings"] = true;
                this.savings = value;
            }
        }

        /// <summary>
        /// Dollar amount of customer savings as a result of the coupon.
        /// </summary>
        [JsonProperty("savings_in_cents")]
        public long? SavingsInCents
        {
            get
            {
                return this.savingsInCents;
            }

            set
            {
                this.shouldSerialize["savings_in_cents"] = true;
                this.savingsInCents = value;
            }
        }

        /// <summary>
        /// Total revenue of the all subscriptions that have received a discount from this coupon.
        /// </summary>
        [JsonProperty("revenue")]
        public int? Revenue
        {
            get
            {
                return this.revenue;
            }

            set
            {
                this.shouldSerialize["revenue"] = true;
                this.revenue = value;
            }
        }

        /// <summary>
        /// Total revenue of the all subscriptions that have received a discount from this coupon.
        /// </summary>
        [JsonProperty("revenue_in_cents", NullValueHandling = NullValueHandling.Ignore)]
        public long? RevenueInCents { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CouponUsage : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSavings()
        {
            this.shouldSerialize["savings"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSavingsInCents()
        {
            this.shouldSerialize["savings_in_cents"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRevenue()
        {
            this.shouldSerialize["revenue"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSavings()
        {
            return this.shouldSerialize["savings"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSavingsInCents()
        {
            return this.shouldSerialize["savings_in_cents"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRevenue()
        {
            return this.shouldSerialize["revenue"];
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
            return obj is CouponUsage other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Name == null && other.Name == null) || (this.Name?.Equals(other.Name) == true)) &&
                ((this.Signups == null && other.Signups == null) || (this.Signups?.Equals(other.Signups) == true)) &&
                ((this.Savings == null && other.Savings == null) || (this.Savings?.Equals(other.Savings) == true)) &&
                ((this.SavingsInCents == null && other.SavingsInCents == null) || (this.SavingsInCents?.Equals(other.SavingsInCents) == true)) &&
                ((this.Revenue == null && other.Revenue == null) || (this.Revenue?.Equals(other.Revenue) == true)) &&
                ((this.RevenueInCents == null && other.RevenueInCents == null) || (this.RevenueInCents?.Equals(other.RevenueInCents) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.Name = {(this.Name == null ? "null" : this.Name)}");
            toStringOutput.Add($"this.Signups = {(this.Signups == null ? "null" : this.Signups.ToString())}");
            toStringOutput.Add($"this.Savings = {(this.Savings == null ? "null" : this.Savings.ToString())}");
            toStringOutput.Add($"this.SavingsInCents = {(this.SavingsInCents == null ? "null" : this.SavingsInCents.ToString())}");
            toStringOutput.Add($"this.Revenue = {(this.Revenue == null ? "null" : this.Revenue.ToString())}");
            toStringOutput.Add($"this.RevenueInCents = {(this.RevenueInCents == null ? "null" : this.RevenueInCents.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}