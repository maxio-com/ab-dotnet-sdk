
# Event Based Billing Segment Write Error Response Exception

Errors returned when creating or updating a single segment. Validation problems use the per-field error map; a write to a subscription's custom price point returns a `price_point` error.

## Structure

`EventBasedBillingSegmentWriteErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `object` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is EventBasedBillingSegmentWriteErrorResponseException)
    {
        // TODO: Handle EventBasedBillingSegmentWriteErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

