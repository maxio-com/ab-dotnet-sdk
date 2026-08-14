
# Subscription Component Allocation Error Exception

## Structure

`SubscriptionComponentAllocationErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`List<SubscriptionComponentAllocationErrorItem>`](../../doc/models/subscription-component-allocation-error-item.md) | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionComponentAllocationErrorException)
    {
        // TODO: Handle SubscriptionComponentAllocationErrorException
        Console.WriteLine(e.Message);
    }
}
```

