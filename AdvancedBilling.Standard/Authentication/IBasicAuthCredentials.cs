// <copyright file="IBasicAuthCredentials.cs" company="APIMatic">
// AdvancedBilling.Standard
//
// This file was automatically generated for Maxio by APIMATIC v3.0 ( https://www.apimatic.io ).
// </copyright>
using System;

namespace AdvancedBilling.Standard.Authentication
{
    /// <summary>
    /// Authentication configuration interface for BasicAuth.
    /// </summary>
    public interface IBasicAuthCredentials
    {
        /// <summary>
        /// Gets string value for basicAuthUserName.
        /// </summary>
        string BasicAuthUserName { get; }

        /// <summary>
        /// Gets string value for basicAuthPassword.
        /// </summary>
        string BasicAuthPassword { get; }

        /// <summary>
        ///  Returns true if credentials matched.
        /// </summary>
        /// <param name="basicAuthUserName"> The string value for credentials.</param>
        /// <param name="basicAuthPassword"> The string value for credentials.</param>
        /// <returns>True if credentials matched.</returns>
        bool Equals(string basicAuthUserName, string basicAuthPassword);
    }
}