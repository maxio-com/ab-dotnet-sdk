
# Subscription Group Create Error Response Exception

## Structure

`SubscriptionGroupCreateErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`SubscriptionGroupCreateErrorResponseErrors`](../../doc/models/containers/subscription-group-create-error-response-errors.md) | Required | This is a container for one-of cases. |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionGroupCreateErrorResponseException)
    {
        // TODO: Handle SubscriptionGroupCreateErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

