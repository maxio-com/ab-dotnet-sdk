// <copyright file="SubscriptionMigrationPreviewResponse.cs" company="APIMatic">
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
    /// SubscriptionMigrationPreviewResponse.
    /// </summary>
    public class SubscriptionMigrationPreviewResponse : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMigrationPreviewResponse"/> class.
        /// </summary>
        public SubscriptionMigrationPreviewResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionMigrationPreviewResponse"/> class.
        /// </summary>
        /// <param name="migration">migration.</param>
        public SubscriptionMigrationPreviewResponse(
            Models.SubscriptionMigrationPreview migration)
        {
            this.Migration = migration;
        }

        /// <summary>
        /// Gets or sets Migration.
        /// </summary>
        [JsonProperty("migration")]
        public Models.SubscriptionMigrationPreview Migration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"SubscriptionMigrationPreviewResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is SubscriptionMigrationPreviewResponse other &&
                (this.Migration == null && other.Migration == null ||
                 this.Migration?.Equals(other.Migration) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Migration = {(this.Migration == null ? "null" : this.Migration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}