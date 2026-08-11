
# Event Based Billing Segment Errors Exception

## Structure

`EventBasedBillingSegmentErrorsException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `object` | Optional | The key of the object would be a number (an index in the request array) where the error occurred. In the value object, the key represents the field and the value is an array with error messages. In most cases, this object would contain just one key. |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is EventBasedBillingSegmentErrorsException)
    {
        // TODO: Handle EventBasedBillingSegmentErrorsException
        Console.WriteLine(e.Message);
    }
}
```

