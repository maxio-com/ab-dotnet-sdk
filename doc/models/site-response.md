
# Site Response

## Structure

`SiteResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Site` | [`Site`](../../doc/models/site.md) | Required | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;

SiteResponse siteResponse = new SiteResponse
{
    Site = new Site
    {
        Id = 64,
        Name = "name4",
        Subdomain = "subdomain0",
        Currency = "currency4",
        SellerId = 228,
    },
};
```

