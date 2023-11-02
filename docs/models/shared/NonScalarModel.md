# NonScalarModel

This class contains non scalar types in oneOf/anyOf cases.


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `AllInnerArrayOfMap`                                              | *object*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `AllInnerArrayOfMap2`                                             | Dictionary<String, *object*>                                      | :heavy_check_mark:                                                | N/A                                                               |
| `MultiAnyOf`                                                      | *object*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `MultiOneOfAnyOf`                                                 | *object*                                                          | :heavy_check_mark:                                                | N/A                                                               |
| `OuterArrayOfMap`                                                 | List<Dictionary<String, *object*>>                                | :heavy_minus_sign:                                                | N/A                                                               |
| `OuterArrayOfMap2`                                                | List<Dictionary<String, List<[Car](../../models/shared/Car.md)>>> | :heavy_minus_sign:                                                | N/A                                                               |
| `OuterMapOfArray`                                                 | Dictionary<String, List<*object*>>                                | :heavy_minus_sign:                                                | N/A                                                               |
| `OuterMapOfArray2`                                                | Dictionary<String, List<*object*>>                                | :heavy_minus_sign:                                                | N/A                                                               |
| `OuterMapOfSingleInnerArray`                                      | Dictionary<String, *object*>                                      | :heavy_check_mark:                                                | N/A                                                               |
| `SingleInnerMapOfArray`                                           | *object*                                                          | :heavy_check_mark:                                                | N/A                                                               |