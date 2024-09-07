# Org.OpenAPITools.Model.FundingAccountDataSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardAccountData** | [**CardAccountDataSchema**](CardAccountDataSchema.md) |  | 
**financialAccountData** | [**FinancialAccountDataSchema**](FinancialAccountDataSchema.md) |  | [optional] 
**tokenData** | [**TokenDataSchema**](TokenDataSchema.md) |  | 
**dataValidUntilTimestamp** | **string** | The date/time after which this EncryptedData object is considered invalid. If present, all systems must reject this EncryptedData object after this time and treat it as invalid data. Expressed in ISO 8601 extended format. Must be either  * YYYY-MM-DDThh:mm:ss[.sss]Z  * YYYY-MM-DDThh:mm:ss[.sss]±hh:mm where [.sss] is optional and can be 1 to 3 digits. &lt;br&gt; &lt;br&gt;  __Max length - 29.__ | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

