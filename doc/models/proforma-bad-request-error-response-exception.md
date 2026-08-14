
# Proforma Bad Request Error Response Exception

## Structure

`ProformaBadRequestErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | [`ProformaError`](../../doc/models/proforma-error.md) | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ProformaBadRequestErrorResponseException)
    {
        // TODO: Handle ProformaBadRequestErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

