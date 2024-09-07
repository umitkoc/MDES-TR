# Org.OpenAPITools.Model.CardAccountDataSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountNumber** | **string** | The Account Primary Account Number (PAN) of the account holder to be authenticated.&lt;br&gt;  __Max length - 19, min length - 9. Type - Numeric characters only__ | 
**expiryMonth** | **string** | The month of the expiration date of the card to be authenticated. May be omitted if the card does not have an expiry date. &lt;br&gt;  __Length - exactly 2. Type - Numeric characters only__ | [optional] 
**expiryYear** | **string** | The year of the expiration date of the card to be authenticated. May be omitted if the card does not have an expiry date. &lt;br&gt;  __Length - exactly 2. Type - Numeric characters only__ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

