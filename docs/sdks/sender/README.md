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

var sdk = new OAFComplexSDK();

SendCollectCombinedRequestBody req = new SendCollectCombinedRequestBody() {
    BodyNonScalar = new Dictionary<string, BodyNonScalar>() {

    },
    BodyScalar = new List<Dictionary<string, BodyScalar>>() {
        new Dictionary<string, BodyScalar>() {
            { "key", BodyScalar.CreateBodyScalarBoolean(
            false,
            ) },
        },
    },
};

var res = await sdk.Sender.SendCollectCombinedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [SendCollectCombinedRequestBody](../../Models/Shared/SendCollectCombinedRequestBody.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[SendCollectCombinedResponse](../../Models/Operations/SendCollectCombinedResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## SendCombined

Send Combined

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;
using System.Collections.Generic;

var sdk = new OAFComplexSDK();

SendCombinedRequestBody req = new SendCombinedRequestBody() {
    BodyNonScalar = new Dictionary<string, SendCombinedRequestBodyBodyNonScalar>() {

    },
    BodyScalar = new List<Dictionary<string, SendCombinedRequestBodyBodyScalar>>() {
        new Dictionary<string, SendCombinedRequestBodyBodyScalar>() {
            { "key", SendCombinedRequestBodyBodyScalar.CreateSendCombinedRequestBodyBodyScalarStr(
            "<value>",
            ) },
        },
    },
};

var res = await sdk.Sender.SendCombinedAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [SendCombinedRequestBody](../../Models/Shared/SendCombinedRequestBody.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[SendCombinedResponse](../../Models/Operations/SendCombinedResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## SendMixedParam

Send MixedParam

### Example Usage

```csharp
using OAFComplex;

var sdk = new OAFComplexSDK();

byte[] req = "0xCf5CD7932D as bytes <<<>>>";

var res = await sdk.Sender.SendMixedParamAsync(req);

// handle response
```

### Parameters

| Parameter                                  | Type                                       | Required                                   | Description                                |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| `request`                                  | *byte[]*                                   | :heavy_check_mark:                         | The request object to use for the request. |


### Response

**[SendMixedParamResponse](../../Models/Operations/SendMixedParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## SendNonScalarParam

Send NonScalarParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

Dictionary<string, RequestBody> req = new Dictionary<string, RequestBody>() {

};

var res = await sdk.Sender.SendNonScalarParamAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | Dictionary<String, [RequestBody](../../Models/Operations/RequestBody.md)> | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[SendNonScalarParamResponse](../../Models/Operations/SendNonScalarParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## SendScalarParam

Send ScalarParam

### Example Usage

```csharp
using OAFComplex;

var sdk = new OAFComplexSDK();

List<Dictionary<string, SendScalarParamRequestBody>> req = new List<Dictionary<string, SendScalarParamRequestBody>>() {
    new Dictionary<string, SendScalarParamRequestBody>() {
        { "key", SendScalarParamRequestBody.CreateSendScalarParamRequestBodyStr(
        "<value>",
        ) },
    },
};

var res = await sdk.Sender.SendScalarParamAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | List<Dictionary<String, [SendScalarParamRequestBody](../../Models/Operations/SendScalarParamRequestBody.md)>> | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[SendScalarParamResponse](../../Models/Operations/SendScalarParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## SendinModel

Send in Model

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Shared;
using System.Collections.Generic;
using NodaTime;

var sdk = new OAFComplexSDK();

SendinModelRequestBody req = new SendinModelRequestBody() {
    MixedModel = new MixedModel() {
        AllInnerArrayOfMap = AllInnerArrayOfMap.CreateAllInnerArrayOfMapArrayOfmapOfboolean(
                new List<Dictionary<string, bool>>() {
                    new Dictionary<string, bool>() {
                        { "key", false },
                    },
                },
        ),
        AllInnerArrayOfMap2 = new Dictionary<string, AllInnerArrayOfMap2>() {
            { "key", AllInnerArrayOfMap2.CreateAllInnerArrayOfMap2ArrayOfmapOfVehicle(
                new List<Dictionary<string, Vehicle>>() {
                    new Dictionary<string, Vehicle>() {
                        { "key", new Vehicle() {
                            NumberOfTyres = "<value>",
                        } },
                    },
                },
            ) },
        },
        MultiAnyOf = MultiAnyOf.CreateMultiAnyOfOne(
                One.CreateOneCar(
                            new Car() {
                                HaveTrunk = false,
                                NumberOfTyres = "<value>",
                            },
                ),
        ),
        MultiOneOfAnyOf = MultiOneOfAnyOf.CreateMultiOneOfAnyOfMorning(
                new Morning() {
                    EndsAt = "<value>",
                    OfferTeaBreak = false,
                    SessionType = "<value>",
                    StartsAt = "<value>",
                },
        ),
        OuterMapOfSingleInnerArray = new Dictionary<string, OuterMapOfSingleInnerArray>() {
            { "key", OuterMapOfSingleInnerArray.CreateOuterMapOfSingleInnerArrayOrbit(
                new Orbit() {
                    NumberOfElectrons = 393577,
                },
            ) },
        },
        SingleInnerMapOfArray = SingleInnerMapOfArray.CreateSingleInnerMapOfArrayMapOfarrayOfint32(
                new Dictionary<string, List<int>>() {
                    { "key", new List<int>() {
                        12005,
                    } },
                },
        ),
    },
    NonScalarModel = new NonScalarModel() {
        AllInnerArrayOfMap = NonScalarModelAllInnerArrayOfMap.CreateNonScalarModelAllInnerArrayOfMapArrayOfmapOfOrbit(
                new List<Dictionary<string, Orbit>>() {
                    new Dictionary<string, Orbit>() {
                        { "key", new Orbit() {
                            NumberOfElectrons = 502330,
                        } },
                    },
                },
        ),
        AllInnerArrayOfMap2 = new Dictionary<string, NonScalarModelAllInnerArrayOfMap2>() {
            { "key", NonScalarModelAllInnerArrayOfMap2.CreateNonScalarModelAllInnerArrayOfMap2ArrayOfmapOfVehicle(
                new List<Dictionary<string, Vehicle>>() {
                    new Dictionary<string, Vehicle>() {
                        { "key", new Vehicle() {
                            NumberOfTyres = "<value>",
                        } },
                    },
                },
            ) },
        },
        MultiAnyOf = NonScalarModelMultiAnyOf.CreateNonScalarModelMultiAnyOfNonScalarModel1(
                NonScalarModel1.CreateNonScalarModel1Atom(
                            new Atom() {
                                NumberOfElectrons = 156368,
                            },
                ),
        ),
        MultiOneOfAnyOf = NonScalarModelMultiOneOfAnyOf.CreateNonScalarModelMultiOneOfAnyOfMorning(
                new Morning() {
                    EndsAt = "<value>",
                    OfferTeaBreak = false,
                    SessionType = "<value>",
                    StartsAt = "<value>",
                },
        ),
        OuterMapOfSingleInnerArray = new Dictionary<string, NonScalarModelOuterMapOfSingleInnerArray>() {

        },
        SingleInnerMapOfArray = NonScalarModelSingleInnerMapOfArray.CreateNonScalarModelSingleInnerMapOfArrayMapOfAtom(
                new Dictionary<string, Atom>() {
                    { "key", new Atom() {
                        NumberOfElectrons = 2189,
                    } },
                },
        ),
    },
};

var res = await sdk.Sender.SendinModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [SendinModelRequestBody](../../Models/Shared/SendinModelRequestBody.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[SendinModelResponse](../../Models/Operations/SendinModelResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |
