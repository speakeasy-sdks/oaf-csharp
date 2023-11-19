# SendinModelRequestBody


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `MixedModel`                                                                 | [MixedModel](../../Models/Shared/MixedModel.md)                              | :heavy_check_mark:                                                           | This class contains mix of scalar and non scalar types in oneOf/anyOf cases. |
| `NonScalarModel`                                                             | [NonScalarModel](../../Models/Shared/NonScalarModel.md)                      | :heavy_check_mark:                                                           | This class contains non scalar types in oneOf/anyOf cases.                   |
| `ScalarModel`                                                                | [ScalarModel](../../Models/Shared/ScalarModel.md)                            | :heavy_minus_sign:                                                           | This class contains scalar types in oneOf/anyOf cases.                       |