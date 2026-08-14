
# Public Key

## Structure

`PublicKey`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PublicKey` | `string` | Optional | - |
| `RequiresSecurityToken` | `bool?` | Optional | - |
| `CreatedAt` | `DateTimeOffset?` | Optional | - |

## Example

```csharp
using AdvancedBilling.Standard.Models;
using System.Globalization;

PublicKey publicKey = new PublicKey
{
    PublicKeyProp = "public_key2",
    RequiresSecurityToken = false,
    CreatedAt = DateTime.ParseExact("2016-03-13T12:52:32.123Z", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
};
```

