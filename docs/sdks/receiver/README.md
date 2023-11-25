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

var sdk = new OAFComplex();

var res = await sdk.Receiver.MixedModelAsync(new MixedModelRequest() {
    Case = CaseEnum.CaseA,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [MixedModelRequest](../../Models/Operations/MixedModelRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedModelResponse](../../Models/Operations/MixedModelResponse.md)**


## MixedParam

MixedParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplex();

var res = await sdk.Receiver.MixedParamAsync(new MixedParamRequest() {
    Case = CaseEnum.CaseA,
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [MixedParamRequest](../../Models/Operations/MixedParamRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedParamResponse](../../Models/Operations/MixedParamResponse.md)**


## NonScalarModel

NonScalarModel

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplex();

var res = await sdk.Receiver.NonScalarModelAsync(new NonScalarModelRequest() {
    Case = CaseEnum.CaseB,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [NonScalarModelRequest](../../Models/Operations/NonScalarModelRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarModelResponse](../../Models/Operations/NonScalarModelResponse.md)**


## NonScalarParam

NonScalarParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplex();

var res = await sdk.Receiver.NonScalarParamAsync(new NonScalarParamRequest() {
    Case = CaseEnum.CaseA,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [NonScalarParamRequest](../../Models/Operations/NonScalarParamRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarParamResponse](../../Models/Operations/NonScalarParamResponse.md)**


## ScalarModel

ScalarModel

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplex();

var res = await sdk.Receiver.ScalarModelAsync(new ScalarModelRequest() {
    Case = CaseEnum.CaseB,
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ScalarModelRequest](../../Models/Operations/ScalarModelRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarModelResponse](../../Models/Operations/ScalarModelResponse.md)**


## ScalarParam

ScalarParam

### Example Usage

```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplex();

var res = await sdk.Receiver.ScalarParamAsync(new ScalarParamRequest() {
    Case = CaseEnum.CaseA,
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ScalarParamRequest](../../Models/Operations/ScalarParamRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarParamResponse](../../Models/Operations/ScalarParamResponse.md)**

