# Acme.App.MastercardApi.Client.Api.AuthorizeServiceApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorizeService**](AuthorizeServiceApi.md#authorizeservice) | **POST** /authorizeService | Requests an Issuer to authorize a Funding Account for a Mastercard service or set of services. |

<a id="authorizeservice"></a>
# **AuthorizeService**
> AuthorizeServiceResponseSchema AuthorizeService (AuthorizeServiceRequestSchema authorizeServiceRequestSchema)

Requests an Issuer to authorize a Funding Account for a Mastercard service or set of services.

AuthorizeService requests an Issuer to authorize a Funding Account for a Mastercard service or set of services.  Information about the service request will be provided to assist with authorization of the account. If additional authentication is required the Issuer may return a list of Activation Methods.  The Activation Methods will be presented to the Account holder so they may select their preferred delivery channel to receive an Activation Code.  If there are no methods to return the field may be omitted.  This call is made as part of the service activation flow and may be subject to strict time constraints based on the service.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class AuthorizeServiceExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizeServiceApi.AuthorizeService: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorizeServiceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests an Issuer to authorize a Funding Account for a Mastercard service or set of services.
    ApiResponse<AuthorizeServiceResponseSchema> response = apiInstance.AuthorizeServiceWithHttpInfo(authorizeServiceRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizeServiceApi.AuthorizeServiceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorizeServiceRequestSchema** | [**AuthorizeServiceRequestSchema**](AuthorizeServiceRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**AuthorizeServiceResponseSchema**](AuthorizeServiceResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Contains the details of the response message. |  -  |
| **0** | unexpected error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

