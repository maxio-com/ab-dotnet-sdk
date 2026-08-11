
# Subscription Group Signup Error Response Exception

## Structure

`SubscriptionGroupSignupErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`SubscriptionGroupSignupError`](../../doc/models/subscription-group-signup-error.md) | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionGroupSignupErrorResponseException)
    {
        // TODO: Handle SubscriptionGroupSignupErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

