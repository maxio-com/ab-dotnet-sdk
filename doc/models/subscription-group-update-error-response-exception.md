
# Subscription Group Update Error Response Exception

## Structure

`SubscriptionGroupUpdateErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`SubscriptionGroupUpdateError`](../../doc/models/subscription-group-update-error.md) | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionGroupUpdateErrorResponseException)
    {
        // TODO: Handle SubscriptionGroupUpdateErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

