# Acme.App.MastercardApi.Client.Model.FundingAccountDataSchemaForNTU

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**dataValidUntilTimestamp** | **string** | The date/time after which this encrypted object is considered invalid. If present, all systems must reject this encrypted object after this time and treat it as invalid data. Must be expressed in ISO 8601 extended format as one of the following:   - YYYY-MM-DDThh:mm:ss[.sss]Z   - YYYY-MM-DDThh:mm:ss[.sss]±hh:mm Where [.sss] is optional and can be 1 to 3 digits. Must be a value no more than 30 days in the future. Mastercard recommends using a value of (Current Time + 30 minutes).  | [optional] 
**cardAccountData** | [**CardAccountDataSchema**](CardAccountDataSchema.md) |  | [optional] 
**tokenData** | [**TokenDataSchemaforNTU**](TokenDataSchemaforNTU.md) |  | 
**financialAccountData** | [**FinancialAccountDataSchema**](FinancialAccountDataSchema.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

