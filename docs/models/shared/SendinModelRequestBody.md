# SendinModelRequestBody


## Fields

| Field                                                                        | Type                                                                         | Required                                                                     | Description                                                                  |
| ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---------------------------------------------------------------------------- |
| `MixedModel`                                                                 | [MixedModel](../../models/shared/MixedModel.md)                              | :heavy_check_mark:                                                           | This class contains mix of scalar and non scalar types in oneOf/anyOf cases. |
| `NonScalarModel`                                                             | [NonScalarModel](../../models/shared/NonScalarModel.md)                      | :heavy_check_mark:                                                           | This class contains non scalar types in oneOf/anyOf cases.                   |
| `ScalarModel`                                                                | [ScalarModel](../../models/shared/ScalarModel.md)                            | :heavy_minus_sign:                                                           | This class contains scalar types in oneOf/anyOf cases.                       |