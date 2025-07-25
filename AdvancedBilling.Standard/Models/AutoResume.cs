// <copyright file="AutoResume.cs" company="APIMatic">
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
    /// AutoResume.
    /// </summary>
    public class AutoResume : BaseModel
    {
        private DateTimeOffset? automaticallyResumeAt;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "automatically_resume_at", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoResume"/> class.
        /// </summary>
        public AutoResume()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoResume"/> class.
        /// </summary>
        /// <param name="automaticallyResumeAt">automatically_resume_at.</param>
        public AutoResume(
            DateTimeOffset? automaticallyResumeAt = null)
        {

            if (automaticallyResumeAt != null)
            {
                this.AutomaticallyResumeAt = automaticallyResumeAt;
            }
        }

        /// <summary>
        /// Gets or sets AutomaticallyResumeAt.
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("automatically_resume_at")]
        public DateTimeOffset? AutomaticallyResumeAt
        {
            get
            {
                return this.automaticallyResumeAt;
            }

            set
            {
                this.shouldSerialize["automatically_resume_at"] = true;
                this.automaticallyResumeAt = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"AutoResume : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetAutomaticallyResumeAt()
        {
            this.shouldSerialize["automatically_resume_at"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAutomaticallyResumeAt()
        {
            return this.shouldSerialize["automatically_resume_at"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is AutoResume other &&
                (this.AutomaticallyResumeAt == null && other.AutomaticallyResumeAt == null ||
                 this.AutomaticallyResumeAt?.Equals(other.AutomaticallyResumeAt) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AutomaticallyResumeAt = {(this.AutomaticallyResumeAt == null ? "null" : this.AutomaticallyResumeAt.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}