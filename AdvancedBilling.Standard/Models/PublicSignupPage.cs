// <copyright file="PublicSignupPage.cs" company="APIMatic">
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
    /// PublicSignupPage.
    /// </summary>
    public class PublicSignupPage : BaseModel
    {
        private string returnUrl;
        private string returnParams;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "return_url", false },
            { "return_params", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSignupPage"/> class.
        /// </summary>
        public PublicSignupPage()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicSignupPage"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="returnUrl">return_url.</param>
        /// <param name="returnParams">return_params.</param>
        /// <param name="url">url.</param>
        public PublicSignupPage(
            int? id = null,
            string returnUrl = null,
            string returnParams = null,
            string url = null)
        {
            this.Id = id;

            if (returnUrl != null)
            {
                this.ReturnUrl = returnUrl;
            }

            if (returnParams != null)
            {
                this.ReturnParams = returnParams;
            }
            this.Url = url;
        }

        /// <summary>
        /// The id of the signup page (public_signup_pages only)
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// The url to which a customer will be returned after a successful signup (public_signup_pages only)
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl
        {
            get
            {
                return this.returnUrl;
            }

            set
            {
                this.shouldSerialize["return_url"] = true;
                this.returnUrl = value;
            }
        }

        /// <summary>
        /// The params to be appended to the return_url (public_signup_pages only)
        /// </summary>
        [JsonProperty("return_params")]
        public string ReturnParams
        {
            get
            {
                return this.returnParams;
            }

            set
            {
                this.shouldSerialize["return_params"] = true;
                this.returnParams = value;
            }
        }

        /// <summary>
        /// The url where the signup page can be viewed (public_signup_pages only)
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"PublicSignupPage : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReturnUrl()
        {
            this.shouldSerialize["return_url"] = false;
        }

        /// <summary>
        /// Marks the field to not be serialized.
        /// </summary>
        public void UnsetReturnParams()
        {
            this.shouldSerialize["return_params"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReturnUrl()
        {
            return this.shouldSerialize["return_url"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReturnParams()
        {
            return this.shouldSerialize["return_params"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is PublicSignupPage other &&
                (this.Id == null && other.Id == null ||
                 this.Id?.Equals(other.Id) == true) &&
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
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id.ToString())}");
            toStringOutput.Add($"this.ReturnUrl = {this.ReturnUrl ?? "null"}");
            toStringOutput.Add($"this.ReturnParams = {this.ReturnParams ?? "null"}");
            toStringOutput.Add($"this.Url = {this.Url ?? "null"}");

            base.ToString(toStringOutput);
        }
    }
}