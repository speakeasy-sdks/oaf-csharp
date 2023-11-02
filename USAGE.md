<!-- Start SDK Example Usage -->


```csharp
using OAFComplex;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

var res = await sdk.Receiver.MixedModelAsync(new MixedModelRequest() {
    Case = OAFComplex.Models.Shared.CaseEnum.CaseA,
});

// handle response
```
<!-- End SDK Example Usage -->