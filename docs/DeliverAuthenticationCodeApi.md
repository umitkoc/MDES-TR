# Org.OpenAPITools.Api.DeliverAuthenticationCodeApi

All URIs are relative to *https://api.mastercard.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeliverAuthenticationCode**](DeliverAuthenticationCodeApi.md#deliverauthenticationcode) | **POST** /deliverAuthenticationCode | deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated. |

<a id="deliverauthenticationcode"></a>
# **DeliverAuthenticationCode**
> DeliverAuthenticationCodeResponseSchema DeliverAuthenticationCode (DeliverAuthenticationCodeRequestSchema deliverAuthenticationCodeRequestSchema)

deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.

The apiName is 'deliverAuthenticationCode'. A Deliver Authentication Code message is used to notify an authentication code is to send to the account holder associated to the funding account information. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeliverAuthenticationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.mastercard.com";
            var apiInstance = new DeliverAuthenticationCodeApi(config);
            var deliverAuthenticationCodeRequestSchema = new DeliverAuthenticationCodeRequestSchema(); // DeliverAuthenticationCodeRequestSchema | Deliver Authentication Code request.

            try
            {
                // deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
                DeliverAuthenticationCodeResponseSchema result = apiInstance.DeliverAuthenticationCode(deliverAuthenticationCodeRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliverAuthenticationCodeApi.DeliverAuthenticationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeliverAuthenticationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // deliverAuthenticationCode is used to request an Authentication Code be sent to authenticate the Account holder. Upon an Authentication Service request, the Authentication Service generates an Authentication Code and delivers it to the Issuer for transmission to the Account holder. The Issuer can choose a default channel to transmit the code to the account holder. The account holder will then enter the Authentication Code into the Authentication Service client. Once an Authentication Code has been generated, it will be valid for a limited period after which the code will expire. Once a code expires, there is no means for an Issuer to request a new code. The account holder may request the Authentication Code again. This will trigger another Deliver Authentication Code request. If the current Authentication Code is still valid then the code will not be regenerated nor the validity period extended. If the Code has expired or too many attempts have failed validation then a new code will be generated.
    ApiResponse<DeliverAuthenticationCodeResponseSchema> response = apiInstance.DeliverAuthenticationCodeWithHttpInfo(deliverAuthenticationCodeRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliverAuthenticationCodeApi.DeliverAuthenticationCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliverAuthenticationCodeRequestSchema** | [**DeliverAuthenticationCodeRequestSchema**](DeliverAuthenticationCodeRequestSchema.md) | Deliver Authentication Code request. |  |

### Return type

[**DeliverAuthenticationCodeResponseSchema**](DeliverAuthenticationCodeResponseSchema.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deliver Authentication Code Response |  -  |
| **0** | Error Response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

