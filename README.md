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
<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package OAF-Complex
```
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

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

<!-- Start Available Resources and Operations [operations] -->
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
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://enehkteyzt55p.x.pipedream.net/{subUrl}` | `subUrl` (default is `multitype/complex`) |
| 1 | `http://localhost:3000/{subUrl}` | `subUrl` (default is `multitype/complex`) |



#### Variables

Some of the server options above contain variables. If you want to set the values of those variables, the following options are provided for doing so:
 * `subUrl: string`

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                          | Status Code                           | Content Type                          |
| ------------------------------------- | ------------------------------------- | ------------------------------------- |
| OAFComplex.Models.Errors.SDKException | 4xx-5xx                               | */*                                   |

### Example

```csharp
using OAFComplex;
using System;
using OAFComplex.Models.Errors;
using OAFComplex.Models.Operations;
using OAFComplex.Models.Shared;

var sdk = new OAFComplexSDK();

MixedModelRequest req = new MixedModelRequest() {
    Case = CaseEnum.CaseA,
};

try
{
    var res = await sdk.Receiver.MixedModelAsync(req);
    // handle response
}
catch (Exception ex)
{
    }
    else if (ex is OAFComplex.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

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
