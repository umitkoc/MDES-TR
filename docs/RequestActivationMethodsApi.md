# Acme.App.MastercardApi.Client.Api.RequestActivationMethodsApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RequestForActivationMethods**](RequestActivationMethodsApi.md#requestforactivationmethods) | **POST** /requestActivationMethods | Requests Activation Methods from the Account holder. |

<a id="requestforactivationmethods"></a>
# **RequestForActivationMethods**
> RequestActivationMethodsResponseSchema RequestForActivationMethods (RequestActivationMethodsRequestSchema requestActivationMethodsRequestSchema)

Requests Activation Methods from the Account holder.

RequestActivationMethods advises an Issuer that a service activation has been requested and that an Issuer should provide Activation Methods for the Account holder.  The Activation Methods will be presented to the Account holder so they may select their preferred delivery channel to receive an Activation Code only when the card eligibility decision is “Require Authentication.”  If there are no methods to return then an empty ActivationMethods array is returned.  If verification of the card data provided in the request fails then an empty ActivationMethods array should be returned. This includes an unknown PAN or if the expiration date or the CVC2 do not match.  This call is made as part of the service activation flow and may be subject to strict time constraints based on the service. If applicable to the service, when no methods are returned or in case of service failure the MDES system will use the methods returned by the pre-digitization network messages or the default methods for the account range. The methods returned from this API will be combined with the activation methods returned from the pre-digitization network messages and any methods configured as forced.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class RequestForActivationMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new RequestActivationMethodsApi(config);
            var requestActivationMethodsRequestSchema = new RequestActivationMethodsRequestSchema(); // RequestActivationMethodsRequestSchema | Contains the details of the request message.

            try
            {
                // Requests Activation Methods from the Account holder.
                RequestActivationMethodsResponseSchema result = apiInstance.RequestForActivationMethods(requestActivationMethodsRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RequestActivationMethodsApi.RequestForActivationMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RequestForActivationMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Requests Activation Methods from the Account holder.
    ApiResponse<RequestActivationMethodsResponseSchema> response = apiInstance.RequestForActivationMethodsWithHttpInfo(requestActivationMethodsRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RequestActivationMethodsApi.RequestForActivationMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **requestActivationMethodsRequestSchema** | [**RequestActivationMethodsRequestSchema**](RequestActivationMethodsRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**RequestActivationMethodsResponseSchema**](RequestActivationMethodsResponseSchema.md)

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

