// <copyright file="ReactivateSubscriptionGroupRequest.cs" company="APIMatic">
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
    /// ReactivateSubscriptionGroupRequest.
    /// </summary>
    public class ReactivateSubscriptionGroupRequest : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionGroupRequest"/> class.
        /// </summary>
        public ReactivateSubscriptionGroupRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReactivateSubscriptionGroupRequest"/> class.
        /// </summary>
        /// <param name="resume">resume.</param>
        /// <param name="resumeMembers">resume_members.</param>
        public ReactivateSubscriptionGroupRequest(
            bool? resume = null,
            bool? resumeMembers = null)
        {
            this.Resume = resume;
            this.ResumeMembers = resumeMembers;
        }

        /// <summary>
        /// Gets or sets Resume.
        /// </summary>
        [JsonProperty("resume", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resume { get; set; }

        /// <summary>
        /// Gets or sets ResumeMembers.
        /// </summary>
        [JsonProperty("resume_members", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResumeMembers { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"ReactivateSubscriptionGroupRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is ReactivateSubscriptionGroupRequest other &&
                (this.Resume == null && other.Resume == null ||
                 this.Resume?.Equals(other.Resume) == true) &&
                (this.ResumeMembers == null && other.ResumeMembers == null ||
                 this.ResumeMembers?.Equals(other.ResumeMembers) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Resume = {(this.Resume == null ? "null" : this.Resume.ToString())}");
            toStringOutput.Add($"this.ResumeMembers = {(this.ResumeMembers == null ? "null" : this.ResumeMembers.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}