// <copyright file="SubscriptionProductMigrationRequest.cs" company="APIMatic">
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
    using JsonSubTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// SubscriptionProductMigrationRequest.
    /// </summary>
    public class SubscriptionProductMigrationRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMigrationRequest"/> class.
        /// </summary>
        public SubscriptionProductMigrationRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionProductMigrationRequest"/> class.
        /// </summary>
        /// <param name="migration">migration.</param>
        public SubscriptionProductMigrationRequest(
            Models.SubscriptionProductMigration migration)
        {
            this.Migration = migration;
        }

        /// <summary>
        /// Gets or sets Migration.
        /// </summary>
        [JsonProperty("migration")]
        public Models.SubscriptionProductMigration Migration { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"SubscriptionProductMigrationRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is SubscriptionProductMigrationRequest other &&                ((this.Migration == null && other.Migration == null) || (this.Migration?.Equals(other.Migration) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Migration = {(this.Migration == null ? "null" : this.Migration.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}