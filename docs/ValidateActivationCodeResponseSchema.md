# Acme.App.MastercardApi.Client.Model.ValidateActivationCodeResponseSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**responseId** | **string** | The Id of the response returned. | 
**result** | **string** | Whether the activation request was successful. Success will result in MDES attempting to complete the provisioning process. MDES will notify the Token Requestor when the Token is ready to transact. Must be one of; SUCCESS &#x3D; Activation was successful, INCORRECT_CODE &#x3D; Activation Code was incorrect and rejected. Retries permitted,  INCORRECT_CODE_RETRIES_EXCEEDED &#x3D;  Activation Code was incorrect and the maximum number of retries now exceeded, EXPIRED_CODE &#x3D; Activation Code has expired or was invalidated. Max length - 32. Type - String. Required. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

