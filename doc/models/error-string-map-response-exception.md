
# Error String Map Response Exception

## Structure

`ErrorStringMapResponseException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Errors` | `Dictionary<string, string>` | Optional | - |

## Example

```csharp
try
{
    // make the API call
}
catch (ApiException e)
{
    if (e is ErrorStringMapResponseException)
    {
        // TODO: Handle ErrorStringMapResponseException
        Console.WriteLine(e.Message);
    }
}
```

