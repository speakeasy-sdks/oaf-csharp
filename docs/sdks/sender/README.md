# Sender
(*Sender*)

### Available Operations

* [SendCollectCombined](#sendcollectcombined) - Send CollectCombined
* [SendCombined](#sendcombined) - Send Combined
* [SendMixedParam](#sendmixedparam) - Send MixedParam
* [SendNonScalarParam](#sendnonscalarparam) - Send NonScalarParam
* [SendScalarParam](#sendscalarparam) - Send ScalarParam
* [SendinModel](#sendinmodel) - Send in Model

## SendCollectCombined

Send CollectCombined

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;
using System.Collections.Generic;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendCollectCombinedAsync(new SendCollectCombinedRequestBody() {
    BodyMixed = new List<Dictionary<string, bool>>() {
        new Dictionary<string, bool>() {
            { "key", false },
        },
    },
    BodyNonScalar = new Dictionary<string, object>() {
        { "key", "string" },
    },
    BodyScalar = new List<Dictionary<string, object>>() {
        new Dictionary<string, object>() {
            { "key", "string" },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [SendCollectCombinedRequestBody](../../Models/Shared/SendCollectCombinedRequestBody.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[SendCollectCombinedResponse](../../Models/Operations/SendCollectCombinedResponse.md)**


## SendCombined

Send Combined

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;
using System.Collections.Generic;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendCombinedAsync(new SendCombinedRequestBody() {
    BodyMixed = new List<Dictionary<string, bool>>() {
        new Dictionary<string, bool>() {
            { "key", false },
        },
    },
    BodyNonScalar = new Dictionary<string, object>() {
        { "key", "string" },
    },
    BodyScalar = new List<Dictionary<string, object>>() {
        new Dictionary<string, object>() {
            { "key", "string" },
        },
    },
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [SendCombinedRequestBody](../../Models/Shared/SendCombinedRequestBody.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[SendCombinedResponse](../../Models/Operations/SendCombinedResponse.md)**


## SendMixedParam

Send MixedParam

### Example Usage

```csharp
using OAFComplex;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendMixedParamAsync("0xCf5CD7932D as bytes <<<>>>");

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *byte[]*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[SendMixedParamResponse](../../Models/Operations/SendMixedParamResponse.md)**


## SendNonScalarParam

Send NonScalarParam

### Example Usage

```csharp
using OAFComplex;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendNonScalarParamAsync(new Dictionary<string, object>() {
    { "key", "string" },
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | Dictionary<String, *object*>               | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[SendNonScalarParamResponse](../../Models/Operations/SendNonScalarParamResponse.md)**


## SendScalarParam

Send ScalarParam

### Example Usage

```csharp
using OAFComplex;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendScalarParamAsync(new List<Dictionary<string, object>>() {
    new Dictionary<string, object>() {
        { "key", "string" },
    },
});

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | List<Dictionary<String, *object*>>         | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[SendScalarParamResponse](../../Models/Operations/SendScalarParamResponse.md)**


## SendinModel

Send in Model

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;
using System.Collections.Generic;

var sdk = new OAFComplex();

var res = await sdk.Sender.SendinModelAsync(new SendinModelRequestBody() {
    MixedModel = new MixedModel() {
        AllInnerArrayOfMap = "string",
        AllInnerArrayOfMap2 = new Dictionary<string, object>() {
            { "key", "string" },
        },
        MultiAnyOf = "string",
        MultiOneOfAnyOf = "string",
        OuterArrayOfMap = new List<Dictionary<string, object>>() {
            new Dictionary<string, object>() {
                { "key", "string" },
            },
        },
        OuterArrayOfMap2 = new List<Dictionary<string, List<Car>>>() {
            new Dictionary<string, List<Car>>() {
                { "key", new List<Car>() {
                    new Car() {
                        HaveTrunk = false,
                        NumberOfTyres = "string",
                    },
                } },
            },
        },
        OuterMapOfArray = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfArray2 = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfSingleInnerArray = new Dictionary<string, object>() {
            { "key", "string" },
        },
        SingleInnerMapOfArray = "string",
    },
    NonScalarModel = new NonScalarModel() {
        AllInnerArrayOfMap = "string",
        AllInnerArrayOfMap2 = new Dictionary<string, object>() {
            { "key", "string" },
        },
        MultiAnyOf = "string",
        MultiOneOfAnyOf = "string",
        OuterArrayOfMap = new List<Dictionary<string, object>>() {
            new Dictionary<string, object>() {
                { "key", "string" },
            },
        },
        OuterArrayOfMap2 = new List<Dictionary<string, List<Car>>>() {
            new Dictionary<string, List<Car>>() {
                { "key", new List<Car>() {
                    new Car() {
                        HaveTrunk = false,
                        NumberOfTyres = "string",
                    },
                } },
            },
        },
        OuterMapOfArray = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfArray2 = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfSingleInnerArray = new Dictionary<string, object>() {
            { "key", "string" },
        },
        SingleInnerMapOfArray = "string",
    },
    ScalarModel = new ScalarModel() {
        AllInnerArrayOfMap = "string",
        AllInnerArrayOfMap2 = new Dictionary<string, object>() {
            { "key", "string" },
        },
        MultiAnyOf = "string",
        MultiOneOfAnyOf = "string",
        OuterArrayOfMap = new List<Dictionary<string, object>>() {
            new Dictionary<string, object>() {
                { "key", "string" },
            },
        },
        OuterArrayOfMap2 = new List<Dictionary<string, List<int>>>() {
            new Dictionary<string, List<int>>() {
                { "key", new List<int>() {
                    101696,
                } },
            },
        },
        OuterMapOfArray = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfArray2 = new Dictionary<string, List<object>>() {
            { "key", new List<object>() {
                "string",
            } },
        },
        OuterMapOfSingleInnerArray = new Dictionary<string, object>() {
            { "key", "string" },
        },
        SingleInnerMapOfArray = "string",
    },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [SendinModelRequestBody](../../Models/Shared/SendinModelRequestBody.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[SendinModelResponse](../../Models/Operations/SendinModelResponse.md)**

