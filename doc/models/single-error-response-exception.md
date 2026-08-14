
# Single Error Response Exception

## Structure

`SingleErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Error` | `string` | Required | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SingleErrorResponseException)
    {
        // TODO: Handle SingleErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

