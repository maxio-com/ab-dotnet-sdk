// <copyright file="OfferSignupPage.cs" company="APIMatic">
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
    /// OfferSignupPage.
    /// </summary>
    public class OfferSignupPage : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferSignupPage"/> class.
        /// </summary>
        public OfferSignupPage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferSignupPage"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="enabled">enabled.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="returnParams">return_params.</param>
        /// <param name="url">url.</param>
        public OfferSignupPage(
            int? id = null,
            string nickname = null,
            bool? enabled = null,
            string returnUrl = null,
            string returnParams = null,
            string url = null)
        {
            this.Id = id;
            this.Nickname = nickname;
            this.Enabled = enabled;
            this.ReturnUrl = returnUrl;
            this.ReturnParams = returnParams;
            this.Url = url;
        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets Nickname.
        /// </summary>
        [JsonProperty("nickname", NullValueHandling = NullValueHandling.Ignore)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or sets Enabled.
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets ReturnUrl.
        /// </summary>
        [JsonProperty("return_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Gets or sets ReturnParams.
        /// </summary>
        [JsonProperty("return_params", NullValueHandling = NullValueHandling.Ignore)]
        public string ReturnParams { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"OfferSignupPage : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is OfferSignupPage other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
                (this.Nickname == null && other.Nickname == null ||
                 this.Nickname?.Equals(other.Nickname) == true) &&
                (this.Enabled == null && other.Enabled == null ||
                 this.Enabled?.Equals(other.Enabled) == true) &&
                (this.ReturnUrl == null && other.ReturnUrl == null ||
                 this.ReturnUrl?.Equals(other.ReturnUrl) == true) &&
                (this.ReturnParams == null && other.ReturnParams == null ||
                 this.ReturnParams?.Equals(other.ReturnParams) == true) &&
                (this.Url == null && other.Url == null ||
                 this.Url?.Equals(other.Url) == true) &&
                base.Equals(obj);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"Nickname = {this.Nickname ?? "null"}");
            toStringOutput.Add($"Enabled = {(this.Enabled == null ? "null" : this.Enabled.ToString())}");
            toStringOutput.Add($"ReturnUrl = {this.ReturnUrl ?? "null"}");
            toStringOutput.Add($"ReturnParams = {this.ReturnParams ?? "null"}");
            toStringOutput.Add($"Url = {this.Url ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}