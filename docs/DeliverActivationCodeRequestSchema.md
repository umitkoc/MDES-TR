# Acme.App.MastercardApi.Client.Model.DeliverActivationCodeRequestSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **string** | The id of the request submitted. Max length - 64 | 
**tokenUniqueReference** | **string** | A unique reference assigned following the allocation of a token used to identify the token for the duration of its lifetime. | 
**correlationId** | **string** | Value linking pre-digitization messages generated during provisioning. | 
**activationCode** | **string** | The Activation Code to be distributed for the digitization. Conditional - only present if Mastercard generates the activationCode. | [optional] 
**expirationDateTime** | **string** | The DateTime when the Activation Code is no longer valid. Expressed in ISO 8601 extended format as one of the following - YYYY-MM-DDThh:mm:ss[ .sss ]Z , YYYY-MM-DDThh:mm:ss[ .sss ]±hh:mm , Where [ .sss ] is optional and can be 1 to 3 digits. Conditional - only present if Mastercard generates the activationCode. | [optional] 
**activationMethod** | [**ActivationMethod**](ActivationMethod.md) |  | 
**reasonCodes** | **List&lt;string&gt;** | The reason the account holder is being authenticated.  The reason could impact the generation and validation of the code in a number of ways including but not limited to the time period of validity of the code and the number of attempts allowed to validate the code. New reason codes can be added at any time and should not result in a failure. Possible push methods are:   * ADD_CARD:  The account holder is being authenticated after adding the card to the token requestor   * VERIFY_ACCOUNT:  The account holder is being authenticated in order to verify account ownership.   * OTHER:  The account holder is being authenticated for a reason not enumerated in this list. Conditional - Only present for Conset Service  | [optional] 
**consumerFacingEntityName** | **string** | Entity name that account holder recognizes as being where they store their PAN (wallets, merchants, commerce platforms…). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

