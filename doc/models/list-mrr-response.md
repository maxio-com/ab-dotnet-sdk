
# List MRR Response

## Structure

`ListMRRResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Mrr` | [`ListMRRResponseResult`](../../doc/models/list-mrr-response-result.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

ListMRRResponse listMRRResponse = new ListMRRResponse
{
    Mrr = new ListMRRResponseResult
    {
        Page = 30,
        PerPage = 198,
        TotalPages = 92,
        TotalEntries = 188,
        Currency = "currency4",
    },
};
```

