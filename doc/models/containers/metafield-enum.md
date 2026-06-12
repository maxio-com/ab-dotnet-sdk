
# Metafield Enum

## Class Name

`MetafieldEnum`

## Cases

| Type | Factory Method |
|  --- | --- |
| `string` | MetafieldEnum.FromString(string mString) |
| `List<string>` | MetafieldEnum.FromListOfString(List<string> listOfString) |

## string

### Initialization Code

#### Example

```csharp
MetafieldEnum value = MetafieldEnum.FromString("String0");
```

## List<string>

### Initialization Code

#### Example

```csharp
MetafieldEnum value = MetafieldEnum.FromListOfString(
    new List<string>
    {
        "String1",
    }
);
```

