# Acme.App.MastercardApi.Client.Model.AuthorizeServiceResponseDataSchema
Contains an encrypted JSON object. Encrypted by the ephemeral AES key using CBC mode (IV as provided in 'iv', or zero if none provided) and PKCS#7 padding. The JSON object being encrypted will be defined in the context of the API call. Max length - 256k.  Type - String Hex-encoded Data (case-insensitive). Required - Yes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**dataValidUntilTimestamp** | **string** | The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes).  | [optional] 
**paymentAccountReference** | **string** | The payment account reference assigned to the PAN. This should only be returned if Mastercard is not the BIN controller.  It will be ignored if Mastercard is the BIN controller for the PAN. | [optional] 
**alternateAccountIdentifier** | **string** | Account holder-friendly reference to a bank account. Typically used when the account holder is not aware of their Account PAN. | [optional] 
**issuerSpecificPersonalizationData** | **List&lt;string&gt;** | The operator specific data to add to token personalization profile.  Not applicable. Type - Array [String]. Optional. | [optional] 
**externalToken** | [**TokenDataSchema**](TokenDataSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

