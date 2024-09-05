# Acme.App.MastercardApi.Client.Model.AccountHolderDataSchema
Additional information that can be used to identify the account holder, such as name, address, etc. Max length - Not applicable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountHolderName** | **string** | The name of the account holder in the format LASTNAME/FIRSTNAME or FIRSTNAME LASTNAME . Max length - 27. Type - String. | [optional] 
**accountHolderAddress** | [**BillingAddressSchema**](BillingAddressSchema.md) |  | [optional] 
**sourceIp** | **string** | The IP of the device initiating the request. | [optional] 
**deviceLocation** | **string** | Latitude and longitude where the device the consumer is attempting to authorize is located. In the format \&quot;(sign) latitude/(sign) longitude\&quot; with a precision of 2 decimal places. Ex:\&quot;38.63/-90.2\&quot;. Latitude is between -90 and 90. Longitude between -180 and 180. | [optional] 
**consumerIdentifier** | **string** | Consumer Identifier provided by the token requestor. Not required – Optionally present in AuthorizeService when provided by the wallet provider. | [optional] 
**accountHolderEmailAddress** | **string** | The email address of the account holder. Not required - Optionally present in pushAccount request. Not present otherwise. | [optional] 
**accountHolderMobilePhoneNumber** | [**PhoneNumberSchema**](PhoneNumberSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

