
# Error Array Map Response Exception

## Structure

`ErrorArrayMapResponseException`

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
    if (e is ErrorArrayMapResponseException)
    {
        // TODO: Handle ErrorArrayMapResponseException
        Console.WriteLine(e.Message);
    }
}
```

