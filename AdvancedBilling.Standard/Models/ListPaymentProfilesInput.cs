// <copyright file="ListPaymentProfilesInput.cs" company="APIMatic">
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
    /// ListPaymentProfilesInput.
    /// </summary>
    public class ListPaymentProfilesInput : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaymentProfilesInput"/> class.
        /// </summary>
        public ListPaymentProfilesInput()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListPaymentProfilesInput"/> class.
        /// </summary>
        /// <param name="page">page.</param>
        /// <param name="perPage">per_page.</param>
        /// <param name="customerId">customer_id.</param>
        public ListPaymentProfilesInput(
            int? page = 1,
            int? perPage = 20,
            int? customerId = null)
        {
            this.Page = page;
            this.PerPage = perPage;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Result records are organized in pages. By default, the first page of results is displayed. The page parameter specifies a page number of results to fetch. You can start navigating through the pages to consume the results. You do this by passing in a page parameter. Retrieve the next page by adding ?page=2 to the query string. If there are no results to return, then an empty result set will be returned.
        /// Use in query `page=1`.
        /// </summary>
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int? Page { get; set; }

        /// <summary>
        /// This parameter indicates how many records to fetch in each request. Default value is 20. The maximum allowed values is 200; any per_page value over 200 will be changed to 200.
        /// Use in query `per_page=200`.
        /// </summary>
        [JsonProperty("per_page", NullValueHandling = NullValueHandling.Ignore)]
        public int? PerPage { get; set; }

        /// <summary>
        /// The ID of the customer for which you wish to list payment profiles
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ListPaymentProfilesInput : ({string.Join(", ", toStringOutput)})";
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
            return obj is ListPaymentProfilesInput other &&                ((this.Page == null && other.Page == null) || (this.Page?.Equals(other.Page) == true)) &&
                ((this.PerPage == null && other.PerPage == null) || (this.PerPage?.Equals(other.PerPage) == true)) &&
                ((this.CustomerId == null && other.CustomerId == null) || (this.CustomerId?.Equals(other.CustomerId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Page = {(this.Page == null ? "null" : this.Page.ToString())}");
            toStringOutput.Add($"this.PerPage = {(this.PerPage == null ? "null" : this.PerPage.ToString())}");
            toStringOutput.Add($"this.CustomerId = {(this.CustomerId == null ? "null" : this.CustomerId.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}