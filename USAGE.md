<!-- Start SDK Example Usage [usage] -->
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
<!-- End SDK Example Usage [usage] -->