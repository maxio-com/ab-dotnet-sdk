
# Aggregated Entitlements Response

## Structure

`AggregatedEntitlementsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SubscriptionId` | `int` | Required | - |
| `CustomerId` | `int` | Required | - |
| `Status` | `string` | Required | The subscription's current state, e.g. `active`, `trialing`, `canceled`. |
| `Entitlements` | [`List<AggregatedEntitlement>`](../../doc/models/aggregated-entitlement.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using AdvancedBilling.Standard.Models.Containers;
using System.Collections.Generic;

AggregatedEntitlementsResponse aggregatedEntitlementsResponse = new AggregatedEntitlementsResponse
{
    SubscriptionId = 114,
    CustomerId = 42,
    Status = "status6",
    Entitlements = new List<AggregatedEntitlement>
    {
        new AggregatedEntitlement
        {
            FeatureKey = "feature.sso",
            PeriodicityKey = "usage.api_calls:1:month",
            Name = "name6",
            Type = FeatureKind.ServiceRight,
            MValue = AggregatedEntitlementValue.FromBoolean(true),
        },
    },
};
```

