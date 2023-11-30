<!-- Start SDK Example Usage [usage] -->
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
<!-- End SDK Example Usage [usage] -->