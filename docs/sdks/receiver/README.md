# Receiver
(*.Receiver*)

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
| `request`                                                         | [MixedModelRequest](../../models/operations/MixedModelRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedModelResponse](../../models/operations/MixedModelResponse.md)**


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
| `request`                                                         | [MixedParamRequest](../../models/operations/MixedParamRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[MixedParamResponse](../../models/operations/MixedParamResponse.md)**


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
| `request`                                                                 | [NonScalarModelRequest](../../models/operations/NonScalarModelRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarModelResponse](../../models/operations/NonScalarModelResponse.md)**


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
| `request`                                                                 | [NonScalarParamRequest](../../models/operations/NonScalarParamRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[NonScalarParamResponse](../../models/operations/NonScalarParamResponse.md)**


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
| `request`                                                           | [ScalarModelRequest](../../models/operations/ScalarModelRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarModelResponse](../../models/operations/ScalarModelResponse.md)**


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
| `request`                                                           | [ScalarParamRequest](../../models/operations/ScalarParamRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[ScalarParamResponse](../../models/operations/ScalarParamResponse.md)**

