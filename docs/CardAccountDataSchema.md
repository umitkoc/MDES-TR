# Acme.App.MastercardApi.Client.Model.CardAccountDataSchema
The credit or debit card information for the account that is being tokenized. Conditional - required if reasonCode = \"REDIGITIZATION_COMPLETE\" or \"FUNDING_ACCOUNT_UPDATE\". Only present in the FPAN update use case but requires to be opted in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountNumber** | **string** | The Account Primary Account Number of the card to be digitized. | 
**expiryMonth** | **string** | The month of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric). | [optional] 
**expiryYear** | **string** | The year of the expiration date of the card to be digitized. Note that the expiry date may not be in the past. May be omitted if the card does not have an expiry date. (Numeric). | [optional] 
**securityCode** | **string** | The CVC2 for the card to be digitized, as entered by the Cardholder. Verified as part of reaching the digitization decision. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

