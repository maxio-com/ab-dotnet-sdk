
# Create Metafields Request Metafields

## Class Name

`CreateMetafieldsRequestMetafields`

## Cases

| Type | Factory Method |
|  --- | --- |
| [`CreateMetafield`](../../../doc/models/create-metafield.md) | CreateMetafieldsRequestMetafields.FromCreateMetafield(CreateMetafield createMetafield) |
| [`List<CreateMetafield>`](../../../doc/models/create-metafield.md) | CreateMetafieldsRequestMetafields.FromListOfCreateMetafield(List<CreateMetafield> listOfCreateMetafield) |

## CreateMetafield

### Initialization Code

#### Example

```csharp
CreateMetafieldsRequestMetafields value = CreateMetafieldsRequestMetafields.FromCreateMetafield(
    new CreateMetafield
    {
        Name = "my_field",
        Scope = new MetafieldScope
        {
            Csv = IncludeOption.Exclude,
            Invoices = IncludeOption.Exclude,
            Statements = IncludeOption.Exclude,
            Portal = IncludeOption.Exclude,
            PublicShow = IncludeOption.Exclude,
            PublicEdit = IncludeOption.Exclude,
        },
        InputType = MetafieldInput.Text,
        MEnum = new List<string>
        {
            "string",
        },
    }
);
```

## List<CreateMetafield>

### Initialization Code

#### Example

```csharp
CreateMetafieldsRequestMetafields value = CreateMetafieldsRequestMetafields.FromListOfCreateMetafield(
    new List<CreateMetafield>
    {
        new CreateMetafield
        {
        },
    }
);
```

