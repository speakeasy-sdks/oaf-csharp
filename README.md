# OAF-Complex

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://github.com/speakeasy-sdks/oaf-csharp.git/actions"><img src="https://img.shields.io/github/actions/workflow/status/speakeasy-sdks/oaf-csharp/speakeasy_sdk_generation.yml?style=for-the-badge" /></a>
    
</div>


## 🏗 **Welcome to your new SDK!** 🏗

It has been generated successfully based on your OpenAPI spec. However, it is not yet ready for production use. Here are some next steps:
- [ ] 🛠 Make your SDK feel handcrafted by [customizing it](https://www.speakeasyapi.dev/docs/customize-sdks)
- [ ] ♻️ Refine your SDK quickly by iterating locally with the [Speakeasy CLI](https://github.com/speakeasy-api/speakeasy)
- [ ] 🎁 Publish your SDK to package managers by [configuring automatic publishing](https://www.speakeasyapi.dev/docs/productionize-sdks/publish-sdks)
- [ ] ✨ When ready to productionize, delete this section from the README
<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package OAF-Complex
```
<!-- End SDK Installation -->

## SDK Example Usage
<!-- Start SDK Example Usage -->
### Example

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
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [Receiver](docs/sdks/receiver/README.md)

* [MixedModel](docs/sdks/receiver/README.md#mixedmodel) - MixedModel
* [MixedParam](docs/sdks/receiver/README.md#mixedparam) - MixedParam
* [NonScalarModel](docs/sdks/receiver/README.md#nonscalarmodel) - NonScalarModel
* [NonScalarParam](docs/sdks/receiver/README.md#nonscalarparam) - NonScalarParam
* [ScalarModel](docs/sdks/receiver/README.md#scalarmodel) - ScalarModel
* [ScalarParam](docs/sdks/receiver/README.md#scalarparam) - ScalarParam

### [Sender](docs/sdks/sender/README.md)

* [SendCollectCombined](docs/sdks/sender/README.md#sendcollectcombined) - Send CollectCombined
* [SendCombined](docs/sdks/sender/README.md#sendcombined) - Send Combined
* [SendMixedParam](docs/sdks/sender/README.md#sendmixedparam) - Send MixedParam
* [SendNonScalarParam](docs/sdks/sender/README.md#sendnonscalarparam) - Send NonScalarParam
* [SendScalarParam](docs/sdks/sender/README.md#sendscalarparam) - Send ScalarParam
* [SendinModel](docs/sdks/sender/README.md#sendinmodel) - Send in Model
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->



<!-- End Dev Containers -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
