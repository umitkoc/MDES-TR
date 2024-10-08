# Acme.App.MastercardApi.Client - the C# library for the Mastercard Digital Enablement Service Issuer Outbound API

The MDES Issuer Outbound Pre-Digitization API supports the pre-digitization web services provided by the Digitization Service. The web services are used to inform Issuers of MDES services being requested by, or on-behalf of, their account holders. Issuers may provide information in their responses to guide or inform the Account holder’s experience through the Token Reqestor.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.21 (Document version)
- SDK version: 1.0.0
- Generator version: 7.8.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://developer.mastercard.com/support](https://developer.mastercard.com/support)

<a id="frameworks-supported"></a>z
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;
```
<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new AuthorizeServiceApi(config);
            var authorizeServiceRequestSchema = new AuthorizeServiceRequestSchema(); // AuthorizeServiceRequestSchema | Contains the details of the request message.

            try
            {
                // Requests an Issuer to authorize a Funding Account for a Mastercard service or set of services.
                AuthorizeServiceResponseSchema result = apiInstance.AuthorizeService(authorizeServiceRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthorizeServiceApi.AuthorizeService: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://mybank.com/issuerServices/1/0*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizeServiceApi* | [**AuthorizeService**](docs/AuthorizeServiceApi.md#authorizeservice) | **POST** /authorizeService | Requests an Issuer to authorize a Funding Account for a Mastercard service or set of services.
*DeliverActivationCodeApi* | [**DeliverActivationCode**](docs/DeliverActivationCodeApi.md#deliveractivationcode) | **POST** /deliverActivationCode | Used to deliver an Activation Code to authenticate the Account holder.
*GetAccountInformationApi* | [**GetAccountInformation**](docs/GetAccountInformationApi.md#getaccountinformation) | **POST** /getAccountInformation | Requests information about a funding account for a Mastercard service or set of services.
*NotifyServiceActivatedApi* | [**NotifyServiceActivated**](docs/NotifyServiceActivatedApi.md#notifyserviceactivated) | **POST** /notifyServiceActivated | Receive notifications that the provisioning and activation of a token.
*NotifySuspiciousEventsApi* | [**NotifySuspiciousEvents**](docs/NotifySuspiciousEventsApi.md#notifysuspiciousevents) | **POST** /notifySuspiciousEvents | Notifies issuers of any suspicious activties
*NotifyTokenUpdatedApi* | [**NotifyTokenUpdated**](docs/NotifyTokenUpdatedApi.md#notifytokenupdated) | **POST** /notifyTokenUpdated | Notify the Issuer of significant token updates, such as when the token is suspended, unsuspended or deleted.
*RequestActivationMethodsApi* | [**RequestForActivationMethods**](docs/RequestActivationMethodsApi.md#requestforactivationmethods) | **POST** /requestActivationMethods | Requests Activation Methods from the Account holder.
*ValidateActivationCodeApi* | [**ValidateActivationCode**](docs/ValidateActivationCodeApi.md#validateactivationcode) | **POST** /validateActivationCode | Activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AccountHolderDataSchema](docs/AccountHolderDataSchema.md)
 - [Model.AccountInformationDataSchema](docs/AccountInformationDataSchema.md)
 - [Model.ActivationMethod](docs/ActivationMethod.md)
 - [Model.AuthorizeServiceRequestSchema](docs/AuthorizeServiceRequestSchema.md)
 - [Model.AuthorizeServiceResponseDataSchema](docs/AuthorizeServiceResponseDataSchema.md)
 - [Model.AuthorizeServiceResponseSchema](docs/AuthorizeServiceResponseSchema.md)
 - [Model.BalanceInformationSchema](docs/BalanceInformationSchema.md)
 - [Model.BillingAddressSchema](docs/BillingAddressSchema.md)
 - [Model.CardAccountDataSchema](docs/CardAccountDataSchema.md)
 - [Model.ChipDataSchema](docs/ChipDataSchema.md)
 - [Model.ChipDataValidationResult](docs/ChipDataValidationResult.md)
 - [Model.DeliverActivationCodeRequestSchema](docs/DeliverActivationCodeRequestSchema.md)
 - [Model.DeliverActivationCodeResponseSchema](docs/DeliverActivationCodeResponseSchema.md)
 - [Model.DeviceInfo](docs/DeviceInfo.md)
 - [Model.EncryptedPayloadIn](docs/EncryptedPayloadIn.md)
 - [Model.EncryptedPayloadOut](docs/EncryptedPayloadOut.md)
 - [Model.EncryptedPayloadOut1](docs/EncryptedPayloadOut1.md)
 - [Model.EncryptedPayloadSchemaForNTU](docs/EncryptedPayloadSchemaForNTU.md)
 - [Model.ErrorsResponse](docs/ErrorsResponse.md)
 - [Model.FinancialAccountDataSchema](docs/FinancialAccountDataSchema.md)
 - [Model.FundingAccountDataSchema](docs/FundingAccountDataSchema.md)
 - [Model.FundingAccountDataSchemaForNTU](docs/FundingAccountDataSchemaForNTU.md)
 - [Model.FundingAccountInfoSchema1](docs/FundingAccountInfoSchema1.md)
 - [Model.FundingAccountInfoSchema2](docs/FundingAccountInfoSchema2.md)
 - [Model.FundingAccountInfoSchemaForNTU](docs/FundingAccountInfoSchemaForNTU.md)
 - [Model.GetAccountInformationRequestSchema](docs/GetAccountInformationRequestSchema.md)
 - [Model.GetAccountInformationResponseSchema](docs/GetAccountInformationResponseSchema.md)
 - [Model.NotifyServiceActivatedRequestSchema](docs/NotifyServiceActivatedRequestSchema.md)
 - [Model.NotifyServiceActivatedResponseSchema](docs/NotifyServiceActivatedResponseSchema.md)
 - [Model.NotifySuspiciousEventsRequestSchema](docs/NotifySuspiciousEventsRequestSchema.md)
 - [Model.NotifySuspiciousEventsResponseSchema](docs/NotifySuspiciousEventsResponseSchema.md)
 - [Model.NotifyTokenUpdatedRequestSchema](docs/NotifyTokenUpdatedRequestSchema.md)
 - [Model.NotifyTokenUpdatedResponseSchema](docs/NotifyTokenUpdatedResponseSchema.md)
 - [Model.PhoneNumberSchema](docs/PhoneNumberSchema.md)
 - [Model.RequestActivationMethodsRequestSchema](docs/RequestActivationMethodsRequestSchema.md)
 - [Model.RequestActivationMethodsResponseSchema](docs/RequestActivationMethodsResponseSchema.md)
 - [Model.SuspiciousEvent](docs/SuspiciousEvent.md)
 - [Model.SystemAtcStatus](docs/SystemAtcStatus.md)
 - [Model.Token](docs/Token.md)
 - [Model.TokenDataSchema](docs/TokenDataSchema.md)
 - [Model.TokenDataSchema1](docs/TokenDataSchema1.md)
 - [Model.TokenDataSchemaforNTU](docs/TokenDataSchemaforNTU.md)
 - [Model.ValidateActivationCodeRequestSchema](docs/ValidateActivationCodeRequestSchema.md)
 - [Model.ValidateActivationCodeResponseSchema](docs/ValidateActivationCodeResponseSchema.md)
 - [Model.WalletAtcStatus](docs/WalletAtcStatus.md)
 - [Model.WalletProviderDecisioningInfo](docs/WalletProviderDecisioningInfo.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

