# Acme.App.MastercardApi.Client.Api.ValidateActivationCodeApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ValidateActivationCode**](ValidateActivationCodeApi.md#validateactivationcode) | **POST** /validateActivationCode | Activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response. |

<a id="validateactivationcode"></a>
# **ValidateActivationCode**
> ValidateActivationCodeResponseSchema ValidateActivationCode (ValidateActivationCodeRequestSchema validateActivationCodeRequestSchema)

Activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response.

This API is used to activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response. A Token may be activated via this API when activation is requested with activationCode and Issuer have chosen the option to validate the code self. If activation code validation is successful, MDES will complete the provisioning process and will notify the Token Requestor when the Token is ready to transact, using the Notify Token Updated API. Note that the user is only given a limited number of attempts to enter a correct Activation Code (typically 3 attempts), after which the Activation Code becomes invalid. In this event, it may be possible to request a new Activation Code directly from the Issuer via customer service or otherwise. This is dependent on individual Issuer implementation and out of scope of this API.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class ValidateActivationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new ValidateActivationCodeApi(config);
            var validateActivationCodeRequestSchema = new ValidateActivationCodeRequestSchema(); // ValidateActivationCodeRequestSchema | Contains the details of the request message.

            try
            {
                // Activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response.
                ValidateActivationCodeResponseSchema result = apiInstance.ValidateActivationCode(validateActivationCodeRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ValidateActivationCodeApi.ValidateActivationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ValidateActivationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Activate a Token for first-time use if the digitization decision was to ‘Require Additional Authentication’ in the Digitize response.
    ApiResponse<ValidateActivationCodeResponseSchema> response = apiInstance.ValidateActivationCodeWithHttpInfo(validateActivationCodeRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ValidateActivationCodeApi.ValidateActivationCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **validateActivationCodeRequestSchema** | [**ValidateActivationCodeRequestSchema**](ValidateActivationCodeRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**ValidateActivationCodeResponseSchema**](ValidateActivationCodeResponseSchema.md)

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

