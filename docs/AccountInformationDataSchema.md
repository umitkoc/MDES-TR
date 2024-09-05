# Acme.App.MastercardApi.Client.Model.AccountInformationDataSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**dataValidUntilTimestamp** | **string** | The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm  Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes).  | [optional] 
**balanceInformation** | [**BalanceInformationSchema**](BalanceInformationSchema.md) |  | [optional] 
**accountStatus** | **string** | The status of the account. Must be one of ACTIVE &#x3D; The account is active | EXPIRED &#x3D; The account is expired | INVALID &#x3D; The account is not recognized | UNKNOWN &#x3D; The account is in an unknown state | CANCELLED &#x3D; The account is cancelled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

