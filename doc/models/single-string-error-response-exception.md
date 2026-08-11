
# Single String Error Response Exception

## Structure

`SingleStringErrorResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `string` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is SingleStringErrorResponseException)
    {
        // TODO: Handle SingleStringErrorResponseException
        Console.WriteLine(e.Message);
    }
}
```

