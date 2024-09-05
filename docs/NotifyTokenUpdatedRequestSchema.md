# Acme.App.MastercardApi.Client.Model.NotifyTokenUpdatedRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The Id of the request submitted. Max length - 64 | 
**reasonCode** | **string** | The reason code for why the notification is being sent. This applies to all tokens in the Tokens array. Must be one of:   * STATUS_UPDATE - The status of the tokens has been changed when the token is activated, suspended, deleted, or inactivated.    * REDIGITIZATION_COMPLETE - The token has been re-digitized to the device in the token expiry and FPAN update to a new range use cases.   * DELETED_FROM_CONSUMER_APP - The token has been deleted from the consumer application. The token may still be active in MDES.    * AUTHENTICATION_PERFORMED - Account holder authentication was performed on the token. The status did not change as a result   * PAYMT_CHANNEL_PREFERENCE_UPDATED - Cardholder has updated the payment channels the token is allowed to be used for (India only).   * FUNDING_ACCOUNT_UPDATE - Token and FPAN mapping has been updated due to FPAN or expiry or Financial account has been changed but Token is not changed. The status did not change as a result.   | 
**tokens** | [**List&lt;Token&gt;**](Token.md) | Contains the Tokens which were updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

