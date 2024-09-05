# Acme.App.MastercardApi.Client.Model.NotifySuspiciousEventsRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The id of the request submitted. Max length - 64 | 
**tokenUniqueReference** | **string** | A Unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. | 
**paymentAppInstanceId** | **string** | The identifier of the Payment App instance within a device that will be provisioned with a token. Only present when supplied by a Wallet Provider. | [optional] 
**status** | **string** | The current status of token. Must be one of; INACTIVE - Token has not yet been activated, ACTIVE - Token is active and ready to transact, SUSPENDED - Token is suspended and unable to transact, DEACTIVATED - Token has been permanently deactivated. Max length - 32. Type - String. Conditional - required for notifyTokenUpdated if reasonCode &#x3D; \&quot;STATUS_UPDATE\&quot;. Not present otherwise. | 
**events** | [**SuspiciousEvent**](SuspiciousEvent.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

