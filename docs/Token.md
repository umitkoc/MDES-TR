# Acme.App.MastercardApi.Client.Model.Token

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenUniqueReference** | **string** | A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. Note; It is required to be always present, even when an error occurs. | 
**status** | **string** | The current status of token. Conditional - required for notifyTokenUpdated if reasonCode &#x3D; \&quot;STATUS_UPDATE\&quot;. Not present otherwise. Must be one of;  * INACTIVE - Token has not yet been activated,  * ACTIVE - Token is active and ready to transact, * SUSPENDED - Token is suspended and unable to transact,  * DEACTIVATED - Token has been permanently deactivated.   | [optional] 
**suspendedBy** | **List&lt;string&gt;** | Who or what caused the token to be suspended. Conditional - required if status &#x3D; SUSPENDED.  One or more values of;  * ISSUER &#x3D; Suspended by the Issuer. PaymentAppProvider unable to unsuspend this token,  * PAYMENT_APP_PROVIDER (Deprecated) &#x3D; Suspended by the PaymentAppProvider, * TOKEN_REQUESTOR &#x3D; Suspended by the Token Requestor,   * MOBILE_PIN_LOCKED &#x3D; Suspended  due to the Mobile PIN being locked, * CARDHOLDER &#x3D; Suspended by the Cardholder.    | [optional] 
**tokenExpiry** | **string** | The expiry of the Token PAN given in MMYY format. Conditional - Required for notifyTokenUpdated if reasonCode &#x3D; \&quot;REDIGITIZATION_COMPLETE\&quot;. Not present otherwise. | [optional] 
**fundingAccountInfo** | [**FundingAccountInfoSchemaForNTU**](FundingAccountInfoSchemaForNTU.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

