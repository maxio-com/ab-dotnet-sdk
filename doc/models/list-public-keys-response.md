
# List Public Keys Response

## Structure

`ListPublicKeysResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ChargifyJsKeys` | [`List<PublicKey>`](../../doc/models/public-key.md) | Optional | - |
| `Meta` | [`ListPublicKeysMeta`](../../doc/models/list-public-keys-meta.md) | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Collections.Generic;
using System.Globalization;

ListPublicKeysResponse listPublicKeysResponse = new ListPublicKeysResponse
{
    ChargifyJsKeys = new List<PublicKey>
    {
        new PublicKey
        {
            PublicKeyProp = "public_key8",
            RequiresSecurityToken = false,
            CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
                provider: CultureInfo.InvariantCulture,
                DateTimeStyles.RoundtripKind),
        },
    },
    Meta = new ListPublicKeysMeta
    {
        TotalCount = 150,
        CurrentPage = 126,
        TotalPages = 138,
        PerPage = 152,
    },
};
```

