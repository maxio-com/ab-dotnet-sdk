﻿using AdvancedBilling.Standard;
using Environment = AdvancedBilling.Standard.Environment;

namespace AdvancedBillingTests
{
    internal static class InvalidClient
    {
        public static AdvancedBillingClient GetInvalidClient()
        {
            var builder = new AdvancedBillingClient.Builder();
            builder.Environment(Environment.Production);
            builder.Domain("staging-chargify.com");
            builder.Subdomain("dotnet-sdk");
            builder.BasicAuthCredentials("abc", "123");

            return builder.Build();
        }
    }
}