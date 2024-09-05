# Acme.App.MastercardApi.Client.Api.DeliverActivationCodeApi

All URIs are relative to *https://mybank.com/issuerServices/1/0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeliverActivationCode**](DeliverActivationCodeApi.md#deliveractivationcode) | **POST** /deliverActivationCode | Used to deliver an Activation Code to authenticate the Account holder. |

<a id="deliveractivationcode"></a>
# **DeliverActivationCode**
> DeliverActivationCodeResponseSchema DeliverActivationCode (DeliverActivationCodeRequestSchema deliverActivationCodeRequestSchema)

Used to deliver an Activation Code to authenticate the Account holder.

DeliverActivationCode is used to request an Activation Code be sent to authenticate the Account holder. MDES generates an Activation Code and delivers it, along with the chosen Activation Code Distribution Method, to the Issuer for transmission to the Account holder.  Alternately if the Issuer wishes to generate the Activation Code, MDES will deliver the chosen Activation Code Distribution Method to the Issuer and the Issuer will generate the Activation code and transmit it to the account holder. The Account holder will then enter the Activation Code into the Mobile Payment App. Once an Activation Code has been generated, it will be valid for a limited activation period, after which the code will expire. Once a code expires, the Issuer can request a new Activation Code via the Customer Service Portal/API, or remotely activate the token via the Customer Service Portal/API. The Account holder may request the Activation Code again with the same or a different Activation Code Distribution Method.  This will trigger another request as long as the activation period has not expired.  It will not cause the Activation Code to be regenerated nor extend the validity period of the Activation Code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Acme.App.MastercardApi.Client.Api;
using Acme.App.MastercardApi.Client.Client;
using Acme.App.MastercardApi.Client.Model;

namespace Example
{
    public class DeliverActivationCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://mybank.com/issuerServices/1/0";
            var apiInstance = new DeliverActivationCodeApi(config);
            var deliverActivationCodeRequestSchema = new DeliverActivationCodeRequestSchema(); // DeliverActivationCodeRequestSchema | Contains the details of the request message.

            try
            {
                // Used to deliver an Activation Code to authenticate the Account holder.
                DeliverActivationCodeResponseSchema result = apiInstance.DeliverActivationCode(deliverActivationCodeRequestSchema);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeliverActivationCodeApi.DeliverActivationCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeliverActivationCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Used to deliver an Activation Code to authenticate the Account holder.
    ApiResponse<DeliverActivationCodeResponseSchema> response = apiInstance.DeliverActivationCodeWithHttpInfo(deliverActivationCodeRequestSchema);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeliverActivationCodeApi.DeliverActivationCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **deliverActivationCodeRequestSchema** | [**DeliverActivationCodeRequestSchema**](DeliverActivationCodeRequestSchema.md) | Contains the details of the request message. |  |

### Return type

[**DeliverActivationCodeResponseSchema**](DeliverActivationCodeResponseSchema.md)

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

