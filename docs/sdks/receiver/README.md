# Receiver
(*Receiver*)

### Available Operations

* [MixedModel](#mixedmodel) - MixedModel
* [MixedParam](#mixedparam) - MixedParam
* [NonScalarModel](#nonscalarmodel) - NonScalarModel
* [NonScalarParam](#nonscalarparam) - NonScalarParam
* [ScalarModel](#scalarmodel) - ScalarModel
* [ScalarParam](#scalarparam) - ScalarParam

## MixedModel

MixedModel

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

MixedModelRequest req = new MixedModelRequest() {
    Case = CaseEnum.CaseA,
};

var res = await sdk.Receiver.MixedModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [MixedModelRequest](../../Models/Operations/MixedModelRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedModelResponse](../../Models/Operations/MixedModelResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## MixedParam

MixedParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

MixedParamRequest req = new MixedParamRequest() {
    Case = CaseEnum.CaseA,
};

var res = await sdk.Receiver.MixedParamAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [MixedParamRequest](../../Models/Operations/MixedParamRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedParamResponse](../../Models/Operations/MixedParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## NonScalarModel

NonScalarModel

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

NonScalarModelRequest req = new NonScalarModelRequest() {
    Case = CaseEnum.CaseB,
};

var res = await sdk.Receiver.NonScalarModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [NonScalarModelRequest](../../Models/Operations/NonScalarModelRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarModelResponse](../../Models/Operations/NonScalarModelResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## NonScalarParam

NonScalarParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

NonScalarParamRequest req = new NonScalarParamRequest() {
    Case = CaseEnum.CaseA,
};

var res = await sdk.Receiver.NonScalarParamAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [NonScalarParamRequest](../../Models/Operations/NonScalarParamRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarParamResponse](../../Models/Operations/NonScalarParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## ScalarModel

ScalarModel

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

ScalarModelRequest req = new ScalarModelRequest() {
    Case = CaseEnum.CaseB,
};

var res = await sdk.Receiver.ScalarModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ScalarModelRequest](../../Models/Operations/ScalarModelRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarModelResponse](../../Models/Operations/ScalarModelResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

## ScalarParam

ScalarParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

ScalarParamRequest req = new ScalarParamRequest() {
    Case = CaseEnum.CaseA,
};

var res = await sdk.Receiver.ScalarParamAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ScalarParamRequest](../../Models/Operations/ScalarParamRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarParamResponse](../../Models/Operations/ScalarParamResponse.md)**
### Errors

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |
