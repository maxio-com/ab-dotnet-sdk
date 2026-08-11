
# Event Based Billing Segment Exception

## Structure

`EventBasedBillingSegmentException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`EventBasedBillingSegmentError`](../../doc/models/event-based-billing-segment-error.md) | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is EventBasedBillingSegmentException)
    {
        // TODO: Handle EventBasedBillingSegmentException
        Console.WriteLine(e.Message);
    }
}
```

