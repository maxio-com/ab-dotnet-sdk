
# Subscriptions Mrr Error Response Exception

## Structure

`SubscriptionsMrrErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`AttributeError`](../../doc/models/attribute-error.md) | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SubscriptionsMrrErrorResponseException)
    {
        // TODO: Handle SubscriptionsMrrErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

