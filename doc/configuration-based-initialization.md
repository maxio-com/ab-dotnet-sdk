
# Configuration-Based Initialization

Sdk Client initialization through configuration.

The SDK client can also be initialized directly from an `IConfiguration` instance using the `FromConfiguration` method available on the `Builder` or `SDKClient` class.

This enables the SDK to automatically read configuration values from various sources such as JSON files, environment variables, or other .NET configuration providers.

If a required environment variable or configuration value is missing, the SDK will fall back to its default configuration value.

## Example: Initializing SDK Client from Configuration

The following code sample demonstrates how to initialize the SDK client using an `IConfiguration` section.

The `Builder.FromConfiguration` method reads values from the provided configuration section and returns a builder instance, allowing you to override specific properties directly in code if needed before building the final client.

```csharp
using AdvancedBilling.Standard;
using Microsoft.Extensions.Configuration;
using Environment = AdvancedBilling.Standard.Environment;

namespace ConsoleApp;

// Build the IConfiguration using .NET conventions (JSON, environment, etc.)
var configuration = new ConfigurationBuilder()
    .AddJsonFile("config.json")
    .AddEnvironmentVariables() // [optional] read environment variables
    .Build();

// Instantiate your SDK builder and configure it from IConfiguration with overrides
var client = AdvancedBillingClient.Builder
    .FromConfiguration(configuration.GetSection("AdvancedBilling"))
    .Environment(Environment.US)
    .HttpClientConfig(c => c.Timeout(TimeSpan.FromSeconds(60)))
    .Build();
```

## Example Configuration File

```csharp
{
  "AdvancedBilling": {
    "Environment": "us",
    "Site": "site",
    "BasicAuthCredentials": {
      "Username": "username",
      "Password": "password",
    },
    "HttpClientConfig": {
      "Timeout": "00:01:00",
      "NumberOfRetries": 3,
      "BackoffFactor": 2,
      "RetryInterval": 1,
      "MaximumRetryWaitTime": "00:02:00",
      "StatusCodesToRetry": [408, 413],
      "RequestMethodsToRetry": ["GET", "PUT", "DELETE"],
      "ProxyConfiguration": {
        "Address": "http://localhost:3000",
        "Port": 8080,
        "Tunnel": false,
        "User": "username",
        "Pass": "password",
      }
    }
  }
}
```

